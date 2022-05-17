using CrudWindowsForm.Dato;
using CrudWindowsForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudWindowsForm
{
    public partial class Form1 : Form
    {
        private DataTable tabla;
        AlmunoAdmin admin = new AlmunoAdmin();
        private void inicializar() {
            tabla = new DataTable();
            tabla.Columns.Add("ID");
            tabla.Columns.Add("Matricula");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("ApellidoPaterno");
            tabla.Columns.Add("ApellidoMaterno");
            tabla.Columns.Add("FechaNacimiento");
            tabla.Columns.Add("CURP");
            dgalumnos.DataSource = tabla;
        }
        public Form1()
        {
            InitializeComponent();
            Consultar();
          
        }

        private void Consultar() {
            inicializar();
            List<alumnos> lista = admin.Consultar();
            foreach (var item in lista)
            {
                DataRow row = tabla.NewRow();
                row["ID"] = item.Id;
                row["Matricula"] = item.Matricula;
                row["Nombre"] = item.Nombre;
                row["ApellidoPaterno"] = item.ApellidoPaterno;
                row["ApellidoMaterno"] = item.ApellidoMaterno;
                row["FechaNacimiento"] = item.FechaNacimiento;
                row["Curp"] = item.Curp;
                tabla.Rows.Add(row);
            }
        }

        private void Guardar(){
            alumnos modelo = new alumnos()
            {
                Matricula = txtmatricula.Text,
                Nombre = txtnombre.Text,
                ApellidoPaterno = txtapellidopaterno.Text,
                ApellidoMaterno = txtapellidomaterno.Text,
                FechaNacimiento = txtfechanacimiento.Text,
                Curp = txtcurp.Text
            };
            admin.Guardar(modelo);
        }


        private void Limpiar() {
            txtid.Text = "";
            txtmatricula.Text = "";
            txtnombre.Text = "";
            txtapellidopaterno.Text = "";
            txtapellidopaterno.Text = "";
            txtfechanacimiento.Text = "";
            txtcurp.Text = "";
        }
        private void dgalumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Guardar();
            Consultar();
            Limpiar();
        }
    }
}
