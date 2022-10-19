using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendWhatsapp
{
    public class ModelClientas
    {
        //atributes
        int idClienta;
        string nombre;
        string apellido;
        string telefono;
        string numCuenta;
        string direccion;
        string email;

        //Get and Set
        public int IdClienta { get => idClienta; set => idClienta = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string NumCuenta { get => numCuenta; set => numCuenta = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }

        //Contructors

        public ModelClientas() 
        { 
        }
        public ModelClientas(int idClienta, string nombre, string apellido, string telefono, string numCuenta, string direccion, string email)
        {
            this.idClienta = idClienta;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.numCuenta = numCuenta;
            this.direccion = direccion;
            this.email = email;
        }
        public ModelClientas(string nombre, string apellido, string telefono, string numCuenta, string direccion, string email)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.numCuenta = numCuenta;
            this.direccion = direccion;
            this.email = email;
        }
        public ModelClientas(string telefono)
        {
            this.telefono = telefono;
        }
    }
}
