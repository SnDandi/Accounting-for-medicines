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
    public partial class Form16_OtOSrokeGodnosti : Form
    {
        Object Range;
        Excel._Worksheet workSheet;
        Form1 frm1;
        public Form16_OtOSrokeGodnosti(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void Form16_OtOSrokeGodnosti_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
            Close();
        }
        private void ExportToExcel()
        {
            int count = 0;
            for (int i = 0; i < frm1.dataGridView1.Rows.Count-1; i++)
            {
                if (DateTime.Parse(frm1.dataGridView1.Rows[i].Cells[10].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) <= 0)
                { count++; }
            }
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
                workSheet.Cells[4, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 2].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 3].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 4].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 5].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 6].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 7].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 8].EntireRow.Font.Bold = true;
                SetBorderStyle("A4:H4", 1);
                workSheet.Cells[1, 1] = "Отчет";
                workSheet.Cells[2, 1] = "по лекарственным средствам у которых истёк срок годности на " + dateTimePicker1.Value.ToShortDateString() + " года.";
                workSheet.Cells[4, 1] = "№";
                workSheet.Cells[4, 2] = "Наименование";
                workSheet.Cells[4, 3] = "Дата получ.";
                workSheet.Cells[4, 4] = "Срок годн.";
                workSheet.Cells[4, 5] = "Ед. измерения";
                workSheet.Cells[4, 6] = "Колич.";
                workSheet.Cells[4, 7] = "Цена за ед.";
                workSheet.Cells[4, 8] = "Общая сумма";
                workSheet.Cells[count+5, 5] = "ИТОГО:";
                workSheet.Cells[count + 5, 5].EntireRow.Font.Bold = true;
                SetBorderStyle("E" + (count + 5).ToString() + ":H" + (count + 5).ToString(), 1);
                SetColumnWidth("A1", 3);
                SetColumnWidth("B1", 32);
                SetColumnWidth("C1", 11);
                SetColumnWidth("D1", 11);
                SetColumnWidth("E1", 14);
                SetColumnWidth("F1", 7);
                SetColumnWidth("G1", 12);
                SetColumnWidth("H1", 13);
                int rowExcel = 5;
                int col = 0;
                int sum = 0;
                for (int i = 0; i < frm1.dataGridView1.Rows.Count-1; i++)
                {
                    if (DateTime.Parse(frm1.dataGridView1.Rows[i].Cells[10].Value.ToString()).CompareTo(dateTimePicker1.Value) < 0 || DateTime.Parse(frm1.dataGridView1.Rows[i].Cells[10].Value.ToString()).CompareTo(dateTimePicker1.Value) == 0)
                    {
                        SetBorderStyle("A" + (i + 5).ToString() + ":H" + (i + 5).ToString(), 1);
                        workSheet.Cells[rowExcel, "A"] = frm1.dataGridView1.Rows[i].Cells[11].Value;
                        workSheet.Cells[rowExcel, "B"] = frm1.dataGridView1.Rows[i].Cells[0].Value;
                        workSheet.Cells[rowExcel, "C"] = frm1.dataGridView1.Rows[i].Cells[1].Value;
                        workSheet.Cells[rowExcel, "D"] = frm1.dataGridView1.Rows[i].Cells[10].Value;
                        workSheet.Cells[rowExcel, "E"] = frm1.dataGridView1.Rows[i].Cells[6].Value;
                        workSheet.Cells[rowExcel, "F"] = frm1.dataGridView1.Rows[i].Cells[7].Value;
                        workSheet.Cells[rowExcel, "G"] = frm1.dataGridView1.Rows[i].Cells[8].Value;
                        workSheet.Cells[rowExcel, "H"] = frm1.dataGridView1.Rows[i].Cells[9].Value;
                        ++rowExcel;
                        col = col + int.Parse(frm1.dataGridView1.Rows[i].Cells[7].Value.ToString());
                        sum = sum + int.Parse(frm1.dataGridView1.Rows[i].Cells[9].Value.ToString());
                    }
                }
                workSheet.Cells[count + 5, 6] = col.ToString();
                workSheet.Cells[count + 5, 8] = sum.ToString();
                workSheet.Cells[count + 5, 6].EntireRow.Font.Bold = true;
                workSheet.Cells[count + 5, 8].EntireRow.Font.Bold = true;
            }
            else
            { MessageBox.Show("На данную дату нет просроченных медикаментов!"); }
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

    }
}
