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
    public partial class Form13_DeleteIzgotovitel : Form
    {
        Form1 frm1;
        public Form13_DeleteIzgotovitel(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form13_DeleteIzgotovitel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Izgotovitel". При необходимости она может быть перемещена или удалена.
            this.izgotovitelTableAdapter.Fill(this.bDDataSet.Izgotovitel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                izgotovitelTableAdapter.Update(bDDataSet);
            }
            catch (Exception)
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                izgotovitelBindingSource.Position = izgotovitelBindingSource.Find("Name", textBox1.Text);
            }
            catch (Exception)
            { }
        }
    }
}
