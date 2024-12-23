using System.Data.SqlClient;
namespace Читательский_дневник
{
    internal static class Program
    {
        static int ID;
        public class DataBase
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Читательский дневник;Integrated Security=true");

            public void openConnection()
            {
                if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
            }
            public void closeConnection()
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
            public SqlConnection GetConnection()
            {
                return sqlConnection;
            }

        }
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Autor login_Form = new Autor();
            DialogResult a = login_Form.ShowDialog();
            if (a == DialogResult.OK)
            {
                Application.Run(new Main());
            }
        }
        public static void SaveID(int id)
        {
            ID= id;
        }
        public static int TakeID()
        {
            return ID;
        }
    }
}