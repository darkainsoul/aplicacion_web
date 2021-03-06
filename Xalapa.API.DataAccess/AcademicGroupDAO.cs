using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Xalapa.API.Entities;

namespace Xalapa.API.DataAccess
{
    public class AcademicGroupDAO
    {
        public void Delete(int entityId)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "DELETE FROM proyecto_xalapa.tb_academic_groups WHERE id = " + entityId + ";";
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

        public void Insert(AcademicGroups entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "INSERT INTO proyecto_xalapa.tb_academic_groups (name) VALUES ('" + entity.name + "');";
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

        public void Update(AcademicGroups entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "UPDATE proyecto_xalapa.tb_academic_groups SET name= '" + entity.name + "' WHERE id = " + entity.id + ";";
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

        public AcademicGroups Get(int entityId)
        {
            AcademicGroups result = new AcademicGroups();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_academic_groups WHERE id = " + entityId + ";";
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

        public IEnumerable<AcademicGroups> GetList()
        {
            List<AcademicGroups> listResult = new List<AcademicGroups>();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_academic_groups;";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    AcademicGroups result = new AcademicGroups();
                    result.id = Convert.ToInt32(dataReader["id"]);
                    result.name = dataReader["name"].ToString();
                    result.date_register = Convert.ToDateTime(dataReader["date_register"]);
                    listResult.Add(result);
                }

                dataReader.Close();

                conexion.Close();
            }
            catch (Exception ex)
            {
                string error = ex.Message;
            }

            return listResult;
        }
    }
}