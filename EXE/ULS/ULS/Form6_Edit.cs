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
    public partial class Form6_Edit : Form
    {
        Form1 frm1;
        Form3_VibPreparat f3;
        DataGridView dv;
        Form24_VibIzgotovit f24;
        Form25_VibFirmPost f25;
        int focus;
        public Form6_Edit(Form1 f, DataGridView s, int index)
        {
            InitializeComponent();
            frm1 = f;
            f3 = new Form3_VibPreparat(f, f.f2, this);
            dv = s;
            focus = index;
            f24 = new Form24_VibIzgotovit(f.f2, this);
            f25 = new Form25_VibFirmPost(f.f2,this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        void en()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f3.fr2 = false;
            f3.fr6 = true;
            f3.ShowDialog();
        }

        public void func(string s, string s2)
        {
            textBox1.Text = s;
            textBox4.Text = s2;
        }

        public void func2(string s)
        {
            textBox7.Text = s;
        }
        public void func3(string s)
        {
            textBox8.Text = s;
        }

        public void upd()
        {
                string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Application.StartupPath + "\\BD.mdb");
                OleDbConnection connection = new OleDbConnection(connStringAcc);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                int count = (int.Parse(textBox5.Text));
                int cost = (int.Parse(textBox6.Text));
                string name = (textBox1.Text);
                string izgotovitel = (textBox7.Text);
                string postav = (textBox8.Text);
                string prihodn = (textBox2.Text);
                string seria = (textBox3.Text);
                string edizm = (textBox4.Text);
                int summ = (int.Parse(textBox5.Text) * int.Parse(textBox6.Text));
                string d1 = (dateTimePicker1.Value.ToShortDateString());
                string d2 = (dateTimePicker2.Value.ToShortDateString());
                int lastfocus = int.Parse(dv.Rows[focus].Cells[11].Value.ToString());
                command.CommandText = string.Format("UPDATE [Base] SET [firstcount]=" + count + ", [count]=" + count + ", [cost]=" + cost + ", [name]='" + name + "', [izgotovitel]='" + izgotovitel + "', [postavschik]='" + postav + "', [prihodndokum]='" + prihodn + "', [seria]='" + seria + "', [edenicizmerenia]='" + edizm + "', [datepoluch]='" + d1 + "', [srokgodnosti]='" + d2 + "', [summa]=" + summ + " WHERE (([id]=" + lastfocus + "))");
                command.ExecuteNonQuery();
                connection.Close();
        }

        private void Form6_Edit_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.FirmaPostav". При необходимости она может быть перемещена или удалена.
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Izgotovitel". При необходимости она может быть перемещена или удалена.
            this.izgotovitelTableAdapter.Fill(this.bDDataSet.Izgotovitel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.FirmaPostav". При необходимости она может быть перемещена или удалена.
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);

            textBox1.Text = dv.Rows[focus].Cells[0].Value.ToString();
            textBox7.Text = dv.Rows[focus].Cells[4].Value.ToString();
            textBox8.Text = dv.Rows[focus].Cells[2].Value.ToString();
            textBox2.Text = dv.Rows[focus].Cells[3].Value.ToString();
            textBox3.Text = dv.Rows[focus].Cells[5].Value.ToString();
            dateTimePicker1.Value= DateTime.Parse(dv.Rows[focus].Cells[1].Value.ToString());
            textBox4.Text = dv.Rows[focus].Cells[6].Value.ToString();
            textBox5.Text = dv.Rows[focus].Cells[7].Value.ToString();
            textBox6.Text = dv.Rows[focus].Cells[8].Value.ToString();
            dateTimePicker2.Value = DateTime.Parse(dv.Rows[focus].Cells[10].Value.ToString());
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
            {
                if (textBox5.Text != "")
                { int i = int.Parse(textBox5.Text); }
            }
            catch (Exception)
            { MessageBox.Show("Можно вводить только символы!"); textBox5.Text = ""; }
            en();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox6.Text != "")
                { int i = int.Parse(textBox6.Text); }
            }
            catch (Exception)
            { MessageBox.Show("Можно вводить только символы!"); textBox5.Text = ""; }
            en();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            upd();
            Close();
        }

        private void Form6_Edit_Activated(object sender, EventArgs e)
        {

            this.izgotovitelTableAdapter.Fill(this.bDDataSet.Izgotovitel);
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            f24.fr2 = false;
            f24.fr6 = true;
            f24.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f25.fr2 = false;
            f25.fr6 = true;
            f25.ShowDialog();
        }
    }
}
