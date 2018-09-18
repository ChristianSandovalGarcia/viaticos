using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace viaticos.Data
{
    public class departamentosData
    {
        string connectionString = "Server=138.68.6.229;User Id=root;Password=default22;Database=viaticos";
        //lista
        public IEnumerable<departamentosModel> getDepartamentos()
        {
            List<departamentosModel> listaDepartamentos = new List<departamentosModel>();
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("spGetDepartamentos", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
                cmd.Parameters.Add(new MySqlParameter("@idcliente", 1));
  
                con.Open();  
                MySqlDataReader rdr = cmd.ExecuteReader();  
  
                while (rdr.Read())  
                { 
                    departamentosModel model = new departamentosModel();
                    model.ID = Convert.ToInt32(rdr["id"]);
                    model.nombre = rdr["nombre"].ToString();
                    model.activo = Convert.ToBoolean(rdr["activo"]);
                    listaDepartamentos.Add(model);
                }
                con.Close();
            }
            return listaDepartamentos;
        }

        public int addDepartamento(string departamento)
        {
            int values = 0;
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand("spAddDepartamento", con);  
                cmd.CommandType = CommandType.StoredProcedure;  
                cmd.Parameters.Add(new MySqlParameter("@idcliente", 1));
                cmd.Parameters.Add(new MySqlParameter("@nombre", departamento));
  
                con.Open(); 
                values = cmd.ExecuteNonQuery();
                con.Close();
            }
            return values;
        }
    }
}