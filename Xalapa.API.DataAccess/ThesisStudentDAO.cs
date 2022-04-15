using MySql.Data.MySqlClient;
using System;
using Xalapa.API.Entities;

namespace Xalapa.API.DataAccess
{
    public class ThesisStudentDAO
    {
        public void Delete(int entityId)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "DELETE FROM proyecto_xalapa.tb_thesis_students WHERE id = " + entityId + ";";
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

        public void Insert(ThesisStudents entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "INSERT INTO proyecto_xalapa.tb_thesis_students (name) VALUES ('" + entity.name + ");";
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

        public void Update(ThesisStudents entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "UPDATE proyecto_xalapa.tb_thesis_students SET name= '" + entity.name + " WHERE id = " + entity.id + ";";
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

        public ThesisStudents Get(int entityId)
        {
            ThesisStudents result = new ThesisStudents();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_thesis_students WHERE id = " + entityId + ";";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    result.id = Convert.ToInt32(dataReader["id"]);
                    result.name = dataReader["name"].ToString();
                    result.date_register = Convert.ToDateTime(dataReader["date_register"]);
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

        public ThesisStudents GetList()
        {
            ThesisStudents result = new ThesisStudents();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_thesis_students;";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    result.id = Convert.ToInt32(dataReader["id"]);
                    result.name = dataReader["name"].ToString();
                    result.date_register = Convert.ToDateTime(dataReader["date_register"]);
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