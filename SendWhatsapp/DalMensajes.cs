using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendWhatsapp
{
    class DalMensajes
    {
        public int NumMensajes()
        {
            ConnectDb cnn = new ConnectDb();

            int NumMensaje = 0;

            try
            {
                //String query
                String query = @"SELECT numMensajes
                                        FROM mensajes";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                SqlDataReader registros = comand.ExecuteReader();

                //Obtener lo datos
                while (registros.Read())
                {
                    ModelMensajes mensjaes = new ModelMensajes();
                    mensjaes.Nummensajes = (int)registros["numMensajes"];
                    NumMensaje = NumMensaje + mensjaes.Nummensajes;
                }
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT Mensajes: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
            return NumMensaje;
        }
        public void UpNumMensajes(int msj)
        {
            ConnectDb cnn = new ConnectDb();

            try
            {
                //String query
                String query = @"UPDATE mensajes
                                  SET numMensajes = "+msj+"";

                //Conexion creada
                SqlCommand comand = new SqlCommand(query, cnn.Connection);

                //Ejecutar query
                comand.ExecuteNonQuery();

                //Obtener lo datos
                Debug.WriteLine("Se han actulizado los datos");
            }
            catch (Exception exeption)
            {
                Debug.WriteLine("ERROR SELECT Mensajes: " + exeption.Message);
            }
            finally
            {
                cnn.CerrarConexion();
            }
        }
    }
}
