using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Red_Game_Server
{
    class SQL
    {
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader read;
        string count = "";
        string str;
        public void Connect(string ConnetionString)//連接資料庫
        {
            cnn = new SqlConnection(ConnetionString);
            cnn.Open();
        }
        public void Command(string sql)//sql-command
        {
            command = new SqlCommand(sql, cnn);
            command.ExecuteNonQuery();//執行SQL
        }
        public string Read(string s)//讀取資料
        {
            read = command.ExecuteReader();
            while (read.Read())
            {
                str = read[s].ToString();
            }            
            return str; //回傳讀取到的資料
        }
        public string Count()//讀取有幾筆資料
        {
            count = Convert.ToString(command.ExecuteScalar());
            return count;//回傳讀取到的筆數
        }
        public void  Close()
        {
            cnn.Close();
        }
    }
}
