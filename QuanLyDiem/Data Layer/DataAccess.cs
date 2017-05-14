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
        private SqlConnection connection;

        public DataAccess()
        {
            dataAdapter = new SqlDataAdapter();
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);
        }

        private SqlConnection openConnection()
        {
            if (this.connection.State == ConnectionState.Broken || this.connection.State == ConnectionState.Closed)
            {
                this.connection.Open();
            }
            return this.connection;
        }

        private void closeConnection()
        {
            this.connection.Close();
        }

        public DataTable selectProc(string procName, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = this.openConnection();
                cmd.CommandText = procName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(pr);
                dataAdapter.SelectCommand = cmd;
                cmd.ExecuteNonQuery();
                dataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                
                throw;
            }
            connection.Close();
            return dt;
        }

        public bool executeCommand(String procName, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = this.openConnection();
                cmd.CommandText = procName;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddRange(pr);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
                return false;
            }
            return true;
        }

        public DataTable select(String query, SqlParameter[] pr)
        {
            SqlCommand command = new SqlCommand();
            DataTable dt = new DataTable();
            try
            {
                command.Connection = this.openConnection();
                command.CommandText = query;
                command.Parameters.AddRange(pr);
                dataAdapter.SelectCommand = command;
                command.ExecuteNonQuery();
                dataAdapter.Fill(dt);
            }
            catch (Exception)
            {
                Console.Write("Error at Select Query - {0}", query);
                throw;
            }
            connection.Close();
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
            connection.Close();
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
            connection.Close();
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
            connection.Close();
            return true;
        }
    }
}
