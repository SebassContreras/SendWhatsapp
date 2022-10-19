
namespace SendWhatsapp
{
    partial class Form1
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
            this.butEnviar = new System.Windows.Forms.Button();
            this.labEstado = new System.Windows.Forms.Label();
            this.textMensaje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butEnviar
            // 
            this.butEnviar.Location = new System.Drawing.Point(64, 210);
            this.butEnviar.Name = "butEnviar";
            this.butEnviar.Size = new System.Drawing.Size(109, 31);
            this.butEnviar.TabIndex = 0;
            this.butEnviar.Text = "Enviar Mensajes";
            this.butEnviar.UseVisualStyleBackColor = true;
            this.butEnviar.Click += new System.EventHandler(this.butEnviar_Click);
            // 
            // labEstado
            // 
            this.labEstado.AutoSize = true;
            this.labEstado.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEstado.Location = new System.Drawing.Point(515, 28);
            this.labEstado.Name = "labEstado";
            this.labEstado.Size = new System.Drawing.Size(250, 39);
            this.labEstado.TabIndex = 1;
            this.labEstado.Text = "Estado de Envio";
            // 
            // textMensaje
            // 
            this.textMensaje.Location = new System.Drawing.Point(53, 107);
            this.textMensaje.Name = "textMensaje";
            this.textMensaje.Size = new System.Drawing.Size(136, 20);
            this.textMensaje.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enviar Mensajes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textMensaje);
            this.Controls.Add(this.labEstado);
            this.Controls.Add(this.butEnviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butEnviar;
        private System.Windows.Forms.Label labEstado;
        private System.Windows.Forms.TextBox textMensaje;
        private System.Windows.Forms.Button button1;
    }
}

