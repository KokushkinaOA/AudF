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
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        DataSet GetData(string value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


         [OperationContract]
         void dob_red_aud(int flag, string korp , string Nn, string po, string pl, string v_a, string vm, string spec, string nal_pr, string vis, string sh , string dl);

         [OperationContract]
         void dob_red_ob(int flag, string kor, string Nn, string n_ob, string cost , string invent_n, string d_u, string d_s, string ot_lic);
 
        [OperationContract]
         void dob_red_rem(int flag, string kor, string Nn, string n_sm, string vid_rem, string p_o, string cost, string d_n, string  d_okon);

        // TODO: Добавьте здесь операции служб
    }


    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
