using MySql.Data.MySqlClient;
using System;
using Xalapa.API.Entities;

namespace Xalapa.API.DataAccess
{
    public class ResearcherDAO
    {
        public void Delete(int entityId)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "DELETE FROM proyecto_xalapa.tb_researchers WHERE id = " + entityId + ";";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                int rowsInserted = MyCommand2.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public void Insert(Researchers entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "INSERT INTO proyecto_xalapa.tb_researchers (name) VALUES ('" + entity.name + "', '" + entity.academic_grade + "', '" + entity.speciality + "', '" + entity.knowledge_areas + "', " + entity.years_of_experience + "); ";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                int rowsInserted = MyCommand2.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public void Update(Researchers entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "UPDATE proyecto_xalapa.tb_researchers SET name='" + entity.name + "', academic_grade='" + entity.academic_grade + "', speciality='" + entity.speciality + "', knowledge_areas='" + entity.knowledge_areas + "', years_of_experience=" + entity.years_of_experience + " WHERE id = " + entity.id + ";";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                int rowsInserted = MyCommand2.ExecuteNonQuery();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }
        }

        public Researchers Get(int entityId)
        {
            Researchers result = new Researchers();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register, academic_grade, speciality, knowledge_areas, years_of_experience FROM proyecto_xalapa.tb_researchers;";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    result.id = Convert.ToInt32(dataReader["id"]);
                    result.name = dataReader["name"].ToString();
                    result.date_register = Convert.ToDateTime(dataReader["date_register"]);
                    result.academic_grade = dataReader["academic_grade"].ToString();
                    result.speciality = dataReader["speciality"].ToString();
                    result.knowledge_areas = dataReader["knowledge_areas"].ToString();
                    result.years_of_experience = Convert.ToInt32(dataReader["years_of_experience"]);
                }

                dataReader.Close();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return result;
        }

        public Researchers GetList()
        {
            Researchers result = new Researchers();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register, academic_grade, speciality, knowledge_areas, years_of_experience FROM proyecto_xalapa.tb_researchers;";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    result.id = Convert.ToInt32(dataReader["id"]);
                    result.name = dataReader["name"].ToString();
                    result.date_register = Convert.ToDateTime(dataReader["date_register"]);
                    result.academic_grade = dataReader["academic_grade"].ToString();
                    result.speciality = dataReader["speciality"].ToString();
                    result.knowledge_areas = dataReader["knowledge_areas"].ToString();
                    result.years_of_experience = Convert.ToInt32(dataReader["years_of_experience"]);
                }

                dataReader.Close();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return result;
        }
    }
}