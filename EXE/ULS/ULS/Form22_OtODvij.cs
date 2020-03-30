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
    public partial class Form22_OtODvij : Form
    {
        Object Range;
        Excel._Worksheet workSheet;
        Form1 frm1;
        public Form22_OtODvij(Form1 f)
        {
            InitializeComponent();
            frm1 = f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form22_OtODvij_Load(object sender, EventArgs e)
        {
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
            for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                    count++;
            if (count != 0)
            {
                Excel.Application exApp = new Excel.Application();
                exApp.Visible = true;
                exApp.Workbooks.Add();
                workSheet = (Worksheet)exApp.ActiveSheet;
                SetMerge("A1:K1", 3);
                SetMerge("A2:K2", 3);
                SetMerge("A4:A5", 3);
                SetMerge("B4:B5", 3);
                SetMerge("C4:C5", 3);
                SetMerge("D4:E4", 3);
                SetMerge("F4:G4", 3);
                SetMerge("H4:I4", 3);
                SetMerge("J4:K4", 3);
                workSheet.Cells[1, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[2, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 4].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 6].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 8].EntireRow.Font.Bold = true;
                workSheet.Cells[4, 10].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 1].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 2].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 3].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 4].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 5].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 6].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 7].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 8].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 9].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 10].EntireRow.Font.Bold = true;
                workSheet.Cells[5, 11].EntireRow.Font.Bold = true;
                SetBorderStyle("A4:K4", 1);
                SetBorderStyle("A5:K5", 1);
                workSheet.Cells[1, 1] = "Отчёт о движении медикаментов";
                workSheet.Cells[2, 1] = "и средств медицинского назначения с " + dateTimePicker1.Value.ToShortDateString() + " по " + dateTimePicker2.Value.ToShortDateString() + " года.";
                workSheet.Cells[4, 1] = "№";
                workSheet.Cells[4, 2] = "Наименование";
                workSheet.Cells[4, 3] = "Ед. измерения";
                workSheet.Cells[4, 4] = "Остаток на начало периода";
                workSheet.Cells[4, 6] = "Приход";
                workSheet.Cells[4, 8] = "Израсходовано";
                workSheet.Cells[4, 10] = "Остаток на конец периода";
                workSheet.Cells[5, 4] = "Кол-во";
                workSheet.Cells[5, 5] = "Сумма";
                workSheet.Cells[5, 6] = "Кол-во";
                workSheet.Cells[5, 7] = "Сумма";
                workSheet.Cells[5, 8] = "Кол-во";
                workSheet.Cells[5, 9] = "Сумма";
                workSheet.Cells[5, 10] = "Кол-во";
                workSheet.Cells[5, 11] = "Сумма";
                SetColumnWidth("A1", 3);
                SetColumnWidth("B1", 32);
                SetColumnWidth("C1", 19);
                SetColumnWidth("D1", 19);
                SetColumnWidth("E1", 22);
                SetColumnWidth("F1", 15);
                SetColumnWidth("G1", 12);
                SetColumnWidth("H1", 16);
                SetColumnWidth("I1", 9);
                SetColumnWidth("J1", 11);
                SetColumnWidth("K1", 13);
                int rowExcel = 6;
                int colstart=0;
                int summstart=0;
                int colend=0;
                int summend=0;
                int sumprihod = 0;
                int colprihod=0;
                int colrashod = 0;
                int sumrashod = 0;
                for (int j = 0; j < frm1.dataGridView1.Rows.Count - 1; j++)
                    {
                    colstart=0;
                    summstart=0;
                    colend=0;
                    summend=0;
                    sumprihod = 0;
                    colprihod=0;
                    colrashod = 0;
                    sumrashod = 0;
                    if (DateTime.Parse(frm1.dataGridView1.Rows[j].Cells[1].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) == 0)
                    {
                        colstart = 0;
                        summstart = 0;
                    }
                    if (DateTime.Parse(frm1.dataGridView1.Rows[j].Cells[1].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) > 0)
                    {
                        colstart = 0;
                        summstart = 0;
                    }
                    if (DateTime.Parse(frm1.dataGridView1.Rows[j].Cells[1].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) < 0)
                    {
                        colstart = int.Parse(frm1.dataGridView1.Rows[j].Cells[12].Value.ToString());
                        summstart = int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString()) * int.Parse(frm1.dataGridView1.Rows[j].Cells[12].Value.ToString());
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                            {
                                if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) < 0)
                                {
                                    summstart -= (int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()));
                                    colstart -= int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                                }
                            }
                        }
                    }
                    if (DateTime.Parse(frm1.dataGridView1.Rows[j].Cells[1].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(frm1.dataGridView1.Rows[j].Cells[1].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                    {
                        colprihod = int.Parse(frm1.dataGridView1.Rows[j].Cells[12].Value.ToString());
                        sumprihod = int.Parse(frm1.dataGridView1.Rows[j].Cells[8].Value.ToString()) * int.Parse(frm1.dataGridView1.Rows[j].Cells[12].Value.ToString());
                    }
                        colend = int.Parse(frm1.dataGridView1.Rows[j].Cells[7].Value.ToString());
                        summend = int.Parse(frm1.dataGridView1.Rows[j].Cells[9].Value.ToString());
                        if (int.Parse(frm1.dataGridView1.Rows[j].Cells[12].Value.ToString()) > int.Parse(frm1.dataGridView1.Rows[j].Cells[7].Value.ToString()))
                        {
                            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                            {
                                if (int.Parse(frm1.dataGridView1.Rows[j].Cells[11].Value.ToString()) == int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                                {
                                    if (DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker1.Value.ToShortDateString())) >= 0 && DateTime.Parse(dataGridView1.Rows[i].Cells[12].Value.ToString()).CompareTo(DateTime.Parse(dateTimePicker2.Value.ToShortDateString())) <= 0)
                                    {
                                        colrashod += int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                                        sumrashod += (int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString()) * int.Parse(dataGridView1.Rows[i].Cells[10].Value.ToString()));
                                    }
                                }
                            }
                        }
                        SetBorderStyle("A" + (rowExcel).ToString() + ":K" + (rowExcel).ToString(), 1);
                        workSheet.Cells[rowExcel, "A"] = frm1.dataGridView1.Rows[j].Cells[11].Value;
                        workSheet.Cells[rowExcel, "B"] = frm1.dataGridView1.Rows[j].Cells[0].Value;
                        workSheet.Cells[rowExcel, "C"] = frm1.dataGridView1.Rows[j].Cells[6].Value;
                        workSheet.Cells[rowExcel, "D"] = colstart;
                        workSheet.Cells[rowExcel, "E"] = summstart;
                        workSheet.Cells[rowExcel, "F"] = colprihod;
                        workSheet.Cells[rowExcel, "G"] = sumprihod;
                        workSheet.Cells[rowExcel, "H"] = colrashod;
                        workSheet.Cells[rowExcel, "I"] = sumrashod;
                        workSheet.Cells[rowExcel, "J"] = colend;
                        workSheet.Cells[rowExcel, "K"] = summend;
                        ++rowExcel;
                }
            }
            else
            { MessageBox.Show("За этот период нет записей!"); }
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
