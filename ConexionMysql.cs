using MySql.Data.MySqlClient;

public static class ConexionMysql
{
    private static string connectionString = "Server=josemiguel.desarrollodigital.site;Database=appnetm1_jose;Uid=appnetm1_jose;Pwd=3zT&u&syMo1Sqkr2;";

    public static MySqlConnection ObtenerConexion()
    {
        MySqlConnection conexion = new MySqlConnection(connectionString);
        conexion.Open();
        return conexion;
    }
}