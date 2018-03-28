using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    class Connection
    {
        private string sql__bd= @"Data Source = 10.0.100.206; Initial Catalog = db_e_pc13; User ID = pc13; Password=pc13";

        public string sql__command(string command, bool answer,string answer__text)
        {
            SqlConnection sql;

            using (sql = new SqlConnection(sql__bd))
            {
                sql.Open();
                SqlCommand cmd = new SqlCommand(command, sql);

                if (answer)
                {
                    string retur = "";
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if(answer__text=="Auth")
                        retur = reader["Логин"].ToString()+" "+reader["Пароль"].ToString()+" "+reader["Роль"].ToString();
                    }
                    if (retur == "")
                        retur = "404";
                    return retur;
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    return "";
                }
            }

               
        }
    }
}
