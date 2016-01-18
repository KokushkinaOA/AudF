using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using client.ServiceReference1;
using Excel = Microsoft.Office.Interop.Excel;

namespace client
{
    public partial class osn : Form
    {
        Service1Client client = new Service1Client();
        public osn()
        {
            InitializeComponent();
            DGW_au.DataSource = client.GetData("GetAud").Tables[0];
            DGW_ob.DataSource = client.GetData("GetOb").Tables[0];
            DGW_remont.DataSource = client.GetData("GetRem").Tables[0];
            label1.Text = "Количество записей в таблице:" + DGW_au.RowCount.ToString();
            label2.Text = "Количество записей в таблице:" + DGW_ob.RowCount.ToString();
            label3.Text = "Количество записей в таблице:" + DGW_remont.RowCount.ToString();
        }
        //добавить аудиторию
        private void dob_aud_Click(object sender, EventArgs e)
        {
            dob_aud da = new dob_aud();
            da.ShowDialog();
            DGW_au.DataSource = client.GetData("GetAud").Tables[0];
            label1.Text = "Количество записей в таблице:" + DGW_au.RowCount.ToString();
        }
        // редактирование и удаление аудитории
        private void DGW_au_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            if (DGW_au.Columns[e.ColumnIndex] == Del && currentRow >= 0)
            {
                string naud = DGW_au[2, currentRow].Value.ToString();
                string kor = DGW_au[3, currentRow].Value.ToString();
                client.dob_red_aud(2, kor, naud, "","","","","","","","","");
                DGW_au.DataSource = client.GetData("GetAud").Tables[0];
                label1.Text = "Количество записей в таблице:" + DGW_au.RowCount.ToString();
            }
            if (DGW_au.Columns[e.ColumnIndex] == redact && currentRow >= 0)
            {
                dob_aud ra = new dob_aud();
                ra.korp = DGW_au[3, currentRow].Value.ToString();
                ra.Nn = DGW_au[2, currentRow].Value.ToString();
                ra.po = DGW_au[5, currentRow].Value.ToString();
                ra.pl = DGW_au[9, currentRow].Value.ToString(); 
                ra.v_a = DGW_au[4, currentRow].Value.ToString();
                ra.vm = DGW_au[7, currentRow].Value.ToString(); 
                ra.specil = DGW_au[6, currentRow].Value.ToString();
                ra.nal_pr = DGW_au[8, currentRow].Value.ToString(); 
                ra.vis = DGW_au[10, currentRow].Value.ToString();
                ra.shi = DGW_au[11, currentRow].Value.ToString(); ;
                ra.dli = DGW_au[12, currentRow].Value.ToString(); ;
                ra.flag = 0;
                ra.ShowDialog();
                DGW_au.DataSource = client.GetData("GetAud").Tables[0];
                label1.Text = "Количество записей в таблице:" + DGW_au.RowCount.ToString();
            }
            
        }

        //добавить оборудование
        private void add_ob_Click(object sender, EventArgs e)
        {
            dob_ob dOb = new dob_ob();
            dOb.ShowDialog();
            DGW_ob.DataSource = client.GetData("GetOb").Tables[0];
            label2.Text = "Количество записей в таблице:" + DGW_ob.RowCount.ToString();
        }

        private void osn_Load(object sender, EventArgs e)
        {

        }

