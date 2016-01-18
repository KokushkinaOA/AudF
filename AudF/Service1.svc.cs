using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace AudF
{

    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Service1 : IService1
    {
        SqlConnection connect = new SqlConnection("Persist Security Info=false;Server=.;database=AuditFond;Integrated Security=SSPI;");
        DataSet ds = new DataSet();
        SqlDataAdapter add;
        SqlCommandBuilder comb;
        SqlCommand com;
        string query, sel;
        public DataSet GetData(string value)
        {
            connect.Open();
            switch (value)
            {
                case "GetAud": sel = "Select N_auditorii AS '№ аудитории ', Korpus AS 'Корпус', Vid_auditorii.Nazvanie AS'Тип аудитории', Podrazdelenie.Nazvanie AS 'Подразделение', Cpecializacia AS 'Специализация', Vmesimost AS 'Вместимость', Nalichie_proectora AS 'Наличие проектора', Ploschad AS 'Площадь', Visota AS 'Высота', Shirina AS 'Ширина', Dlina AS 'Длина' From Pasport_auditorii Left join Vid_auditorii ON Pasport_auditorii.ID_auditorii = Vid_auditorii.ID_auditorii  Left Join Podrazdelenie ON Pasport_auditorii.ID_podrazdelenia = Podrazdelenie.ID_podrazdelenia"; break;
                case "GetOb": sel = "Select N_auditorii AS '№ аудитории', Korpus AS 'Корпус', Inventarnii_nomer AS 'Инвентарный номер', Tip_oborudovania.Nazvanie AS 'Название', Stoimost_oborudovania AS 'Стоимость', chel.FIO AS 'Ответственное лицо',  Data_ustonovki AS 'Дата установки' , Data_spisania AS 'Дата списания' From Uchet_oborudovania Left Join Tip_oborudovania ON Uchet_oborudovania.ID_oborudovania = Tip_oborudovania.ID_oborudovania Left Join chel ON Uchet_oborudovania.Id_chela = chel.Id_chela"; break;
                case "GetRem": sel= "Select N_auditorii AS '№ аудитории', Korpus AS 'Корпус', N_smeti AS '№ сметы', Vid_remota.Nazvanie_remonta AS 'Вид ремонта', P_org.Название AS 'Подрядная организация', Stoimost AS 'Стоимость', Data_nachala AS 'Дата начала', Data_okonchania AS 'Дата окончания' From Plan_remonta Left Join Vid_remota ON Plan_remonta.ID_remonta = Vid_remota.ID_remonta Left join P_org ON Plan_remonta.Id_org = P_org.Id_org"; break;
                case "GetV_a": sel = "Select * From Vid_auditorii"; break;
                case "GetPodr": sel= "Select * From Podrazdelenie"; break;
                case "GetO_l": sel = "Select * From chel"; break;
                case "GetN_ob": sel = "Select * From Tip_oborudovania"; break;
                case "GetV_r": sel = "Select * From Vid_remota"; break;
                case "GetP_org": sel = "Select * From P_org"; break;
                case "Подразделение": sel = "SELECT Podrazdelenie.Nazvanie AS 'Название', SUM (Ploschad) AS 'Общая площадь', COUNT (*) AS 'Количество' FROM Pasport_auditorii, Podrazdelenie Where Pasport_auditorii.ID_podrazdelenia=Podrazdelenie.ID_podrazdelenia GROUP BY Podrazdelenie.Nazvanie";
                    break;
                case "Оборудование": sel = "SELECT Tip_oborudovania.Nazvanie AS 'Название оборудования', COUNT (*) AS 'Количество', SUM (Stoimost_oborudovania) AS 'Общая стоимость' FROM Uchet_oborudovania, Tip_oborudovania Where Uchet_oborudovania.ID_oborudovania=Tip_oborudovania.ID_oborudovania GROUP BY Tip_oborudovania.Nazvanie";
                    break;
                case "Ответственное лицо": sel = "SELECT Chel.FIO AS 'ФИО', COUNT (*) AS 'Количество аудиторий', SUM (kol) AS 'Колличество оборудования' FROM Uchet_oborudovania, chel  Where Uchet_oborudovania.Id_chela=chel.Id_chela GROUP BY Chel.FIO";
                    break;
                case "Подрядная организация": sel = "SELECT P_org.Название AS 'Подрядная организация', COUNT (*) AS 'Количество аудиторий', SUM (Stoimost) AS 'Общая стоимость' FROM Plan_remonta, P_org  Where Plan_remonta.Id_org=P_org.Id_org GROUP BY P_org.Название";
                    break;
           
            }
            add = new SqlDataAdapter(sel, connect);
            comb = new SqlCommandBuilder(add);
            add.Fill(ds);
            connect.Close();
            return ds;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
  
        public void dob_red_aud(int flag, string korp , string Nn, string po, string pl, string v_a, string vm, string spec, string nal_pr, string vis, string sh , string dl)
        {

            connect.Open();
            switch (flag)
            {
                case 0: query = "UPDATE Pasport_auditorii SET Korpus ='" + korp + "', N_auditorii = '" + Nn +
                        "' , ID_podrazdelenia = " + po + ", ID_auditorii = " + v_a +
                        ", Cpecializacia = '" + spec + "', Ploschad = '" + pl +
                        "', Dlina = '" + dl + "', Nalichie_proectora = '" + nal_pr + "', Shirina = '" + sh +
                        "', Sposob_ohrani = ' " + "', Visota = " + vis +
                        " , Vmesimost = '" + vm + "' where  Korpus = '" + korp + "' AND N_auditorii = '" + Nn + "'" ; break;
                case 1: query = "INSERT INTO Pasport_auditorii (Korpus, N_auditorii, ID_podrazdelenia, ID_auditorii, Cpecializacia, Ploschad,Dlina, Nalichie_proectora, Shirina, Sposob_ohrani, Visota, Vmesimost) VALUES ('" + korp + "', '"
                       + Nn + "' ,  " + po + ", " + v_a +
                    ", '" + spec + "', '" + pl +
                    "', '" + dl + "', '" + nal_pr + "', '" + sh +
                    "', ' ', '" + vis +
                    "' ,  '" + vm + "')"; break;
                case 2: query = "DELETE Pasport_auditorii WHERE Korpus = '" + korp + "' AND N_auditorii= '" + Nn + "'"; break;
            }
            com = new SqlCommand(query, connect);
            com.ExecuteNonQuery();
            connect.Close();
        }

        public void dob_red_ob(int flag, string kor, string Nn, string n_ob, string cost, string invent_n, string d_u, string d_s, string ot_lic)
        {
             connect.Open();
            switch (flag)
            {
                case 0: query = "UPDATE uchet_oborudovania SET Korpus ='" + kor + "', N_auditorii = '" + Nn +
                        "' , Inventarnii_nomer = '" + invent_n + "', kol ='', Id_chela = " + ot_lic + " ,ID_oborudovania = " + n_ob +
                        ", Stoimost_oborudovania = '" + cost + "', Data_ustonovki = '" + d_u +
                        "', Data_spisania = '" + d_s + "' where  Korpus = '" + kor + "' AND N_auditorii = '" + Nn + "'"; break;
                case 1: query = "INSERT uchet_oborudovania (Korpus, N_auditorii, ID_oborudovania, Stoimost_oborudovania, Data_ustonovki, Data_spisania, Id_chela, kol, Inventarnii_nomer) VALUES ('"
                        + kor + "', '" + Nn + "' , " + n_ob +
                     ", '" + cost + "', '" + d_u + "', '" + d_s + "', '" + ot_lic + "' , '', '" + invent_n + "')"; break;
                case 2: query = "DELETE Uchet_oborudovania WHERE Inventarnii_nomer = '" + invent_n + "'"; ; break;
            }
            com = new SqlCommand(query, connect);
            com.ExecuteNonQuery();
            connect.Close();

        }

        public void dob_red_rem(int flag, string kor, string Nn, string n_sm, string vid_rem, string p_o, string cost, string d_n, string d_okon)
        {
            connect.Open();
            switch (flag)
            {
                case 0: query = "UPDATE plan_remonta SET Korpus ='" + kor + "', N_auditorii = '" + Nn +
                            "' , N_smeti = '" + n_sm + "', ID_remonta = '" + vid_rem + "', Id_org = '" + p_o +
                            "', Stoimost= '" + cost + "', Data_nachala = '" + d_n +
                            "', Data_okonchania = '" + d_okon + "' where  Korpus = '" + kor + "' AND N_auditorii = '" + Nn + "'"; break;
                case 1: query = "INSERT plan_remonta(N_smeti, Korpus, N_auditorii, ID_remonta, Id_org, Stoimost, Data_nachala, Data_okonchania) VALUES ('" +
                        n_sm + "','" + kor + "', '" + Nn + "', '" +
                           vid_rem + "', '" + p_o + "', '" + cost + "', '" + d_n +
                           "', '" + d_okon + "')"; break;
                case 2: query = "DELETE plan_remonta WHERE N_smeti = '" + n_sm + "'"; break;
            }
            com = new SqlCommand(query, connect);
            com.ExecuteNonQuery();
            connect.Close();
        }
    }
}
