using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace CRUD_AEXA_JMCH
{
    public static class EmpleadoQuerys
    {
        public static void Crear(empleado emp)
        {
            using (var con = ConexionMysql.ObtenerConexion())
            {
                string query = "INSERT INTO empleado (nombre,descripcion) VALUES (@nombre, @descripcion)";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", emp.nombre);
                cmd.Parameters.AddWithValue("@descripcion", emp.descripcion);
                cmd.ExecuteNonQuery();
            }
        }

        public static List<empleado> ObtenerTodos(bool incluirInactivos = false)
        {
            List<empleado> lista = new List<empleado>();

            using (var con = ConexionMysql.ObtenerConexion())
            {
                string query = incluirInactivos ? "SELECT * FROM empleado WHERE activo = 0" : "SELECT * FROM empleado WHERE activo = 1";

                MySqlCommand cmd = new MySqlCommand(query, con);
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        lista.Add(new empleado
                        {
                            id = Convert.ToInt32(dr["id"]),
                            nombre = dr["nombre"].ToString(),
                            descripcion = dr["descripcion"].ToString(),
                            activo = Convert.ToInt32(dr["activo"])
                        });
                    }
                }
            }

            return lista;
        }

        public static void Actualizar(empleado emp)
        {
            using (var con = ConexionMysql.ObtenerConexion())
            {
                string query = "UPDATE empleado SET nombre = @nombre, descripcion = @descripcion, activo = @activo WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", emp.nombre);
                cmd.Parameters.AddWithValue("@descripcion", emp.descripcion);
                cmd.Parameters.AddWithValue("@activo", emp.activo);
                cmd.Parameters.AddWithValue("@id", emp.id);
                cmd.ExecuteNonQuery();
            }
        }


        public static void EliminarLogico(int id)
        {
            using (var con = ConexionMysql.ObtenerConexion())
            {
                string query = "UPDATE empleado SET activo = 0 WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public static void EliminarFisico(int id)
        {
            using (var con = ConexionMysql.ObtenerConexion())
            {
                string query = "DELETE FROM empleado WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
