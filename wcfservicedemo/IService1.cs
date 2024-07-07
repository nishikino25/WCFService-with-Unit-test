using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemo
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IService1"。
    [ServiceContract]
    public interface IService1
    {
        //取得訂單的商品清單
        [OperationContract]
        List<string> GetData(string orderno);
        //新增訂單
        [OperationContract]
        bool InserData(CompositeType composite);
    }


    //使用下列範例中所示的資料合約，新增複合型別至服務作業。
    [DataContract]
    public class CompositeType
    {
        string _office = string.Empty;
        string _item = string.Empty;
        string _company = string.Empty;
        int _saleQ4 = 0;
        int _saleQ3 = 0;
        int _saleQ2 = 0;
        int _saleQ1 = 0;
        DateTime _reqdate = DateTime.Now;
        string _orderno = string.Empty;
        string _currency = string.Empty;
        decimal _price = 0;
        decimal _msp = 0;

        [DataMember]
        public string office
        {
            get { return _office; }
            set { _office = value; }
        }
        [DataMember]
        public string item
        { 
            get { return _item; }
            set { _item = value; }
        }
        [DataMember]
        public string company
        {
            get { return _company; }
            set { _company = value; }
        }
        [DataMember]
        public int saleQ4
        {
            get { return _saleQ4; }
            set { _saleQ4 = value; }
        }
        [DataMember]
        public int saleQ3
        {
            get { return _saleQ3; }
            set { _saleQ3 = value; }
        }
        [DataMember]
        public int saleQ2
        {
            get { return _saleQ2; }
            set { _saleQ2 = value; }
        }
        [DataMember]
        public int saleQ1
        {
            get { return _saleQ1; }
            set { _saleQ1 = value; }
        }
        [DataMember]
        public DateTime reqdate
        {
            get { return _reqdate; }
            set { _reqdate = value; }
        }
        [DataMember]
        public string orderno
        {
            get { return _orderno; }
            set { _orderno = value; }
        }
        [DataMember]
        public string currency
        {
            get { return _currency; }
            set { _currency = value; }
        }
        [DataMember]
        public decimal price
        {
            get { return _price; }
            set { _price = value; }
        }
        [DataMember]
        public decimal msp
        {
            get { return _msp; }
            set { _msp = value; }
        }
    }
}
