using MatchTags_SmartAccess.DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchTags_SmartAccess.DataAccess.DAO
{
    public static class TagsDAO
    {
        /// <summary>
        /// Obtener todos los tags de un fraccionamiento dado
        /// </summary>
        /// <param name="fracc"></param>
        /// <returns></returns>
        public static List<TagDTO> ObtenerTagsByFracc(FraccionamientoDTO fracc)
        {
            var listTags = new List<TagDTO>();
            try
            {
                string connectionString = "Server={0},{1};Database={2};User Id={3};Password={4};";
                connectionString = string.Format(connectionString, fracc.IP, fracc.PuertoSql, fracc.ServerSql, fracc.UserSql, fracc.PswSql);
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("AccFracc_GetAllTags", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        //cmd.Parameters.Add("@idFraccionamiento", SqlDbType.Int).Value = idFraccionamiento;
                        cnn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            TagDTO tag = new TagDTO();
                            tag.IdTag = reader[0] != null ? Convert.ToInt32(reader[0]) : 0;
                            tag.RFID = reader[1] != null ? reader[1].ToString() : string.Empty;
                            tag.Identity = reader[2] != null ? reader[2].ToString() : string.Empty;
                            tag.FechaCreacion = reader[3] != null ? DateTime.Parse(reader[3].ToString()) : DateTime.MinValue;
                            tag.Activo = reader[4] != null ? Boolean.Parse(reader[4].ToString()) : false;
                            listTags.Add(tag);
                        }
                        return listTags;
                    }
                }
            }
            catch (Exception ex)
            {
                //TODO Agregar ErrorLog
                return listTags;
            }
        }
    }
}
