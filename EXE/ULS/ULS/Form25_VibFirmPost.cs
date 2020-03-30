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
    public partial class Form25_VibFirmPost : Form
    {
        Form2_Prihod frm2;
        Form6_Edit frm6;
        public bool fr2 = false;
        public bool fr6 = false;
        public Form25_VibFirmPost(Form2_Prihod f2, Form6_Edit f6)
        {
            InitializeComponent();
            frm2 = f2;
            frm6 = f6;
        }

        private void Form25_VibFirmPost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.FirmaPostav". При необходимости она может быть перемещена или удалена.
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                firmaPostavBindingSource.Position = firmaPostavBindingSource.Find("Name", textBox1.Text);
            }
            catch (Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fr2 == true)
                frm2.func3(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            if (fr6 == true)
                frm6.func3(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
