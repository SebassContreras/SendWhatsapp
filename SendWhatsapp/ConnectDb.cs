using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SendWhatsapp
{
    public class ConnectDb
    {
        //Attributes
        SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        SqlConnection connection;

        //GET and SET
        public SqlConnection Connection { get => connection; set => connection = value; }

        //Constructor
        public ConnectDb()
        {
            //Parameters BD
            builder.DataSource = "DESKTOP-3UAKAKJ\\WHATSAPP";
            builder.InitialCatalog = "ClientasAvon";
            builder.UserID = "wasa";
            builder.Password = "322658";

            try
            {
                //Create Connection
                this.Connection = new SqlConnection(builder.ConnectionString);
                this.Connection.Open();
                Debug.WriteLine("Conexion creada");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR: " + exeption.Message);
            }
        }

        public void CerrarConexion()
        {
            try
            {
                //Close Sesion
                this.Connection.Close();
                Debug.WriteLine("Conexion cerrada");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine(exeption.Message);
            }
        }
    }
}
