
namespace Dentista
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.btn_salir = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nmb_contraseña = new System.Windows.Forms.Label();
            this.nmb_usuario = new System.Windows.Forms.Label();
            this.btn_inicioSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(164, 230);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 11;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(87, 134);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(224, 20);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(224, 20);
            this.textBox1.TabIndex = 9;
            // 
            // nmb_contraseña
            // 
            this.nmb_contraseña.AutoSize = true;
            this.nmb_contraseña.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmb_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb_contraseña.Location = new System.Drawing.Point(140, 102);
            this.nmb_contraseña.Name = "nmb_contraseña";
            this.nmb_contraseña.Size = new System.Drawing.Size(87, 16);
            this.nmb_contraseña.TabIndex = 8;
            this.nmb_contraseña.Text = "Contraseña";
            // 
            // nmb_usuario
            // 
            this.nmb_usuario.AutoSize = true;
            this.nmb_usuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.nmb_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmb_usuario.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nmb_usuario.Location = new System.Drawing.Point(161, 55);
            this.nmb_usuario.Name = "nmb_usuario";
            this.nmb_usuario.Size = new System.Drawing.Size(62, 16);
            this.nmb_usuario.TabIndex = 7;
            this.nmb_usuario.Text = "Usuario";
            // 
            // btn_inicioSesion
            // 
            this.btn_inicioSesion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inicioSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inicioSesion.Location = new System.Drawing.Point(87, 172);
            this.btn_inicioSesion.Name = "btn_inicioSesion";
            this.btn_inicioSesion.Size = new System.Drawing.Size(223, 33);
            this.btn_inicioSesion.TabIndex = 6;
            this.btn_inicioSesion.Text = "Inicio Sesion";
            this.btn_inicioSesion.UseVisualStyleBackColor = false;
            this.btn_inicioSesion.Click += new System.EventHandler(this.btn_inicioSesion_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 375);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nmb_contraseña);
            this.Controls.Add(this.nmb_usuario);
            this.Controls.Add(this.btn_inicioSesion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label nmb_contraseña;
        private System.Windows.Forms.Label nmb_usuario;
        private System.Windows.Forms.Button btn_inicioSesion;
    }
}