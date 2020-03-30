using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ULS
{
    public partial class Form1 : Form
    {
        Object Range;
        Excel._Worksheet workSheet;
        public Form2_Prihod f2;
        public Form4_Rashod f4;
        public Form6_Edit f6;
        Form7_DeleteZapis f7;
        Form8_AddPreparat f8 ;
        Form9_DeletePrepapat f9 ;
        Form10_AddPostavschik f10 ;
        Form11_DeletePostavschik f11;
        Form12_AddIzgotovitel f12 ;
        Form13_DeleteIzgotovitel f13 ;
        Form14_AddPeremeschenie f14;
        Form15_DeletePeremeschenie f15;
        Form16_OtOSrokeGodnosti f16;
        Form17_OtORashodMed f17;
        Form18_OtoRashodeMedSDate f18 ;
        Form19_OtOPriobretenii f19;
        Form20OtPoVsemOtdeleniam f20;
        Form21OtPoOdnomuOtdeleniu f21 ;
        Form22_OtODvij f22 ;
        Form23_OProgramme f23 = new Form23_OProgramme();
        public Form1()
        {
            InitializeComponent();
        }
        public int newcount = 0;
        public int lastfocus = 0;
        public int newsum = 0;
        //Процедура для обновления таблиц на форме
        public void upd()
        {
            if (newcount >= 0)
            {

                string connStringAcc = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", System.Windows.Forms.Application.StartupPath + "\\BD.mdb");
                OleDbConnection connection = new OleDbConnection(connStringAcc);
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = string.Format("UPDATE [Base] SET [count]="+ newcount +",[summa]="+newsum+" WHERE (([id]="+lastfocus+"))");
                command.ExecuteNonQuery();
                connection.Close();
                this.baseTableAdapter.Update(bDDataSet);
                this.baseTableAdapter.Fill(this.bDDataSet.Base);
            }
        }
        //Процедура выхода из программы
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Приход
        private void приходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2_Prihod(this);
            f2.ShowDialog();
        }
        //Расход
        private void расходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f4 = new Form4_Rashod(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex,f21);
                f4.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }
        //Редактирование записи
        private void редактироватьЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[12].Value.ToString() == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString())
                {
                    f6 = new Form6_Edit(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex);
                    f6.ShowDialog();
                }
                else
                    MessageBox.Show("Эту запись редактировать нельзя!");
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }
        //Удаление записи
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                f7 = new Form7_DeleteZapis(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex);
                f7.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }
        //Новый препарат
        private void новыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f8 = new Form8_AddPreparat(this);
            f8.ShowDialog();
        }
        //Удалить препарат
        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f9 = new Form9_DeletePrepapat(this);
            f9.ShowDialog();
        }
        //Новый поставщик
        private void новаяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f10 = new Form10_AddPostavschik(this);
            f10.ShowDialog();
        }
        //Удалить поставщика
        private void удалитьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            f11 = new Form11_DeletePostavschik(this);
            f11.ShowDialog();
        }
        //Новый изготовитель
        private void новаяToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            f12 = new Form12_AddIzgotovitel(this);
            f12.ShowDialog();
        }
        //Удалить изготовителя
        private void удалитьToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            f13 = new Form13_DeleteIzgotovitel(this);
            f13.ShowDialog();
        }
        //Новое перемещение
        private void новоеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f14 = new Form14_AddPeremeschenie(this);
            f14.ShowDialog();
        }
        //Удалить перемещение
        private void удалитьToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            f15 = new Form15_DeletePeremeschenie(this);
            f15.ShowDialog();
        }
        //Отчет о сроке годности
        private void оСрокеГодностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f16 = new Form16_OtOSrokeGodnosti(this);
            f16.ShowDialog();
        }
        //Отчет о расходе
        private void оРасходеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f17 = new Form17_OtORashodMed(this);
            f17.ShowDialog();
        }
        //Отчет о расходе с датой
        private void оРасходеСДатойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f18 = new Form18_OtoRashodeMedSDate(this);
            f18.ShowDialog();
        }
        //Отчет о приобретении
        private void оПриобретенииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f19 = new Form19_OtOPriobretenii(this);
            f19.ShowDialog();
        }
        //Отчет по всем отделениям
        private void поВсемОтделениямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f20 = new Form20OtPoVsemOtdeleniam(this);
            f20.ShowDialog();
        }
        //Отчет по одному отделению
        private void поОдномуОтделениюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f21 = new Form21OtPoOdnomuOtdeleniu(this,f4);
            f21.ShowDialog();
        }
        //Отчет о движении
        private void оДвиженииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f22 = new Form22_OtODvij(this);
            f22.ShowDialog();
        }
        //Вызов окно "О программе"
        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f23 = new Form23_OProgramme();
            f23.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bDDataSet.Base". При необходимости она может быть перемещена или удалена.
            this.baseTableAdapter.Fill(this.bDDataSet.Base);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            upd();
            this.baseTableAdapter.Fill(this.bDDataSet.Base);
            
        }
        //Поиск по главной таблице
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
           }
            if (textBox1.Text=="")
                dataGridView1.ClearSelection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2_Prihod(this);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                f4 = new Form4_Rashod(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex, f21);
                f4.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[12].Value.ToString() == dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[7].Value.ToString())
                {
                    f6 = new Form6_Edit(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex);
                    f6.ShowDialog();
                }
                else
                    MessageBox.Show("Эту запись редактировать нельзя!");
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                f7 = new Form7_DeleteZapis(this, dataGridView1, dataGridView1.SelectedCells[0].RowIndex);
                f7.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Нет записей!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            f8 = new Form8_AddPreparat(this);
            f8.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f9 = new Form9_DeletePrepapat(this);
            f9.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f10 = new Form10_AddPostavschik(this);
            f10.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            f11 = new Form11_DeletePostavschik(this);
            f11.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            f12 = new Form12_AddIzgotovitel(this);
            f12.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            f13 = new Form13_DeleteIzgotovitel(this);
            f13.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            f14 = new Form14_AddPeremeschenie(this);
            f14.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            f15 = new Form15_DeletePeremeschenie(this);
            f15.ShowDialog();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process SysInfo = new Process();
                SysInfo.StartInfo.ErrorDialog = true;
                SysInfo.StartInfo.FileName = "help.chm";
                SysInfo.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            f16 = new Form16_OtOSrokeGodnosti(this);
            f16.ShowDialog();
        }

        private void оНаличииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
        //Процедура для создания, прорисовки и вывода данных в Excel
        private void ExportToExcel()
        {
            int count = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)  
                if (int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString())>0)
                { count++; }
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
                SetBorderStyle("A4:L4", 1);
                workSheet.Cells[1, 1] = "Отчет";
                workSheet.Cells[2, 1] = "наличия лекарственных средств на " + DateTime.Now.ToShortDateString() + " года.";
                workSheet.Cells[4, 1] = "№";
                workSheet.Cells[4, 2] = "Наименование";
                workSheet.Cells[4, 3] = "Фирма-поставщик";
                workSheet.Cells[4, 4] = "Назв. документа";
                workSheet.Cells[4, 5] = "Фирма-изготовитель";
                workSheet.Cells[4, 6] = "Серия препарата";
                workSheet.Cells[4, 7] = "Дата получ.";
                workSheet.Cells[4, 8] = "Срок годн.";
                workSheet.Cells[4, 9] = "Ед. измерения";
                workSheet.Cells[4, 10] = "Колич.";
                workSheet.Cells[4, 11] = "Цена за ед.";
                workSheet.Cells[4, 12] = "Общая сумма";
                workSheet.Cells[count + 5, 9] = "ИТОГО:";
                workSheet.Cells[count + 5, 9].EntireRow.Font.Bold = true;
                SetBorderStyle("I" + (count + 5).ToString() + ":L" + (count + 5).ToString(), 1);
                SetColumnWidth("A1", 3);
                SetColumnWidth("B1", 32);
                SetColumnWidth("C1", 11);
                SetColumnWidth("D1", 11);
                SetColumnWidth("E1", 14);
                SetColumnWidth("F1", 7);
                SetColumnWidth("G1", 12);
                SetColumnWidth("H1", 13);
                SetColumnWidth("I1", 13);
                SetColumnWidth("J1", 13);
                SetColumnWidth("K1", 13);
                SetColumnWidth("L1", 13);

                int rowExcel = 5;
                int col = 0;
                int sum = 0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                        SetBorderStyle("A" + (i + 5).ToString() + ":L" + (i + 5).ToString(), 1);
                        workSheet.Cells[rowExcel, "A"] = dataGridView1.Rows[i].Cells[11].Value;
                        workSheet.Cells[rowExcel, "B"] = dataGridView1.Rows[i].Cells[0].Value;
                        workSheet.Cells[rowExcel, "C"] = dataGridView1.Rows[i].Cells[2].Value;
                        workSheet.Cells[rowExcel, "D"] = dataGridView1.Rows[i].Cells[3].Value;
                        workSheet.Cells[rowExcel, "E"] = dataGridView1.Rows[i].Cells[4].Value;
                        workSheet.Cells[rowExcel, "F"] = dataGridView1.Rows[i].Cells[5].Value;
                        workSheet.Cells[rowExcel, "G"] = dataGridView1.Rows[i].Cells[1].Value;
                        workSheet.Cells[rowExcel, "H"] = dataGridView1.Rows[i].Cells[10].Value;
                        workSheet.Cells[rowExcel, "I"] = dataGridView1.Rows[i].Cells[6].Value;
                        workSheet.Cells[rowExcel, "J"] = dataGridView1.Rows[i].Cells[7].Value;
                        workSheet.Cells[rowExcel, "K"] = dataGridView1.Rows[i].Cells[8].Value;
                        workSheet.Cells[rowExcel, "L"] = dataGridView1.Rows[i].Cells[9].Value;
                        ++rowExcel;
                        col = col + int.Parse(dataGridView1.Rows[i].Cells[7].Value.ToString());
                        sum = sum + int.Parse(dataGridView1.Rows[i].Cells[9].Value.ToString());
                }
                workSheet.Cells[count + 5, 10] = col.ToString();
                workSheet.Cells[count + 5, 12] = sum.ToString();
                workSheet.Cells[count + 5, 10].EntireRow.Font.Bold = true;
                workSheet.Cells[count + 5, 12].EntireRow.Font.Bold = true;
            }
            else
            { MessageBox.Show("Лекарственных средств нет в наличии!"); }
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

        private void button14_Click(object sender, EventArgs e)
        {
            ExportToExcel();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            f17 = new Form17_OtORashodMed(this);
            f17.ShowDialog();

        }

        private void button16_Click(object sender, EventArgs e)
        {
            f18 = new Form18_OtoRashodeMedSDate(this);
            f18.ShowDialog();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            f19 = new Form19_OtOPriobretenii(this);
            f19.ShowDialog();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            f20 = new Form20OtPoVsemOtdeleniam(this);
            f20.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            f21 = new Form21OtPoOdnomuOtdeleniu(this, f4);
            f21.ShowDialog();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            f22 = new Form22_OtODvij(this);
            f22.ShowDialog();
        }
    }
}
