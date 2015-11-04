using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace Transferencias_de_Etiquetas.Modelos
{
    public class MysqlMiniDal
    {
        MySqlConnection MyConn = new MySqlConnection();
        MySqlCommand MyComm = new MySqlCommand();
        MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
        MySqlConnectionStringBuilder myCSB = new MySqlConnectionStringBuilder();

        public MysqlMiniDal(string Servidor, string Usuario, string Contraseña, string Puerto)
        {
            myCSB.Server = Servidor;
            myCSB.UserID = Usuario;
            myCSB.Password = Contraseña;
            myCSB.Port = Convert.ToUInt32(Puerto);

            MyConn.ConnectionString = myCSB.ConnectionString;
        }
        public MysqlMiniDal(string Servidor, string Usuario, string Contraseña, string Puerto, string BaseDeDatos)
        {
            myCSB.Server = Servidor;
            myCSB.UserID = Usuario;
            myCSB.Password = Contraseña;
            myCSB.Port = Convert.ToUInt32(Puerto);
            myCSB.Database = BaseDeDatos;

            MyConn.ConnectionString = myCSB.ConnectionString;
        }

        public List<string> ObtenerBasesDeDatos()
        {
            MyConn.Open();

            MyComm.Connection = MyConn;
            MyComm.CommandText = "SHOW DATABASES";
            MyAdapter.SelectCommand = MyComm;

            DataTable dtResultado = new DataTable();
            MyAdapter.Fill(dtResultado);

            List<string> lstDatabases = new List<string>();
            foreach (DataRow fila in dtResultado.Rows)
            {
                lstDatabases.Add(fila[0].ToString());
            }

            MyConn.Close();

            return lstDatabases;
        }

        public List<Articulo> ObtenerBodegasArticulos()
        {
            MyConn.Open();

            MyComm.Connection = MyConn;
            MyComm.CommandText = "SELECT clave, id_bodega FROM articulos";
            MyAdapter.SelectCommand = MyComm;

            DataTable dtResultado = new DataTable();
            MyAdapter.Fill(dtResultado);

            Articulo arti;
            List<Articulo> lstArticulos = new List<Articulo>();
            foreach (DataRow fila in dtResultado.Rows)
            {
                arti = new Articulo(Convert.ToString(fila["clave"]), Convert.ToInt32(fila["id_bodega"]));
                lstArticulos.Add(arti);
            }

            MyConn.Close();

            return lstArticulos;
        }
    }
}
