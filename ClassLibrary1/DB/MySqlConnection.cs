using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace UtilityLib.DB
{
    internal class MySqlConn
    {

        public MySqlConnectionStringBuilder ConnectionString;
        public MySqlConnection Conn;
        public bool ConnectionCheck = false;
        public MySqlBulkLoader BulkLoader;
        /// <summary>
        /// MySqlDBConnection
        /// </summary>
        /// <param name="Connection">Connection String</param>
        public bool DBConnection(string Connection)   
        {
            try
            {
                if (Conn == null)
                {
                    Conn = new MySqlConnection(Connection);
                }
                if(Conn.State == System.Data.ConnectionState.Closed)
                {
                    Conn.Open();
                    ConnectionCheck = true;
                }

                ConnectionString.AllowBatch = true;
            } 
            catch(Exception ee)
            {
                MessageBox.Show("MySQL ConnectionError "+ee.Message);
                ConnectionCheck = false;
               
            }
            return ConnectionCheck;
        }

        public void BatchQuery(List<string>SqlList)
        {
            SqlList.Clear();
            if(Conn.State != System.Data.ConnectionState.Closed)
            {

            }
            else
            {
                Console.WriteLine("DB 연결 상태를 확인하세요");
            }
        }
    }
}
