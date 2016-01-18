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
    public partial class dob_ob : Form
    {
        Service1Client client = new Service1Client();
        public string kor = "", nom_a = "", n_ob = "", cost = "", invent_n = "", d_u = "", d_s = "", kk = "", ot_lic = "";
        public int flag = 1;
        float aa;
        public dob_ob()
        {
            InitializeComponent();
            naz_ob.DataSource = client.GetData("GetN_ob").Tables[0];
            otv_l.DataSource = client.GetData("GetO_l").Tables[0];
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ko.Text == "" || N_a.Text == "" || inv_N.Text == "")
                MessageBox.Show("Заполните обязательные поля, выделенные жёлтым цветом");
            else if (float.TryParse(stoim.Text.Replace(".", ","), out aa) == false)
                MessageBox.Show("Неверно введена стоимость, введите число");

            else
            {
                if (naz_ob.SelectedValue == null)
                    n_ob = "NULL";
                else n_ob = naz_ob.SelectedValue.ToString();
                if (otv_l.SelectedValue == null)
                    ot_lic = "NULL";
                else ot_lic = otv_l.SelectedValue.ToString();
                client.dob_red_ob(flag, ko.Text, N_a.Text, n_ob, stoim.Text.Replace(",", "."), inv_N.Text, dateUst.Value.ToShortDateString(), dateSpis.Value.ToShortDateString(), ot_lic);
                this.Close();

            }
        }

        private void dob_ob_Load(object sender, EventArgs e)
        {
            if (flag == 0)
                this.Text = "Редактирование данных";
            else this.Text = "Добавление оборудования";
            ko.Text = kor;
            N_a.Text = nom_a;
            inv_N.Text = invent_n;
            otv_l.Text = ot_lic;
            naz_ob.Text = n_ob;
            stoim.Text = cost;
            dateUst.Value = DateTime.Parse(d_u);
            dateSpis.Value = DateTime.Parse(d_s);
            dateUst.MaxDate = dateSpis.Value;
            dateSpis.MinDate = dateUst.Value;
        }

        private void dateUst_MouseEnter(object sender, EventArgs e)
        {
            dateUst.MaxDate = dateSpis.Value;
        }

        private void dateSpis_MouseEnter(object sender, EventArgs e)
        {
            dateSpis.MinDate = dateUst.Value;
        }

        private void otm_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
