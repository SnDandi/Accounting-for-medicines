using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ULS
{
    public partial class Form21OtPoOdnomuOtdeleniu : Form
    {

        Form5_VibDvij f5;
        Object Range;
        Excel._Worksheet workSheet;
        Form1 frm1;
        public Form21OtPoOdnomuOtdeleniu(Form1 f, Form4_Rashod f4)
        {
            f5 = new Form5_VibDvij(f,f4, this);
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Form21OtPoOdnomuOtdeleniu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Otdelenie". При необходимости она может быть перемещена или удалена.
            this.otdelenieTableAdapter.Fill(this.bDDataSet.Otdelenie);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Rashod". При необходимости она может быть перемещена или удалена.
            this.rashodTableAdapter.Fill(this.bDDataSet.Rashod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
            Close();
        }

        private void ExportToExcel()
        {
            int count = 0;
            for (int u = 0; u < dataGridView2.Rows.Count - 1; u++)
                for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        if (dataGridView2.Rows[u].Cells[1].Value.ToString() == textBox1.Text.ToString())
                            if (dataGridView2.Rows[u].Cells[1].Value.ToString() == dataGridView1.Rows[i].Cells[13].Value.ToString())
                                if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                                    if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                                        count++;
            if (count != 0)
            {
                Excel.Application exApp = new Excel.Application();
                exApp.Visible = true;
                exApp.Workbooks.Add();
                workSheet = (Worksheet)exApp.ActiveSheet;
                SetMerge("A1:H1", 3);
                SetMerge("A2:H2", 3);
                workSheet.Cells[1, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[2, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[1, 1] = "Отчёт израсходованных лекарственных средств";
                workSheet.Cells[2, 1] = "с " + dateTimePicker1.Value.ToShortDateString() + " по " + dateTimePicker2.Value.ToShortDateString() + " года для всех отделений.";
                SetColumnWidth("A1", 3);
                SetColumnWidth("B1", 32);
                SetColumnWidth("C1", 19);
                SetColumnWidth("D1", 19);
                SetColumnWidth("E1", 22);
                SetColumnWidth("F1", 15);
                SetColumnWidth("G1", 12);
                SetColumnWidth("H1", 16);
                int rowExcel = 6;
                int obcol = 0;
                int obsum = 0;
                int col;
                for (int u = 0; u < dataGridView2.Rows.Count - 1; u++)
                {
                    if (dataGridView2.Rows[u].Cells[1].Value.ToString() == textBox1.Text)
                    {
                        SetMerge("A" + (rowExcel - 2).ToString() + ":H" + (rowExcel - 2).ToString(), 3);
                        workSheet.Cells[(rowExcel - 2), 1].EntireRow.Font.Bold = true;
                        workSheet.Cells[(rowExcel - 2), 1] = dataGridView2.Rows[u].Cells[1].Value.ToString();
                        int xcv = rowExcel - 1;
                        workSheet.Cells[xcv, 1] = "№";
                        workSheet.Cells[xcv, 2] = "Наименование";
                        workSheet.Cells[xcv, 3] = "Фирма-поставщик";
                        workSheet.Cells[xcv, 4] = "Фирма-изготовитель";
                        workSheet.Cells[xcv, 5] = "Ед. измерения";
                        workSheet.Cells[xcv, 6] = "Колич.";
                        workSheet.Cells[xcv, 7] = "Цена за ед.";
                        workSheet.Cells[xcv, 8] = "Общая сумма";
                        workSheet.Cells[xcv, 1].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 2].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 3].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 4].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 5].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 6].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 7].EntireRow.Font.Bold = true;
                        workSheet.Cells[xcv, 8].EntireRow.Font.Bold = true;
                        SetColumnWidth("A" + (xcv).ToString(), 3);
                        SetColumnWidth("A" + (xcv).ToString(), 32);
                        SetColumnWidth("A" + (xcv).ToString(), 19);
                        SetColumnWidth("A" + (xcv).ToString(), 19);
                        SetColumnWidth("A" + (xcv).ToString(), 22);
                        SetColumnWidth("A" + (xcv).ToString(), 15);
                        SetColumnWidth("A" + (xcv).ToString(), 12);
                        SetColumnWidth("A" + (xcv).ToString(), 16);
                        SetBorderStyle("A" + (xcv).ToString() + ":H" + (xcv).ToString(), 1);
                        for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                        {
                            col = 0;
                            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                            {

                                if (dataGridView2.Rows[u].Cells[1].Value.ToString() == dataGridView1.Rows[i].Cells[13].Value.ToString())
                                {

                                    if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                                    {
                                        if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                                        {
                                            col = col + int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                                        }
                                    }
                                }

                            }

                            if (col > 0)
                            {
                                SetBorderStyle("A" + (rowExcel).ToString() + ":H" + (rowExcel).ToString(), 1);
                                workSheet.Cells[rowExcel, "A"] = frm1.dataGridView1.Rows[j].Cells[11].Value;
                                workSheet.Cells[rowExcel, "B"] = frm1.dataGridView1.Rows[j].Cells[0].Value;
                                workSheet.Cells[rowExcel, "C"] = frm1.dataGridView1.Rows[j].Cells[2].Value;
                                workSheet.Cells[rowExcel, "D"] = frm1.dataGridView1.Rows[j].Cells[4].Value;
                                workSheet.Cells[rowExcel, "E"] = frm1.dataGridView1.Rows[j].Cells[6].Value;
                                workSheet.Cells[rowExcel, "F"] = col;
                                workSheet.Cells[rowExcel, "G"] = frm1.dataGridView1.Rows[j].Cells[8].Value;
                                workSheet.Cells[rowExcel, "H"] = (col * int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString()));
                                ++rowExcel;
                                obcol = obcol + col;
                                obsum = obsum + (col * (int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString())));
                            }
                        }
                        SetBorderStyle("E" + (rowExcel).ToString() + ":H" + (rowExcel).ToString(), 1);
                        workSheet.Cells[rowExcel, 5] = "ИТОГО:";
                        workSheet.Cells[rowExcel, 6] = obcol.ToString();
                        workSheet.Cells[rowExcel, 8] = obsum.ToString();
                        workSheet.Cells[rowExcel, 6].EntireRow.Font.Bold = true;
                        workSheet.Cells[rowExcel, 8].EntireRow.Font.Bold = true;
                        rowExcel += 5;
                        obcol = 0;
                        obsum = 0;
                    }
                }
            }
            else
            { MessageBox.Show("За этот период нет расходов по отделениям!"); }
        }

        private void SetColumnWidth(string range, double Width)//TODO: Ширина столбца
        {
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, workSheet, new object[] { range });
            object[] args = new object[] { Width };
            Range.GetType().InvokeMember("ColumnWidth", BindingFlags.SetProperty, null, Range, args);
        }
        private void SetBorderStyle(string range, int Style)//TODO: Стиль границ ячейки
        {
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, workSheet, new object[] { range });
            object[] args = new object[] { Style };
            object Borders = Range.GetType().InvokeMember("Borders", BindingFlags.GetProperty, null, Range, null);
            Borders = Range.GetType().InvokeMember("LineStyle", BindingFlags.SetProperty, null, Borders, args);
        }
        private void SetWrapText(string range, bool Value)//TODO: Перенос по словам
        {
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, workSheet, new object[] { range });
            object[] args = new object[] { Value };
            Range.GetType().InvokeMember("WrapText", BindingFlags.SetProperty, null, Range, args);
        }
        private void SetRowHeight(string range, double Height)//TODO: Высота строк
        {
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty,
                null, workSheet, new object[] { range });
            object[] args = new object[] { Height };
            Range.GetType().InvokeMember("RowHeight", BindingFlags.SetProperty, null, Range, args);
        }
        private void SetMerge(string range, int Alignment)//TODO: Выравнивание текста в ячейке
        {
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty, null, workSheet, new object[] { range });
            object[] args = new object[] { Alignment };
            Range.GetType().InvokeMember("MergeCells", BindingFlags.SetProperty, null, Range, new object[] { true });
            Range.GetType().InvokeMember("HorizontalAlignment", BindingFlags.SetProperty, null, Range, args);
        }
        private void SetFont(string range, Microsoft.Office.Interop.Excel.Font font)
        {
            //Range.Font.Name
            Range = workSheet.GetType().InvokeMember("Range", BindingFlags.GetProperty,
                null, workSheet, new object[] { range });

            object Font = Range.GetType().InvokeMember("Font", BindingFlags.GetProperty,
                null, Range, null);

            Range.GetType().InvokeMember("Name", BindingFlags.SetProperty, null,
                Font, new object[] { font.Name });

            Range.GetType().InvokeMember("Size", BindingFlags.SetProperty, null,
                Font, new object[] { font.Size });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f5.f21 = true;
            f5.f44 = false;
            f5.ShowDialog();
        }


        public void func(string s)
        {
            textBox1.Text = s;
        }
        public void en()
        {
            if (textBox1.Text != "" )
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }
    }
}
