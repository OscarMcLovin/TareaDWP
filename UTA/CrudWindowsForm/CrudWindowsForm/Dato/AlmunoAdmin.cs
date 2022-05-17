using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudWindowsForm.Modelo;

namespace CrudWindowsForm.Dato
{
    public class AlmunoAdmin
    {
        /// <summary>
        /// Consulta todos los alumnos
        /// </summary>
        /// <returns>Datos de los alumnos</returns>
        public List<alumnos> Consultar () {
            using (CrudWFEntities contexto = new CrudWFEntities()) {
                return contexto.alumnos.AsNoTracking().ToList();
            }
        }
        /// <summary>
        /// Guarda los datos de los alumnos
        /// </summary>
        /// <param name="modelo"></param>
        public void Guardar(alumnos modelo) {
            using (CrudWFEntities contexto = new CrudWFEntities())
            {
                contexto.alumnos.Add(modelo);
                contexto.SaveChanges();
            }
        }
    }
}
