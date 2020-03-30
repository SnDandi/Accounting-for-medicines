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
    public partial class Form11_DeletePostavschik : Form
    {
        Form1 frm1;
        public Form11_DeletePostavschik(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form11_DeletePostavschik_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.FirmaPostav". При необходимости она может быть перемещена или удалена.
            this.firmaPostavTableAdapter.Fill(this.bDDataSet.FirmaPostav);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                firmaPostavTableAdapter.Update(bDDataSet);
            }
            catch (Exception)
            { }
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
    }
}
