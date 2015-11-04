using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Transferencias_de_Etiquetas.Entity;
using MySql.Data.MySqlClient;
using Transferencias_de_Etiquetas.Modelos;

namespace Transferencias_de_Etiquetas.GUIs
{
    public partial class FrmLogin : Form
    {
        private List<usuarios> lstUsuarios = new List<usuarios>();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                Inicializar();
            }
            catch (Exception ex)
            {
                MostrarFrmConfiguracion(ex);
            }
        }
        private void Inicializar()
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
                                                                ,Properties.Settings.Default.Servidor
                                                                ,Properties.Settings.Default.Usuario
                                                                ,Properties.Settings.Default.Contraseña
                                                                ,Properties.Settings.Default.BaseDeDatos
                                                                ,Properties.Settings.Default.Puerto);
            EtiquetasEntities Contexto = new EtiquetasEntities(sConnectionString);
            lstUsuarios = Contexto.usuarios.Where(o => o.estado == true).ToList();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Entrar();
            }
            catch (Exception ex)
            {
                MostrarFrmConfiguracion(ex);
            }
        }
        private void Entrar()
        {
            Inicializar();
            string sUser = txbUsuario.Text.ToUpper();
            string sPass = txbContraseña.Text.ToUpper();

            usuarios user = lstUsuarios.FirstOrDefault(o => o.username.ToUpper() == sUser && o.password.ToUpper() == sPass);
            if (user != null)
            {
                this.Hide();
                new FrmPrincipal(user).ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error en nombre de usuario o contraseña...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Entrar();
                }
                catch (Exception ex)
                {
                    MostrarFrmConfiguracion(ex);
                }
            }
        }

        private void MostrarFrmConfiguracion(Exception ex)
        {
            if (ex.InnerException != null)
            {
                Type tipoEx = typeof(MySqlException);
                if (ex.InnerException.GetType() == tipoEx)
                {
                    //Excepcion del tipo MYSQL
                    MySqlException myEx = (MySqlException)ex.InnerException;
                    switch (myEx.Number)
                    {
                        case 0: new FrmConfiguracion().ShowDialog();
                            break;
                        case 1046:
                            MessageBox.Show("No se ha seleccionado ninguna base de datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            new FrmConfiguracion().ShowDialog();
                            break;
                        default:
                            MessageBox.Show("Error con la conexion a la base de datos...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            new FrmConfiguracion().ShowDialog();
                            break;
                    }
                }
            }
            else
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
