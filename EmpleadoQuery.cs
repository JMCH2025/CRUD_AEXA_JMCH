using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

public static class EmpleadoQuey
{
    public static void Crear(Empleado emp)
    {
        using (var con = Conexion.ObtenerConexion())
        {
            string query = "INSERT INTO empleado (nombre, descripcion) VALUES (@nombre, @descripcion)";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", emp.Descripcion);
            cmd.ExecuteNonQuery();
        }
    }

    public static List<Empleado> ObtenerTodos(bool incluirInactivos = false)
    {
        List<Empleado> lista = new List<Empleado>();
        using (var con = Conexion.ObtenerConexion())
        {
            string query = incluirInactivos ? "SELECT * FROM empleado" : "SELECT * FROM empleado WHERE activo = 1";
            MySqlCommand cmd = new MySqlCommand(query, con);
            using (var dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    lista.Add(new Empleado
                    {
                        Id = Convert.ToInt32(dr["id"]),
                        Nombre = dr["nombre"].ToString(),
                        Descripcion = dr["descripcion"].ToString(),
                        Activo = Convert.ToBoolean(dr["activo"])
                    });
                }
            }
        }
        return lista;
    }

    public static void Actualizar(Empleado emp)
    {
        using (var con = Conexion.ObtenerConexion())
        {
            string query = "UPDATE empleado SET nombre = @nombre, descripcion = @descripcion WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@nombre", emp.Nombre);
            cmd.Parameters.AddWithValue("@descripcion", emp.Descripcion);
            cmd.Parameters.AddWithValue("@id", emp.Id);
            cmd.ExecuteNonQuery();
        }
    }

    public static void EliminarLogico(int id)
    {
        using (var con = Conexion.ObtenerConexion())
        {
            string query = "UPDATE empleado SET activo = 0 WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }

    public static void EliminarFisico(int id)
    {
        using (var con = Conexion.ObtenerConexion())
        {
            string query = "DELETE FROM empleado WHERE id = @id";
            MySqlCommand cmd = new MySqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
        }
    }
}
