using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using Xalapa.API.Entities;

namespace Xalapa.API.DataAccess
{
    public class ResearchCenterDAO
    {
        public void Delete(int entityId)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "DELETE FROM proyecto_xalapa.tb_research_centers WHERE id = " + entityId + ";";
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

        public void Insert(ResearchCenters entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);
                string query = "INSERT INTO proyecto_xalapa.tb_research_centers (name) VALUES ('" + entity.name + "');";
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

        public void Update(ResearchCenters entity)
        {
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "UPDATE proyecto_xalapa.tb_research_centers SET name= '" + entity.name + "' WHERE id = " + entity.id + ";";
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

        public ResearchCenters Get(int entityId)
        {
            ResearchCenters result = new ResearchCenters();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_research_centers WHERE id = " + entityId + ";";
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

        public IEnumerable<ResearchCenters> GetList()
        {
            List<ResearchCenters> listResult = new List<ResearchCenters>();
            try
            {
                var cadenaConexion = new Connection().CadenaConexion();
                var conexion = new MySqlConnection(cadenaConexion);

                string query = "SELECT id, name, date_register FROM proyecto_xalapa.tb_research_centers;";
                MySqlCommand MyCommand2 = new MySqlCommand(query, conexion);
                conexion.Open();
                MySqlDataReader dataReader = MyCommand2.ExecuteReader();

                while (dataReader.Read())
                {
                    ResearchCenters result = new ResearchCenters();
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