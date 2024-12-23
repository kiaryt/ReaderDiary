using Microsoft.VisualBasic.Logging;
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

    public partial class Main : Form
    {
        Program.DataBase database = new Program.DataBase(); SqlDataAdapter adapter = new SqlDataAdapter(); DataTable dt = new DataTable();
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            button5.Hide();
            string querrystring = $"select * from Пользователь where id_user='{Program.TakeID()}'";
            SqlCommand cmd = new SqlCommand(querrystring, database.GetConnection());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            int ID = Program.TakeID();
            label1.Text = dt.Rows[0][2].ToString();

            string querrystring1 = $"select id_book from СКП where id_user='{Program.TakeID()}' and status='Читаю сейчас'";
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand(querrystring1, database.GetConnection());
            adapter.SelectCommand = cmd1;
            adapter.Fill(dt1);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string querrystring2 = $"select Title, Autor from Книги where id_book='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd2 = new SqlCommand(querrystring2, database.GetConnection());
            adapter.SelectCommand = cmd2;
            adapter.Fill(dt3);

            dataGridView1.DataSource = dt3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Show();
            button3.Show();
            button4.Show();
            button6.Show();
            button5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Hide();
            button3.Hide();
            button4.Hide();
            button6.Hide();
            button5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Show();
            label4.Hide();
            label5.Hide();
            label2.Hide();
            string querrystring1 = $"select id_book from СКП where id_user='{Program.TakeID()}' and status='Прочитано'";
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand(querrystring1, database.GetConnection());
            adapter.SelectCommand = cmd1;
            adapter.Fill(dt1);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string querrystring2 = $"select Title, Autor from Книги where id_book='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd2 = new SqlCommand(querrystring2, database.GetConnection());
            adapter.SelectCommand = cmd2;
            adapter.Fill(dt3);

            dataGridView1.DataSource = dt3;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label3.Hide();
            label4.Show();
            label5.Hide();
            label2.Hide();
            string querrystring1 = $"select id_book from СКП where id_user='{Program.TakeID()}' and status='Хочу прочитать'";
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand(querrystring1, database.GetConnection());
            adapter.SelectCommand = cmd1;
            adapter.Fill(dt1);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string querrystring2 = $"select Title, Autor from Книги where id_book='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd2 = new SqlCommand(querrystring2, database.GetConnection());
            adapter.SelectCommand = cmd2;
            adapter.Fill(dt3);

            dataGridView1.DataSource = dt3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Show();
            label4.Hide();
            label3.Hide();
            label2.Hide();
            string querrystring1 = $"select id_book from СКП where id_user='{Program.TakeID()}'";
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand(querrystring1, database.GetConnection());
            adapter.SelectCommand = cmd1;
            adapter.Fill(dt1);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string querrystring2 = $"select id_genre from Книги where id_book='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd2 = new SqlCommand(querrystring2, database.GetConnection());
            adapter.SelectCommand = cmd2;
            adapter.Fill(dt2);

            string querrystring3 = $"select Title, Autor from Книги where id_genre='{Convert.ToInt32(dt2.Rows[0][0])}' and id_book!='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd3 = new SqlCommand(querrystring3, database.GetConnection());
            adapter.SelectCommand = cmd3;
            adapter.Fill(dt3);

            dataGridView1.DataSource = dt3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Hide();
            label4.Hide();
            label3.Hide();
            label2.Show();
            string querrystring1 = $"select id_book from СКП where id_user='{Program.TakeID()}' and status='Читаю сейчас'";
            DataTable dt1 = new DataTable();
            SqlCommand cmd1 = new SqlCommand(querrystring1, database.GetConnection());
            adapter.SelectCommand = cmd1;
            adapter.Fill(dt1);

            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            string querrystring2 = $"select Title, Autor from Книги where id_book='{Convert.ToInt32(dt1.Rows[0][0])}'";
            SqlCommand cmd2 = new SqlCommand(querrystring2, database.GetConnection());
            adapter.SelectCommand = cmd2;
            adapter.Fill(dt3);

            dataGridView1.DataSource = dt3;
        }

    }
}
