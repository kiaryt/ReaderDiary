using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Читательский_дневник
{
    public partial class Autor : Form
    {
        Program.DataBase database = new Program.DataBase();SqlDataAdapter adapter = new SqlDataAdapter();
        private int ID;
        public Autor()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            PasswordTextBox.PasswordChar = '*';
            LoginTextBox.MaxLength = 50;
            PasswordTextBox.MaxLength = 50;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Login = LoginTextBox.Text;
            var Password = PasswordTextBox.Text;

            

            DataTable dt = new DataTable();
            DataColumn column;
            for (int i = 0; i < 4; i++)
            {
                column = new DataColumn();
                column.ColumnName = i.ToString();
            }
            string querrystring = $"select id_user, nickname, password from Пользователь where nickname='{Login}' and password='{Password}'";
            SqlCommand cmd = new SqlCommand(querrystring, database.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            
            if (dt.Rows.Count == 1)
            {
                {
                    this.DialogResult = DialogResult.OK;
                    ID = Convert.ToInt32(dt.Rows[0][0]);
                    Program.SaveID(ID);
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }

        public int TakeID()
        {
            return ID;
        }

    }
}
