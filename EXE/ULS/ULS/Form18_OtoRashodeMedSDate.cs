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
    public partial class Form18_OtoRashodeMedSDate : Form
    {
        Object Range;
        Excel._Worksheet workSheet;
        Form1 frm1;
        public Form18_OtoRashodeMedSDate(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form18_OtoRashodeMedSDate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Rashod". При необходимости она может быть перемещена или удалена.
            this.rashodTableAdapter.Fill(this.bDDataSet.Rashod);
        }

        private void ExportToExcel()
        {
            int count = 0;
            for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                            count++;
            if (count != 0)
            {

                Excel.Application exApp = new Excel.Application();
                exApp.Visible = true;
                exApp.Workbooks.Add();
                workSheet = (Worksheet)exApp.ActiveSheet;
                SetMerge("A1:L1", 3);
                SetMerge("A2:L2", 3);
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
                workSheet.Cells[4, 9].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 10].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 11].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 12].EntireRow.Font.Bold = true;
                SetBorderStyle("A4:L4", 1);
                workSheet.Cells[1, 1] = "Общий отчет";
                workSheet.Cells[2, 1] = "израсходованных лекарственных средств с " + dateTimePicker1.Value.ToShortDateString() + " по " + dateTimePicker2.Value.ToShortDateString() + " года.";
                workSheet.Cells[4, 1] = "№";
                workSheet.Cells[4, 2] = "Наименование";
                workSheet.Cells[4, 3] = "Фирма-поставщик";
                workSheet.Cells[4, 4] = "Назв. документа";
                workSheet.Cells[4, 5] = "Фирма-изготовитель";
                workSheet.Cells[4, 6] = "Серия препарата";
                workSheet.Cells[4, 7] = "Дата получ.";
                workSheet.Cells[4, 8] = "Дата расх.";//nen
                workSheet.Cells[4, 9] = "Ед. измерения";
                workSheet.Cells[4, 10] = "Колич.";
                workSheet.Cells[4, 11] = "Цена за ед.";
                workSheet.Cells[4, 12] = "Общая сумма";
                SetColumnWidth("A1", 3);
                SetColumnWidth("B1", 32);
                SetColumnWidth("C1", 19);
                SetColumnWidth("D1", 19);
                SetColumnWidth("E1", 22);
                SetColumnWidth("F1", 15);
                SetColumnWidth("G1", 12);
                SetColumnWidth("H1", 12);
                SetColumnWidth("I1", 16);
                SetColumnWidth("J1", 9);
                SetColumnWidth("K1", 11);
                SetColumnWidth("L1", 13);
                int rowExcel = 5;
                int obcol = 0;
                int obsum = 0;
                int col;
                int ocount = 0;
                for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                {
                    col = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                        {
                            if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                            {
                                col = col + int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                                SetBorderStyle("A" + (rowExcel).ToString() + ":L" + (rowExcel).ToString(), 1);
                                workSheet.Cells[rowExcel, "A"] = frm1.dataGridView1.Rows[j].Cells[11].Value;
                                workSheet.Cells[rowExcel, "B"] = frm1.dataGridView1.Rows[j].Cells[0].Value;
                                workSheet.Cells[rowExcel, "C"] = frm1.dataGridView1.Rows[j].Cells[2].Value;
                                workSheet.Cells[rowExcel, "D"] = frm1.dataGridView1.Rows[j].Cells[3].Value;
                                workSheet.Cells[rowExcel, "E"] = frm1.dataGridView1.Rows[j].Cells[4].Value;
                                workSheet.Cells[rowExcel, "F"] = frm1.dataGridView1.Rows[j].Cells[5].Value;
                                workSheet.Cells[rowExcel, "G"] = frm1.dataGridView1.Rows[j].Cells[1].Value;
                                workSheet.Cells[rowExcel, "H"] = dataGridView1.Rows[i].Cells[12].Value;
                                workSheet.Cells[rowExcel, "I"] = frm1.dataGridView1.Rows[j].Cells[6].Value;
                                workSheet.Cells[rowExcel, "J"] = col;
                                workSheet.Cells[rowExcel, "K"] = frm1.dataGridView1.Rows[j].Cells[8].Value;
                                workSheet.Cells[rowExcel, "L"] = col * (int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString()));
                                ++rowExcel;
                                obcol = obcol + col;
                                obsum = obsum + (col * (int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString())));
                                ocount++;
                            }
                        }
                    }
                }
                SetBorderStyle("H" + (ocount + 5).ToString() + ":L" + (ocount + 5).ToString(), 1);
                workSheet.Cells[ocount + 5, 9] = "ИТОГО:";
                workSheet.Cells[ocount + 5, 9].EntireRow.Font.Bold = true;
                workSheet.Cells[ocount + 5, 10] = obcol.ToString();
                workSheet.Cells[ocount + 5, 12] = obsum.ToString();
                workSheet.Cells[ocount + 5, 10].EntireRow.Font.Bold = true;
                workSheet.Cells[ocount + 5, 12].EntireRow.Font.Bold = true;
            }
            else
            { MessageBox.Show("За этот период нет израсходованных медикаментов!"); }
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

        private void button1_Click(object sender, EventArgs e)
        {
            ExportToExcel();
            Close();
        }    
    }
}
