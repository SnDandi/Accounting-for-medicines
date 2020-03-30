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
    public partial class Form9_DeletePrepapat : Form
    {
        Form1 frm1;
        public Form9_DeletePrepapat(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form9_DeletePrepapat_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.NamePreparat". При необходимости она может быть перемещена или удалена.
            this.namePreparatTableAdapter.Fill(this.bDDataSet.NamePreparat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                namePreparatTableAdapter.Update(bDDataSet);
            }
            catch(Exception)
            { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                namePreparatBindingSource.Position = namePreparatBindingSource.Find("Name", textBox1.Text);
            }
            catch (Exception)
            { }
        }
    }
}
