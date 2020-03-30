using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULS
{
    public partial class Form3_VibPreparat : Form
    {
        Form1 frm1;
        Form2_Prihod frm2;
        Form6_Edit frm6;
        public Form3_VibPreparat(Form1 f, Form2_Prihod f2, Form6_Edit f6)
        {
            InitializeComponent();
            frm1 = f;
            frm2 = f2;
            frm6 = f6;
        }
        public bool fr2 = false;
        public bool fr6 = false;

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form3_VibPreparat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.NamePreparat". При необходимости она может быть перемещена или удалена.
            this.namePreparatTableAdapter.Fill(this.bDDataSet.NamePreparat);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                namePreparatBindingSource.Position = namePreparatBindingSource.Find("Name", textBox1.Text);
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fr2==true)
                frm2.func(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
            if (fr6==true)
                frm6.func(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString());
            Close();
        }
    }
}
