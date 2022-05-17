using MatchTags_SmartAccess.DataAccess.DAO;
using MatchTags_SmartAccess.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchTags_SmartAccess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TEST
            var listaFraccionemientos = FraccionamientoDAO.ObtenerFraccionamientosAll();
            if (listaFraccionemientos != null && listaFraccionemientos.Count > 0)
            {
                //Obtener el primer fraccionamiento de la lista.
                var fraccExample = listaFraccionemientos.FirstOrDefault();
                List<TagDTO> listTags = TagsDAO.ObtenerTagsByFracc(fraccExample);
            }
        }
    }
}
