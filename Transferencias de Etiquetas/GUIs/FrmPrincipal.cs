using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Transferencias_de_Etiquetas.Entity;
using Transferencias_de_Etiquetas.Modelos;

namespace Transferencias_de_Etiquetas.GUIs
{
    public partial class FrmPrincipal : Form
    {
        private usuarios user;
        private Exception exConsulta;
        List<Articulo> lstBodegasArticulos;
        private string sErrorNumeroEtiqueta = string.Empty, sErrorClaveArticulo = string.Empty;
        private string sRutaArchivoEscaneo;
        private List<WS_Friolala.EtiquetasGrid> lstEtiquetas;
        private TimeSpan tiempoInicio, tiempoFinal;

        public FrmPrincipal(usuarios user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sRutaArchivoEscaneo = string.Empty;
            ofdBuscar.ShowDialog();
            sRutaArchivoEscaneo = ofdBuscar.FileName;
            txbRutaArchivoEscaneo.Text = sRutaArchivoEscaneo;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Consultar();
        }
        private void Consultar()
        {
            if (sRutaArchivoEscaneo != null)
            {
                if (sRutaArchivoEscaneo.Trim() != string.Empty)
                {                    
                    exConsulta = null;
                    btnTransferir.Enabled = false;
                    btnConsultar.Enabled = false;
                    pbCargando.Visible = true;                    
                    bgwConsulta.RunWorkerAsync();
                }
                else
                {
                    MessageBox.Show("Seleccione un archivo de escaneo...");
                }
            }
        }
        private string obtenerListaDeEtiquetas()
        {
            //Leer el archivo de escaneo
            string ArrayEtiquetas = string.Empty;

            try
            {                
                if (sRutaArchivoEscaneo != null)
                {
                    StreamReader sr = new StreamReader(sRutaArchivoEscaneo);
                    ArrayEtiquetas = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return ArrayEtiquetas;
        }

        private void lblTitulo_DoubleClick(object sender, EventArgs e)
        {
            new FrmConfiguracion().ShowDialog();
        }

        private void bgwConsulta_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                tiempoInicio = DateTime.Now.TimeOfDay;
                WS_Friolala.ServicioWeb ws = new WS_Friolala.ServicioWeb();
                ws.Url = ws.Url;

                string sListaEtiquetas = obtenerListaDeEtiquetas();
                lstEtiquetas = ws.ConsultarEtiquetas(sListaEtiquetas).ToList();
            }
            catch (Exception ex)
            {
                exConsulta = ex;
            }
        }
        private void bgwConsulta_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (exConsulta == null)
            {
                gridEtiquetas.DataSource = lstEtiquetas;
                gvEtiquetas.BestFitColumns();
                btnConsultar.Enabled = true;
                pbCargando.Visible = false;
                if (lstEtiquetas.Count > 0)
                    btnTransferir.Enabled = true;
            }
            else
            {
                btnConsultar.Enabled = true;
                pbCargando.Visible = false;
                MessageBox.Show(exConsulta.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tiempoFinal = DateTime.Now.TimeOfDay;
            TimeSpan tiempoTotal = tiempoFinal - tiempoInicio;
            lblTiempo.Text = string.Format("Tiempo de consulta: {0} segundos.", tiempoTotal.Seconds.ToString());
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {            
            IDbTransaction Transaccion = null;
            try
            {
                string sConnectionString = string.Format(@"metadata=res://*/Entity.SeguimientoEtiquetas.csdl|
                                                                res://*/Entity.SeguimientoEtiquetas.ssdl|
                                                                res://*/Entity.SeguimientoEtiquetas.msl;
                                                      provider=MySql.Data.MySqlClient;
                                    provider connection string=';server={0}
                                                                ;user id={1}
                                                                ;password={2}                                                                
                                                                ;database={3}
                                                                ;port={4}'"
                                                                , Properties.Settings.Default.Servidor
                                                                , Properties.Settings.Default.Usuario
                                                                , Properties.Settings.Default.Contraseña
                                                                , Properties.Settings.Default.BaseDeDatos
                                                                , Properties.Settings.Default.Puerto);
                EtiquetasEntities Contexto = new EtiquetasEntities(sConnectionString);

                Contexto.Connection.Open();
                Transaccion = Contexto.Connection.BeginTransaction();
                Transferir(Contexto);

                Transaccion.Commit();

                MessageBox.Show("Transferencia realizada con éxito!!!" + Environment.NewLine +
                                string.Format("Se transfirieron {0} etiquetas.", lstEtiquetas.Count), 
                                "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }           
            catch (Exception ex)
            {
                if (Transaccion != null)
                {
                    // ***** La transacción se creó
                    Transaccion.Rollback();
                    
                    if (ex.InnerException != null)
                    {
                        Type tipoExcepcion = typeof(MySql.Data.MySqlClient.MySqlException);
                        if (ex.InnerException.GetType() == tipoExcepcion)
                        {
                            //Es una Excepcion del tipo MySql
                            var myEx = (MySql.Data.MySqlClient.MySqlException)ex.InnerException;

                            switch (myEx.Number)
                            {
                                case 1452:
                                    MessageBox.Show(string.Format("No se encontró el artículo con clave [ {0} ]."+Environment.NewLine+
                                                                  "Asegúrese de que el articulo esta dado de alta en el sistema.", sErrorClaveArticulo), 
                                                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 1062:
                                    MessageBox.Show(string.Format("La etiqueta [ {0} ] ya se encuentra en el sistema." + Environment.NewLine + 
                                                                  "No se pueden duplicar las etiquetas...", sErrorNumeroEtiqueta), 
                                                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }                    
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // ***** La transacción no se creó
                    if (ex.InnerException != null)
                    {
                        Type tipoExcepcion = typeof(MySql.Data.MySqlClient.MySqlException);

                        if (ex.InnerException.GetType() == tipoExcepcion)
                        {
                            //Es una Excepcion del tipo MySql
                            var myEx = (MySql.Data.MySqlClient.MySqlException)ex.InnerException;

                            switch (myEx.Number)
                            {
                                case 0:
                                    MessageBox.Show("No se puede conectar con el servidor, revise su conexión...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                case 1042:
                                    MessageBox.Show("No se puede conectar con el servidor, revise su conexión...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                            }
                        }
                        else
                        {
                            MessageBox.Show(ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
        }
        private void Transferir(EtiquetasEntities Contexto)
        {
            etiquetas etiqueta_sistema;
            foreach (WS_Friolala.EtiquetasGrid etiqueta in lstEtiquetas)
            {
                sErrorNumeroEtiqueta = etiqueta.NumeroDeEtiqueta;
                sErrorClaveArticulo = etiqueta.Clave;

                etiqueta_sistema = new etiquetas();
                etiqueta_sistema.numero_etiqueta = etiqueta.NumeroDeEtiqueta;
                etiqueta_sistema.tipo_etiqueta = "R";
                etiqueta_sistema.clave_articulo = etiqueta.Clave;
                etiqueta_sistema.fecha_empaque = etiqueta.FechaDeEmpaque;
                etiqueta_sistema.fecha_caducidad = etiqueta.FechaDeCaducidad;
                etiqueta_sistema.id_bodega = lstBodegasArticulos.FirstOrDefault(o => o.clave == etiqueta.Clave).id_bodega;
                etiqueta_sistema.id_usuario = this.user.id_usuario;
                etiqueta_sistema.cantidad = etiqueta.Cantidad;
                etiqueta_sistema.unidad = etiqueta.Unidad;
                etiqueta_sistema.piezas = etiqueta.Piezas;
                etiqueta_sistema.fecha_recepcion = DateTime.Today;
                etiqueta_sistema.estatus = "A";

                Contexto.etiquetas.AddObject(etiqueta_sistema);
                Contexto.SaveChanges();
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.Text = "Transferencia de etiquetas - " + user.nombre.ToUpper();
            ObtenerArticulos();
        }

        private void ObtenerArticulos()
        {
            MysqlMiniDal myDal =
                new MysqlMiniDal(Properties.Settings.Default.Servidor,
                                 Properties.Settings.Default.Usuario,
                                 Properties.Settings.Default.Contraseña,
                                 Properties.Settings.Default.Puerto
                                ,Properties.Settings.Default.BaseDeDatos);

            lstBodegasArticulos = myDal.ObtenerBodegasArticulos();
        }
    }
}
