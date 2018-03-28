using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication2
{

    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }
        Connection conect = new Connection();
        private void LoginForm_Load(object sender, EventArgs e)//активация формы авторизации
        {
            logintext.Text = "Алексей";
            password.Text = "Блинов";
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Width - this.Width) / 2,
                (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2);
        }
        
        private void loginbutton_Click(object sender, EventArgs e)//तдействия при щелчке по кнопке "вход"
        {
           
          string answer=  conect.sql__command("select * from Пользователь" + " where Логин = '"+logintext.Text+"' and Пароль ='"+password.Text+"'",true, "Auth");
          
            if(answer=="404")
            {
                MessageBox.Show("Данные не корректны");
                return;
            }

            MessageBox.Show("Добрый день, " + answer.Split(' ')[0] + " " + answer.Split(' ')[1]);

            switch(answer.Split(' ')[2])
            {
                case "Кладовщик":
                    {
                        Storekeeper stok = new Storekeeper();
                        stok.Show();
                        this.Hide();
                        break; }
                case "Заказчик":
                    {
                        Customer cust = new Customer();
                        cust.Show();
                        this.Hide();
                        break; }
                case "Директор":
                    {
                        Director diric = new Director();
                        this.Hide();
                        diric.Show();
                        break; }
                case "Менеджер":
                    {
                        Manager manag = new Manager();
                        manag.Show();
                        this.Hide();
                        break; }

            }
        }

        private void Check__in_Click(object sender, EventArgs e)
        {
            MessageBox.Show(System.IO.Directory.GetCurrentDirectory());
        }
    }
}
