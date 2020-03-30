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
    public partial class Form4_Rashod : Form
    {
        Form1 frm1;
        Form5_VibDvij f5;
        DataGridView dv;
        int focus;
        public Form4_Rashod(Form1 f, DataGridView s, int index, Form21OtPoOdnomuOtdeleniu f21)
        {
            InitializeComponent();
            frm1 = f;
            f5 = new Form5_VibDvij(f,this,f21);
            dv = s;
            focus = index;
        }
        //Функция для выбора движения
        public void func(string s)
        {
            textBox7.Text = s;
        }
        //Проверка заполнены ли все поля
        public void en()
        {
            if (textBox7.Text != "" && textBox8.Text != "" )
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void Form4_Rashod_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Rashod". При необходимости она может быть перемещена или удалена.
            this.rashodTableAdapter.Fill(this.bDDataSet.Rashod);
            textBox1.Text = dv.Rows[focus].Cells[0].Value.ToString();
            textBox2.Text = dv.Rows[focus].Cells[4].Value.ToString();
            textBox3.Text = dv.Rows[focus].Cells[2].Value.ToString();
            textBox4.Text = dv.Rows[focus].Cells[3].Value.ToString();
            textBox5.Text = dv.Rows[focus].Cells[5].Value.ToString();
            textBox6.Text = dv.Rows[focus].Cells[6].Value.ToString();
            textBox9.Text = dv.Rows[focus].Cells[7].Value.ToString();
            textBox10.Text = dv.Rows[focus].Cells[8].Value.ToString();
            textBox11.Text = dv.Rows[focus].Cells[1].Value.ToString();
            textBox12.Text = dv.Rows[focus].Cells[10].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f5.f44 = true;
            f5.f21 = false;
            f5.ShowDialog();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox8.Text != "")
                { int i = int.Parse(textBox8.Text); }
            }
            catch (Exception)
            { MessageBox.Show("Можно вводить только символы!"); textBox8.Text = ""; }
            en();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox8.Text) > 0 && int.Parse(textBox9.Text) - int.Parse(textBox8.Text) >= 0)
            {

                string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Application.StartupPath + "\\BD.mdb");
                OleDbConnection connection = new OleDbConnection(connStringAcc);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int cost = int.Parse(textBox10.Text) + 0;
                int count = int.Parse(textBox9.Text) + 0;
                command.CommandText = "insert into [Rashod] ([idbase], [cost], [name], [izgotovitel], [postavka], [prihodndokum], [seria], [edinicizmerenia], [otdelenie], [countizrashod], [datepoluch],  [srokgodnosti], [datarashod]) values (" + int.Parse(dv.Rows[focus].Cells[11].Value.ToString()) + "," + cost + ",'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "'," + int.Parse(textBox8.Text) + ",'" + textBox11.Text + "','" + textBox12.Text + "','" + DateTime.Now.ToShortDateString() + "')";
                command.ExecuteNonQuery();
                connection.Close();
                frm1.newcount = int.Parse(textBox9.Text) - int.Parse(textBox8.Text);
                frm1.lastfocus = int.Parse(dv.Rows[focus].Cells[11].Value.ToString());
                frm1.newsum = int.Parse(dv.Rows[focus].Cells[9].Value.ToString()) - (int.Parse(textBox8.Text) * int.Parse(textBox10.Text));
                Close();
            }
            else
            {
                MessageBox.Show("Введенное значение превышает количество, либо оно равно нулю!");
            }
        }
        

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            en();
        }
    }
}
