using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Data_Layer
{
    class DataAccess
    {
        private SqlDataAdapter dataAdapter;
         SqlConnection con = new System.Data.SqlClient.SqlConnection(@"Data Source=(LocalDB)\v11.0; AttachDbFilename=|DataDirectory|\db.mdf; Integrated Security=True; Connect Timeout=30;");
           
           

        public DataAccess()
        {
            dataAdapter = new SqlDataAdapter();
         
           
        }

        private SqlConnection openConnection()
        {
       
            if (con.State == ConnectionState.Broken || con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public DataTable select(String query)
        {
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                command.Connection = this.openConnection();
                command.CommandText = query;
               
                dataAdapter.SelectCommand = command;
                command.ExecuteNonQuery();
                dataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                Console.Write("Error at Select Query - {0}", query);
                throw;
            }
            con.Close();
            return dt;
        }

        public bool insert(String query, SqlParameter[] pr)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = this.openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(pr);
                dataAdapter.InsertCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.Write("Error at Insert Query - {0}", query);
                return false;
                throw;
            }
            con.Close();
            return true;
        }

        public bool update(String query, SqlParameter[] pr)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = this.openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(pr);
                dataAdapter.UpdateCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.Write("Error at Select Query - {0}", query);
                return false;
                throw;
            }
            con.Close();
            return true;
        }

        public bool delete(String query, SqlParameter[] pr)
        {
            SqlCommand command = new SqlCommand();
            try
            {
                command.Connection = this.openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(pr);
                dataAdapter.DeleteCommand = command;
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.Write("Error at Select Query - {0}", query);
                return false;
                throw;
            }
            con.Close();
            return true;
        }
    }
}
