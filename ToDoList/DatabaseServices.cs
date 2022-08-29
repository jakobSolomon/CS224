using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ToDoList
{
    internal class DatabaseServices
    {
        SqlConnection co;
        public DatabaseServices()
        {
            connect();
            string Query = "insert into ToDoList values('jakob','study c#')";
            SqlCommand cmd = new SqlCommand(Query,co);
            var result = cmd.ExecuteNonQuery();
        }
        public void connect()
        {
            try
            {
                string ConnectionString = @"Data Source = .; Initial Catalog = DB; Integrated Security = True";
                co = new SqlConnection(ConnectionString);
                co.Open();
                MessageBox.Show("Connected");
            }
            catch
            {
                MessageBox.Show("Unable to Connect");
            }
        }
    }
}
