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
    public partial class dobavlenie4 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database2.mdb";
        private OleDbConnection myConnection;
        public dobavlenie4()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int kod = Convert.ToInt32(textBox1.Text);
                int N1 = Convert.ToInt32(textBox2.Text);
                int N2 = Convert.ToInt32(textBox3.Text);
                int t1 = Convert.ToInt32(textBox9.Text);
                int t2 = Convert.ToInt32(textBox5.Text);
                string Koeff = textBox4.Text;
                string Dlina = textBox6.Text;
                string Skorost = textBox7.Text;
                string Uravn = textBox8.Text;
                string query = "INSERT INTO Sposob4 VALUES (" + kod + "," + N1 + "," + N2 + "," + t1 + "," + t2 + ",'" + Koeff + "','" + Dlina + "','" + Skorost + "','" + Uravn + "')";
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были добавлены");
                this.Close();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Данные не были добавлены");
            }
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label9_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
