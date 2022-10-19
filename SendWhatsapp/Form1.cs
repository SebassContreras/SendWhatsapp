using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendWhatsapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butEnviar_Click(object sender, EventArgs e)
        {
            DalClientas tel = new DalClientas();
            DalMensajes msj = new DalMensajes();
            List<ModelClientas> telefono = new List<ModelClientas>();
            telefono = tel.SelectNumTelefono(msj.NumMensajes());
            for (int i = 0; i < telefono.Count; i++)
            {
                System.Diagnostics.Process.Start("whatsapp://send?phone=34" + telefono[i].Telefono.ToString());
                Thread.Sleep(5000);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("whatsapp://send?phone=34600919794?text=I'm%20interested%20in%20telecomHall%20Forum");
        }
    }
}
