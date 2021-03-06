﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ULS
{
    public partial class Form8_AddPreparat : Form
    {
        Form1 frm1;
        public Form8_AddPreparat(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form8_AddPreparat_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", Application.StartupPath + "\\BD.mdb");
            OleDbConnection connection = new OleDbConnection(connStringAcc);
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "insert into [NamePreparat] (Name, Type) values ('" + textBox1.Text + "','" + comboBox1.Text + "')";
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }
    }
}
