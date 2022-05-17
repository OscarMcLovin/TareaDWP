using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentista
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        // private extern static void RelaseCapture();
        // [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        
        
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
        }

        private void BarraTtulo_Paint(object sender, PaintEventArgs e)
        {
            
            //SendMessage(this.Handle,0x112,0xf012,0);
        }
        private void AbrirFormInPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Directorios());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Agenda());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Pacientes());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Pagos());
        }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Form4());
        }

       
    }
}
