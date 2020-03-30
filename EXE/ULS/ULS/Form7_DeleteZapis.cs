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
    public partial class Form7_DeleteZapis : Form
    {
        Form1 frm1;
        DataGridView dv;
        int focus;

        public Form7_DeleteZapis(Form1 f, DataGridView s, int index)
        {
            InitializeComponent();
            frm1 = f;
            dv = s;
            focus = index;
        }

        private void Form7_DeleteZapis_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Application.StartupPath + "\\BD.mdb");
            OleDbConnection connection = new OleDbConnection(connStringAcc);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            int lastfocus = int.Parse(dv.Rows[focus].Cells[11].Value.ToString());
            command.CommandText = string.Format("DELETE FROM [Base]  WHERE (([id]=" + lastfocus + "))");
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }

    }
}
