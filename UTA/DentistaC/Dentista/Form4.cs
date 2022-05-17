using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Dentista
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sMARTACCESSDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.sMARTACCESSDataSet.Pacientes);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.conexion);
            String query = "select * from Pacientes where " + comboBox1.Text + " like '%" + textBox1.Text + "%'";
            SqlDataAdapter ada = new SqlDataAdapter(query, con);

            con.Open();

            DataSet data = new DataSet();

            ada.Fill(data, "Pacientes");
            //ada.Fill(data, "Pacientes");

            dataGridView1.DataSource = data;
            dataGridView1.DataMember = "Pacientes";
        }

           }
        }
    

