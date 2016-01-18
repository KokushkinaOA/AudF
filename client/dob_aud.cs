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

namespace client
{
    public partial class dob_aud : Form
    {
        Service1Client client = new Service1Client();
        public string korp = "", Nn = "", po = "", pl = "", sp_oh = "", v_a = "", vm = "", specil = "", nal_pr = "", vis = "", shi = "", dli = "";
        int a;
        public int flag = 1;
        float aa;
        public dob_aud()
        {
            InitializeComponent();
            vid_a.DataSource = client.GetData("GetV_a").Tables[0];
            podr.DataSource = client.GetData("GetPodr").Tables[0];
          
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ko.Text == "" || N_a.Text == "")
                MessageBox.Show("Заполните обязательные поля, выделенные жёлтым цветом");
            else   if (int.TryParse(Vmest.Text, out a)== false && Vmest.Text != "")
                MessageBox.Show("Неверно введена вместимость, введите целое число");
            else if ((int.TryParse(plosch.Text, out a) == false && float.TryParse(plosch.Text.Replace(".", ","), out aa) == false) && plosch.Text != "")
                MessageBox.Show("Площадь введена не верно, введите число");
            else if ((int.TryParse(sh.Text, out a) == false && float.TryParse(sh.Text.Replace(".", ","), out aa) == false) && sh.Text != "")
                MessageBox.Show("Ширина введена не верно, введите число");
            else if ((int.TryParse(dl.Text, out a)==false && float.TryParse(dl.Text.Replace(".",","), out aa)==false) && dl.Text!="")
                MessageBox.Show("Длина введена не верно, введите число");
            else if ((int.TryParse(visot.Text, out a) == false && float.TryParse(visot.Text.Replace(".", ","), out aa) == false) && visot.Text != "")
                MessageBox.Show("Высота введена не верно, введите число");
            else
            {
                pl = plosch.Text.Replace(",", ".");
                dli = dl.Text.Replace(",", ".");
                shi = sh.Text.Replace(",", ".");
                vis = visot.Text.Replace(",", ".");
                string nal_pr;
                if (podr.SelectedValue == null)
                    po = "NULL";
                else
                    po = podr.SelectedValue.ToString();
                if (vid_a.SelectedValue == null)
                    v_a = "NULL";
                else v_a = vid_a.SelectedValue.ToString();
                if (checkBox1.Checked == true)
                    nal_pr = "1";
                else
                    nal_pr = "0";
                client.dob_red_aud(flag, ko.Text, N_a.Text, po, pl, v_a, Vmest.Text, spec.Text, nal_pr, vis, shi, dli);
 
                this.Close();
            }
        }

        private void otm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dob_aud_Load(object sender, EventArgs e)
        {
            if (flag == 0)
                this.Text = "Редактирование аудитории";
            else this.Text = "Добавление аудитории";
            ko.Text = korp;
            N_a.Text = Nn;
         //   if (po == "")
          //      po = "-1";
            podr.Text = po;
            plosch.Text = pl;

           // if (v_a == "")
             //   v_a = "-1";
            vid_a.Text = v_a;
            Vmest.Text = vm;
            spec.Text = specil;
            if (nal_pr == "Есть")
                checkBox1.Checked = true;
            else checkBox1.Checked = false;
            visot.Text = vis;
            sh.Text = shi;
            dl.Text = dli;

        }


    }
}
