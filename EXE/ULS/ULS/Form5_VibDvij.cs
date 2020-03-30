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
    public partial class Form5_VibDvij : Form
    {
        Form1 frm1;
        Form4_Rashod frm4;
        public bool f44;
        public bool f21;
        Form21OtPoOdnomuOtdeleniu ff21;
        public Form5_VibDvij(Form1 f, Form4_Rashod f4, Form21OtPoOdnomuOtdeleniu f2111)
        {
            frm1 = f;
            InitializeComponent();
            frm4 = f4;
            ff21 = f2111;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm4.en();
            Close();
        }

        private void Form5_VibOPrepar_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Otdelenie". При необходимости она может быть перемещена или удалена.
            this.otdelenieTableAdapter.Fill(this.bDDataSet.Otdelenie);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                otdelenieBindingSource.Position = otdelenieBindingSource.Find("Name", textBox1.Text);
            }
            catch (Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (f44 == true)
            {
                frm4.func(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                frm4.en();
            }
            if (f21==true)
            {
                ff21.func(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                ff21.en();
            }
            Close();
        }

    }
}