        private void DGW_ob_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            if (DGW_ob.Columns[e.ColumnIndex] == del_ob && currentRow >= 0)
            {
                string i_n = DGW_ob[4, currentRow].Value.ToString();
                client.dob_red_ob(2, "", "", "", "", i_n, "", "","");
                DGW_ob.DataSource = client.GetData("GetOb").Tables[0];
                label2.Text = "Количество записей в таблице:" + DGW_ob.RowCount.ToString();
            }
            if (DGW_ob.Columns[e.ColumnIndex] == redact_ob && currentRow >= 0)
            {
                dob_ob ro = new dob_ob();
                ro.nom_a = DGW_ob[2, currentRow].Value.ToString();
                ro.kor = DGW_ob[3, currentRow].Value.ToString();
                ro.invent_n = DGW_ob[4, currentRow].Value.ToString();
                ro.n_ob = DGW_ob[5, currentRow].Value.ToString();
                ro.cost = DGW_ob[6, currentRow].Value.ToString();
                ro.ot_lic = DGW_ob[7, currentRow].Value.ToString();
                ro.d_u = DGW_ob[8, currentRow].Value.ToString();
                ro.d_s = DGW_ob[9, currentRow].Value.ToString();
                ro.flag = 0;
                ro.ShowDialog();
                DGW_ob.DataSource = client.GetData("GetOb").Tables[0];
                label2.Text = "Количество записей в таблице:" + DGW_ob.RowCount.ToString();
            }
        }

        private void add_rem_Click(object sender, EventArgs e)
        {
            dob_rem dr = new dob_rem();
            dr.ShowDialog();
            DGW_remont.DataSource = client.GetData("GetRem").Tables[0];
            label3.Text = "Количество записей в таблице:" + DGW_remont.RowCount.ToString();
        }

        private void DGW_remont_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRow = int.Parse(e.RowIndex.ToString());
            if (DGW_remont.Columns[e.ColumnIndex] == del_rem && currentRow >= 0)
            {
                string n_s = DGW_remont[4, currentRow].Value.ToString();
                client.dob_red_rem(2, "", "", "", "", n_s, "", "", "");
                DGW_remont.DataSource = client.GetData("GetRem").Tables[0];
                label3.Text = "Количество записей в таблице:" + DGW_remont.RowCount.ToString();
            }
            if (DGW_remont.Columns[e.ColumnIndex] == redact_rem && currentRow >= 0)
            {
                dob_rem rr = new dob_rem();
                rr.nomer_a = DGW_remont[2, currentRow].Value.ToString();
                rr.kor = DGW_remont[3, currentRow].Value.ToString();
                rr.n_sm = DGW_remont[4, currentRow].Value.ToString();
                rr.vid_rem = DGW_remont[5, currentRow].Value.ToString();
                rr.p_org = DGW_remont[6, currentRow].Value.ToString();
                rr.stoimos = DGW_remont[7, currentRow].Value.ToString();
                rr.d_n = DGW_remont[8, currentRow].Value.ToString();
                rr.d_okon = DGW_remont[9, currentRow].Value.ToString();
                rr.flag = 0;
                rr.ShowDialog();
                DGW_remont.DataSource = client.GetData("GetRem").Tables[0];
                label3.Text = "Количество записей в таблице:" + DGW_remont.RowCount.ToString();
            }
        }

        private void Postroenie_otcheta_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            if (tip_diagrammi.Text == "Круговая" || tip_diagrammi.Text == "")
            {

                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
                chart1.Legends.Add("");
            }
            else
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chart1.Legends.Clear();

            }
            dGV_otchet.DataSource = client.GetData(kriterii_otcheta.Text).Tables[0];

            for (int i = 0; i < dGV_otchet.RowCount; i++)
            {
                chart1.Series[0].Points.Add(Convert.ToDouble(dGV_otchet[1, i].Value)).AxisLabel = Convert.ToString(dGV_otchet[0, i].Value);

            }
        }

        private void exp_aud_Click(object sender, EventArgs e)
        {
            excel(DGW_au);
        }

        private void excel( DataGridView dgw)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            int i = 0;
            int j = 0;
            for (int k = 2; k <= dgw.ColumnCount - 1; k++)
                xlWorkSheet.Cells[1, k - 1] = dgw.Columns[k].HeaderText;
            for (i = 0; i <= dgw.RowCount - 1; i++)
            {
                for (j = 2; j <= dgw.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dgw[j, i];
                    xlWorkSheet.Cells[i + 2, j - 1] = cell.FormattedValue;
                }
            }
            saveExcel.Title = "Сохранение документа";
            saveExcel.Filter = "Книга Excel|*.xls";
            if (saveExcel.ShowDialog() != DialogResult.OK) return;
            string put = saveExcel.FileName;
            xlWorkBook.SaveAs(put, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();
            System.Diagnostics.Process.Start(put);
        }

        private void exp_ob_Click(object sender, EventArgs e)
        {
            excel(DGW_ob);
        }

        private void exp_rem_Click(object sender, EventArgs e)
        {
            excel(DGW_remont);
        }


    }
}
