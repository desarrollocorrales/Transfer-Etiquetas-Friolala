using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Transferencias_de_Etiquetas.Modelos;

namespace Transferencias_de_Etiquetas.GUIs
{
    public partial class FrmConfiguracion : Form
    {
        public FrmConfiguracion()
        {
            InitializeComponent();
        }

        private void FrmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarParametros();
        }
        private void CargarParametros()
        {
            txbServidor.Text = Properties.Settings.Default.Servidor;
            txbUsuario.Text = Properties.Settings.Default.Usuario;
            txbContraseña.Text = Properties.Settings.Default.Contraseña;
            txbPuerto.Text = Properties.Settings.Default.Puerto;
            CargarComboBox();
            txbWS.Text = Properties.Settings.Default.UrlWebService;
        }

        private void txbWS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {                
                wbServicio.Navigate(txbWS.Text);
            }
        }

        private void CargarComboBox()
        {
            try
            {
                cbBaseDeDatos.DataSource = new List<string>();
                string Servidor = txbServidor.Text;
                string Usuario = txbUsuario.Text;
                string Contraseña = txbContraseña.Text;
                string Puerto = txbPuerto.Text;
                MysqlMiniDal miniDal = new MysqlMiniDal(Servidor,Usuario,Contraseña,Puerto);
                List<string> lstBasesDeDatos = miniDal.ObtenerBasesDeDatos();

                cbBaseDeDatos.DataSource = lstBasesDeDatos;
                cbBaseDeDatos.SelectedItem = Properties.Settings.Default.BaseDeDatos;
            }
            catch
            {

            }
        }

        private void cbBaseDeDatos_Click(object sender, EventArgs e)
        {
            CargarComboBox();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            wbServicio.Navigate(txbWS.Text);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            Properties.Settings.Default.Servidor = txbServidor.Text;
            Properties.Settings.Default.Usuario = txbUsuario.Text;
            Properties.Settings.Default.Contraseña = txbContraseña.Text;
            Properties.Settings.Default.Puerto = txbPuerto.Text;
            Properties.Settings.Default.BaseDeDatos = (cbBaseDeDatos.SelectedItem == null) ? string.Empty : cbBaseDeDatos.SelectedItem.ToString();
            Properties.Settings.Default.UrlWebService = txbWS.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Los datos se guardaron con exito!!!");
        }
    }
}
