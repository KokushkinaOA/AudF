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
    public partial class dob_rem : Form
    {
        Service1Client client = new Service1Client();
        public string kor = "", nomer_a = "", n_sm = "", vid_rem = "", p_org = "", stoimos = "", d_n = "", d_okon = "";
        public int flag = 1;
        int a;
        float aa;
        public dob_rem()
        {
            InitializeComponent();
            vid_remonta.DataSource = client.GetData("GetV_r").Tables[0];
            Podradnai.DataSource = client.GetData("GetP_org").Tables[0];
        }

        private void dob_rem_Load(object sender, EventArgs e)
        {
            if (flag == 0)
                this.Text = "Редактирование данных";
            else this.Text = "Добавление плана ремонта";

            ko.Text = kor;
            N_a.Text = nomer_a;
            N_smeti.Text = n_sm;
            vid_remonta.Text = vid_rem;
            Podradnai.Text = p_org;
            stoim.Text = stoimos;
            dateNachala.Value = DateTime.Parse(d_n);
            dateOkonchania.Value = DateTime.Parse(d_okon);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ko.Text == "" || N_a.Text == "" || N_smeti.Text == "")
                MessageBox.Show("Заполните обязательные поля, выделенные жёлтым цветом");
            else
                if (int.TryParse(N_a.Text, out a) == false)
                    MessageBox.Show("Неверно введен номер аудитории, введите целое число");
                else if (int.TryParse(N_smeti.Text, out a) == false)
                    MessageBox.Show("Неверно введён номер сметы, введите целое число");
                else if (float.TryParse(stoim.Text.Replace(".", ","), out aa) == false)
                    MessageBox.Show("Неверно введена стоимость, ");
                else
                {
                    if (vid_remonta.SelectedValue == null)
                        vid_rem = "NULL";
                    else vid_rem = vid_remonta.SelectedValue.ToString();
                    if (Podradnai.SelectedValue == null)
                        p_org = "NULL";
                    else p_org = Podradnai.SelectedValue.ToString();
                    client.dob_red_rem(flag, ko.Text, N_a.Text, N_smeti.Text, vid_rem, p_org, stoim.Text.Replace(",", "."), dateNachala.Value.ToShortDateString(), dateOkonchania.Value.ToShortDateString());
                    this.Close();
                }
        }

        private void otm_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
