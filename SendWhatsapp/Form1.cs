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
    public partial class WasapSender : Form
    {
        public WasapSender()
        {
            InitializeComponent();
        }
        private void WasapSender_Load(object sender, EventArgs e)
        {
            pictureBoxMensa.AllowDrop = true;
        }
        private void pictureBoxMensa_DragDrop(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if (data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                    pictureBoxMensa.Image = Image.FromFile(fileNames[0]);
            }


        }
        private void pictureBoxMensa_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int numMsj = (int)numMensajes.Value;

            DalClientas tel = new DalClientas();
            DalMensajes msj = new DalMensajes();
            List<ModelClientas> telefono = new List<ModelClientas>();

            telefono = tel.SelectNumTelefono(numMsj, msj.NumMensajes());
         
            for (int i = 0; i < telefono.Count; i++)
            {
                System.Diagnostics.Process.Start("whatsapp://send?phone=34"+ telefono[i].Telefono.ToString());
                Thread.Sleep(2000);
                listContactados.Items.Add(telefono[i].Telefono.ToString());
                Clipboard.SetImage(pictureBoxMensa.Image);
                Thread.Sleep(2000);
                SendKeys.Send("^(v)");
                Thread.Sleep(2000);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(2000);
                Clipboard.SetText(textMensaje.Text);
                Thread.Sleep(2000);
                SendKeys.Send("^(v)");
                Thread.Sleep(2000);
                SendKeys.Send("{ENTER}");
                Thread.Sleep(2000);
            }
            msj.UpNumMensajes(msj.NumMensajes() + numMsj);

        }

        
    }
}
