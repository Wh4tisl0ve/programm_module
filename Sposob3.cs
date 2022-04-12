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
    public partial class Sposob3 : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database2.mdb";
        private OleDbConnection myConnection;
        public Sposob3()
        {
            InitializeComponent();
            groupBox1.Enabled = FormLogin.bso;
            groupBox1.Enabled = FormLoginKey.bso;
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }

        private void Sposob3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Sposob3". При необходимости она может быть перемещена или удалена.
            this.sposob3TableAdapter.Fill(this.database2DataSet.Sposob3);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "database2DataSet.Sposob3". При необходимости она может быть перемещена или удалена.
            this.dataGridView1.ForeColor = Color.Black;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu f2 = new Menu();
            f2.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dobavlenie3 d3 = new dobavlenie3();
            d3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.sposob3TableAdapter.Fill(this.database2DataSet.Sposob3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int kod = Convert.ToInt32(textBox1.Text);
                string query = " DELETE FROM Sposob3 WHERE [Код] = " + kod;
                OleDbCommand command = new OleDbCommand(query, myConnection);
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были удалены");
                this.sposob3TableAdapter.Fill(this.database2DataSet.Sposob3);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Данные не были удалены");
            }
        }
        Point lastPoint;
        private void panel3_MouseMove(object sender, MouseEventArgs e)
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

        private void label1_MouseMove(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Calculated_Form3 c = new Calculated_Form3();
            c.ShowDialog();
        }
    }
}
