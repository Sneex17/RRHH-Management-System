using Npgsql;

namespace ApplicationBackend.Data
{
    public class ConexionBD
    {
        private static string _server = "localhost";
        private static string _daabase = "gestionrrhh";
        private static string _port = "5432";
        private static string _user = "postgres";
        private static string _pass = "sa1417";
        private static string _cadena = $"server={_server};port={_port};user id={_user};password={_pass};database={_daabase};";

        public static string connection()
        {
            return _cadena;
        }
    }
}
