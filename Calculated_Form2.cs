using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Nauch
{
    public partial class Calculated_Form2 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database2.mdb";
        private OleDbConnection myConnection;
        public Calculated_Form2()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Calculated_Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Result". При необходимости она может быть перемещена или удалена.
            this.resultTableAdapter.Fill(this.database2DataSet.Result);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod = Convert.ToInt32(textBox1.Text);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Введите код записи");
            }
            string t1_zapros = "SELECT t1 FROM Sposob2 WHERE Код =" + textBox1.Text;
            string t2_zapros = "SELECT t2 FROM Sposob2 WHERE Код =" + textBox1.Text;
            string N1_zapros = "SELECT N1 FROM Sposob2 WHERE Код =" + textBox1.Text;
            string N2_zapros = "SELECT N2 FROM Sposob2 WHERE Код =" + textBox1.Text;
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectString))
                {
                    OleDbCommand command = new OleDbCommand(t1_zapros, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string Word1 = reader.GetValue(0).ToString();
                        label6.Text = Word1;
                    }
                    reader.Close();
                }

            }
            catch (Exception)
            {

            }
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectString))
                {
                    OleDbCommand command = new OleDbCommand(t2_zapros, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string Word1 = reader.GetValue(0).ToString();
                        label7.Text = Word1;
                    }
                    reader.Close();
                }

            }
            catch (Exception)
            {

            }
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectString))
                {
                    OleDbCommand command = new OleDbCommand(N1_zapros, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string Word1 = reader.GetValue(0).ToString();
                        label8.Text = Word1;
                    }
                    reader.Close();
                }

            }
            catch (Exception)
            {

            }
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectString))
                {
                    OleDbCommand command = new OleDbCommand(N2_zapros, connection);
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string Word1 = reader.GetValue(0).ToString();
                        label9.Text = Word1;
                    }
                    reader.Close();
                }

            }
            catch (Exception)
            {

            }
            try
            {
                int t1 = Convert.ToInt32(label6.Text), t2 = Convert.ToInt32(label7.Text);
                int T = 33;
                double lambda1 = t1 / T;
                double lambda2 = t2 / T;
                int N1 = Convert.ToInt32(label8.Text), N2 = Convert.ToInt32(label9.Text);
                int x1 = N1 * T / t1, x2 = N1 * T / t2;
                double Delta_t_1, Delta_t_2, Delta_res;
                Delta_t_1 = 0.9 * (((T * (1 - lambda1)) / 2 * (1 - lambda1 * x1)) + (Math.Pow(x1, 2) / (2 * N1 * (1 - x1))));//для регулируемого перекрестка
                Delta_t_2 = 0.9 * (((T * (1 - lambda2)) / 2 * (1 - lambda2 * x2)) + (Math.Pow(x2, 2) / (2 * N2 * (1 - x2))));//для не регулируемого перекрестка
                Delta_res = ((Delta_t_1 * N1) + (Delta_t_2 * N2) / (N1 + N2));
                textBox2.Text = Delta_res.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Не все переменные введены");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string res = textBox2.Text;
                string sposob = "2 способ(" + textBox1.Text + " код)";
                string query = "INSERT INTO Result VALUES ('" + res + "','" + sposob + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были добавлены");
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка добавления");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resultTableAdapter.Fill(this.database2DataSet.Result);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sposob2 d2 = new Sposob2();
            d2.ShowDialog();
        }
        Point lastPoint;
        private void Calculated_Form2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
