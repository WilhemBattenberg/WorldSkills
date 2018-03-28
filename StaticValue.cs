using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{
    
    static public class StaticValue//статический класс для передачи данных между форм
    {

        static public SqlConnection con = new SqlConnection(@"Data Source=10.0.100.206;Initial Catalog=db_e_pc13;User ID=pc13;Password=pc13");


       /* con.Open(); // открыть соединение с бд
        cmd =new  SqlCommand(); //  создание объекти запроса
        cmd.Connection=con;
        cmd.CommandText=string.Format("Запрос Параметр1={0}, Параметр2={1}'{1}'",
                                        Числовой_параметр, Строковый параметр);//текст запроса
        int count = cmd.ExeuteNonQuery();//возвращает количество измененных записей для запросов типа Insert, Delete, Select
        reader=cmd.ExecuteReader();//возвращает сами записи для Select
        if(reader.Read())
            {
            reader.GetInt32(Номер-
            }
            */
        public struct user
        {
            static public int id;
            static public string name;
            static public string role;

        }
        static public Form MainForm;
    }
}
