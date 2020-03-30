using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULS
{
    public partial class Form2_Prihod : Form
    {
        Form1 frm1;
        Form3_VibPreparat f3;
        Form24_VibIzgotovit f24;
        Form25_VibFirmPost f25;
        public Form2_Prihod(Form1 f)
        {
            InitializeComponent();
            f3 = new Form3_VibPreparat(f,this, f.f6);
            frm1 = f;
            f24 = new Form24_VibIzgotovit(this, f.f6);
            f25 = new Form25_VibFirmPost(this, f.f6);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3.fr2 = true;
            f3.fr6 = false;
            f3.ShowDialog();
        }

        private void Form2_Prihod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.FirmaPostav". При необходимости она может быть перемещена или удалена.
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Izgotovitel". При необходимости она может быть перемещена или удалена.
            this.izgotovitelTableAdapter.Fill(this.bDDataSet.Izgotovitel);
        }
        //Функция для выбора препарата
        public void func(string s,string s2)
        {
            textBox1.Text = s;
            textBox4.Text = s2;
        }
        //Функция для выбора фирмы-изготовителя
        public void func2(string s)
        {
            textBox7.Text = s;
        }
        //функция для выбора фирмы-поставщика
        public void func3(string s)
        {
            textBox8.Text = s;
        }
        //Проверка заполнены ли все поля
        void en()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            en(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            en();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            en();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            en();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            en();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            en();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            { if (textBox5.Text != "")
                    { int i = int.Parse(textBox5.Text); }
            }
            catch(Exception)
            { MessageBox.Show("Можно вводить только символы!"); textBox5.Text = ""; }
            en();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            { if (textBox6.Text != "")
                { int i = int.Parse(textBox6.Text); }
            }
            catch (Exception)
            { MessageBox.Show("Можно вводить только символы!"); textBox6.Text = ""; }
            en();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Application.StartupPath + "\\BD.mdb");
            OleDbConnection connection = new OleDbConnection(connStringAcc);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            int sum = int.Parse(textBox5.Text) * int.Parse(textBox6.Text);
            int cost = int.Parse(textBox6.Text) + 0;
            int count = int.Parse(textBox5.Text) + 0;
            command.CommandText = "insert into [Base] ( [firstcount], [count], [cost], [name], [izgotovitel], [postavschik], [prihodndokum], [seria], [edenicizmerenia], [datepoluch],  [srokgodnosti], [summa]) values (" + count + "," + count + "," + cost + ",'" + textBox1.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + dateTimePicker1.Value.ToShortDateString() + "','" + dateTimePicker2.Value.ToShortDateString() + "', " + sum + ")";
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f24.fr2 = true;
            f24.fr6 = false;
            f24.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f25.fr2 = true;
            f25.fr6 = false;
            f25.ShowDialog();
        }
    }
}
