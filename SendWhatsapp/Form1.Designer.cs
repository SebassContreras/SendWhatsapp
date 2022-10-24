
namespace SendWhatsapp
{
    partial class WasapSender
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labEstado = new System.Windows.Forms.Label();
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labdatos = new System.Windows.Forms.Label();
            this.numMensajes = new System.Windows.Forms.NumericUpDown();
            this.listContactados = new System.Windows.Forms.ListView();
            this.pictureBoxMensa = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMensajes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMensa)).BeginInit();
            this.SuspendLayout();
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEstado.Location = new System.Drawing.Point(564, 9);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(224, 26);
            this.labEstado.TabIndex = 1;
            this.labEstado.Text = "Numeros Contactados";
            // 
            // textMensaje
            // 
            this.textMensaje.Location = new System.Drawing.Point(12, 55);
            this.textMensaje.Multiline = true;
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(292, 276);
            this.textMensaje.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(227, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 58);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar Mensajes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labdatos
            // 
            this.labdatos.AutoSize = true;
            this.labdatos.Location = new System.Drawing.Point(35, 365);
            this.labdatos.Name = "labdatos";
            this.labdatos.Size = new System.Drawing.Size(162, 13);
            this.labdatos.TabIndex = 4;
            this.labdatos.Text = "Cuantos mensajes quieres enviar";
            // 
            // numMensajes
            // 
            this.numMensajes.Location = new System.Drawing.Point(52, 397);
            this.numMensajes.Name = "numMensajes";
            this.numMensajes.Size = new System.Drawing.Size(120, 20);
            this.numMensajes.TabIndex = 6;
            this.numMensajes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listContactados
            // 
            this.listContactados.HideSelection = false;
            this.listContactados.Location = new System.Drawing.Point(567, 40);
            this.listContactados.Name = "listContactados";
            this.listContactados.Size = new System.Drawing.Size(221, 327);
            this.listContactados.TabIndex = 8;
            this.listContactados.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBoxMensa
            // 
            this.pictureBoxMensa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBoxMensa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMensa.Location = new System.Drawing.Point(333, 96);
            this.pictureBoxMensa.Name = "pictureBoxMensa";
            this.pictureBoxMensa.Size = new System.Drawing.Size(210, 210);
            this.pictureBoxMensa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMensa.TabIndex = 9;
            this.pictureBoxMensa.TabStop = false;
            this.pictureBoxMensa.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBoxMensa_DragDrop);
            this.pictureBoxMensa.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBoxMensa_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mensaje";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(402, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Imagen";
            // 
            // WasapSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxMensa);
            this.Controls.Add(this.listContactados);
            this.Controls.Add(this.numMensajes);
            this.Controls.Add(this.labdatos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMensaje);
            this.Controls.Add(this.labEstado);
            this.Name = "WasapSender";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WasapSender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMensajes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMensa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.TextBox textMensaje;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labdatos;
        private System.Windows.Forms.NumericUpDown numMensajes;
        private System.Windows.Forms.ListView listContactados;
        private System.Windows.Forms.PictureBox pictureBoxMensa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

