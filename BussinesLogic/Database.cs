using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using System.Data;

namespace BussinesLogic
{
    public delegate void DatabaseErrorEvent(string Error);

    public class DBConnection
    {
        private string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+ Environment.CurrentDirectory + "\\DrinelaDB.mdb;Persist Security Info=False;";
        private OleDbConnection conn;
        DatabaseErrorEvent errorMessage;

        public DBConnection()
        {
            conn = new OleDbConnection(connString);
        }

        public DataTable Read(string cmd)
        {
            OleDbDataReader DB_Reader;
            DataTable table = new DataTable();
            try
            {
                OleDbCommand Command = new OleDbCommand(cmd, conn);
                conn.Open();
                DB_Reader = Command.ExecuteReader();
                table.Load(DB_Reader);
                conn.Close();              
            }
            catch (Exception e)
            {
                errorMessage.Invoke(e.Message);
            }

            finally
            {
                conn.Close();
            }
            return table;
        }

        public DataTable ReadSpc(OleDbCommand command)
        {
            OleDbDataReader DB_Reader;
            command.Connection = conn;
            DataTable table = new DataTable();
            try
            {
                conn.Open();
                DB_Reader = command.ExecuteReader();
                table.Load(DB_Reader);
                conn.Close();
            }
            catch (Exception e)
            {
                errorMessage.Invoke(e.Message);
            }

            finally
            {
                conn.Close();
            }
            return table;
        }

        public DataTable Read(OleDbCommand cmd)
        {
            OleDbDataReader DB_Reader;
            DataTable table = new DataTable();
            cmd.Connection = conn;
            try
            {
                conn.Open();
                DB_Reader = cmd.ExecuteReader();
                table.Load(DB_Reader);
                conn.Close();
            }
            catch (Exception e)
            {
                errorMessage.Invoke(e.Message);
            }

            finally
            {
                conn.Close();
            }
            return table;
        }

        public int UpdateInsert(string cmd)
        {
            OleDbDataReader DB_Reader;
            int result;
            try
            {
                OleDbCommand Command = new OleDbCommand(cmd, conn);
                conn.Open();
                result = Command.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception e)
            {
                errorMessage.Invoke(e.Message);
                return -1;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public bool UpdateInsert(List<OleDbCommand> cmds)
        {
            OleDbDataReader DB_Reader;
            bool result;
            conn.Open();
            OleDbTransaction transaction = conn.BeginTransaction();
            foreach (var cmd in cmds)
            {
                cmd.Connection = this.conn;
                cmd.Transaction = transaction;
            }
            try
            {               
                foreach (var cmd in cmds)
                {
                    cmd.ExecuteNonQuery();
                }
                transaction.Commit();
                result = true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                return false;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }
    }
}




