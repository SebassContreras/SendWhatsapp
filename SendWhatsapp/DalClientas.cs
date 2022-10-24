using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendWhatsapp
{
    class DalClientas
    {
        public string SelectClienta(string tel)
        {
            //*List<ModelClientas> listClientas = new List<ModelClientas>();
            ConnectDb cnn = new ConnectDb();

            string datos = "";

            try
            {
                //String query
                String query = @"SELECT nombre, apellido, numCuenta, direccion, email 
                                        FROM clientas WHERE telefono='" + tel + "'";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ModelClientas clientas = new ModelClientas();
                    clientas.Nombre = (String)registros["nombre"];
                    clientas.Apellido = (String)registros["apellido"];
                    //clientas.Telefono = (String)registros["telefono"];
                    clientas.NumCuenta = (String)registros["numCuenta"];
                    clientas.Direccion = (String)registros["direccion"];
                    clientas.Email = (String)registros["email"];
                    datos = clientas.Nombre + " " + clientas.Apellido + " " + clientas.Telefono + " " +
                        clientas.NumCuenta + " " + clientas.Direccion + " " + clientas.Email;
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT Clientas: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return datos;
        }
        public List<ModelClientas> SelectTelefono()
        {
            List<ModelClientas> listTelefono = new List<ModelClientas>();

            ConnectDb cnn = new ConnectDb();

            try
            {
                //String query
                String query = @"SELECT telefono FROM clientas";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ModelClientas telefono = new ModelClientas();
                    telefono.Telefono = (String)registros["telefono"];
                    listTelefono.Add(telefono);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT Telefono: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return listTelefono;
        }
        public List<ModelClientas> SelectNumTelefono(int act, int ant)
        {
            ConnectDb cnn = new ConnectDb();
            List<ModelClientas> listTelefono = new List<ModelClientas>();

            try
            {
                //String query
                String query = @"SELECT telefono FROM clientas
                                    WHERE idClienta BETWEEN "+(ant+1)+" AND "+(act + ant)+ "";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ModelClientas telefono = new ModelClientas();
                    telefono.Telefono = (String)registros["telefono"];
                    listTelefono.Add(telefono);
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT Clientas Mensajes: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return listTelefono;
        }

    }
}
