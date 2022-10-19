using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendWhatsapp
{
    class ModelMensajes
    {
        //atributes
        int nummensajes;
        public int Nummensajes { get => nummensajes; set => nummensajes = value; }
        public ModelMensajes()
        {
        }
        public ModelMensajes(int nummensajes)
        {
            this.nummensajes = nummensajes;
        }
    }
}
