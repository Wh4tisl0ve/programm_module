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
using System.IO;

namespace Nauch
{
    public partial class Registration : Form
    {
        public static string connectString = "Provider = Microsoft.Jet.OLEDB.4.0;Data Source = Database2.mdb";
        private OleDbConnection myConnection;
        public Registration()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f1 = new FormLogin();
            f1.ShowDialog();
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

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin f = new FormLogin();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@"in.txt", false, Encoding.Default);
            sw.Write(textBox1.Text + textBox2.Text);
            sw.Close();
            string familia = textBox3.Text;
            string name = textBox4.Text;
            string otchestvo = textBox5.Text;
            int nomer; // Номер в алфавите
            int d; // Смещение
            string s; //Результат
            int j; // Переменная для циклов
            string log = textBox1.Text;
            string pas = textBox2.Text;
            string m = File.ReadAllText("in.txt", Encoding.GetEncoding(1251));
            char[] massage = m.ToCharArray(); // Превращаем строку в массив символов.
            //char[] alfavit = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я','А','Б','В','Г','Д','Е','Ё','Ж','З','И','Й','К','Л','М','Н','О','П','Р','С','Т','У','Ф','Х','Ц','Ч','Ш','Щ','Ъ','Ы','Ь','Э','Ю','Я' };
          char[] alfavit = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            if (log.Length != 0 && pas.Length != 0)
            {
                // Перебираем каждый символ сообщения
                for (int i = 0; i < massage.Length; i++)
                {
                    // Ищем индекс буквы
                    for (j = 0; j < alfavit.Length; j++)
                    {
                        if (massage[i] == alfavit[j])
                        {
                            break;
                        }
                    }
                    if (j != 26) // Если j равно 33, значит символ не из алфавита
                    {
                        nomer = j; // Индекс буквы
                        d = nomer + 3; // Делаем смещение

                        // Проверяем, чтобы не вышли за пределы алфавита
                        if (d > 25)
                        {
                            d = d - 26;
                        }
                        massage[i] = alfavit[d]; // Меняем букву
                    }
                }
                s = new string(massage); // Собираем символы обратно в строку.
                 File.WriteAllText("out.txt", s); // Записываем результат в файл. 
                 textBox6.Text = s.ToString();
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string Login = textBox1.Text;
                string Password = textBox2.Text;
                string familia = textBox3.Text;
                string name = textBox4.Text;
                string otchestvo = textBox5.Text;
                string uroven_dost = "user";
                string dolzhnost = "студент";
                string kluch = textBox6.Text;
                if (textBox1.Text.Length != 0 && textBox2.Text.Length != 0 && textBox3.Text.Length != 0 && textBox4.Text.Length != 0 && textBox5.Text.Length != 0)
                {
                    string query = "INSERT INTO Auto VALUES ('" + familia + "','" + name + "','" + otchestvo + "','" + dolzhnost + "','" + uroven_dost + "','" + Login + "','" + Password + "','" + kluch + "')";
                    OleDbCommand command = new OleDbCommand(query, myConnection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Регистрация прошла успешно!");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                    textBox6.Clear();
                }
                else
                {
                    MessageBox.Show("Не все данные введены!");
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Не все данные введены!");
            }
        }
    }
}
