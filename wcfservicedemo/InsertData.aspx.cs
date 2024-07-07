using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WcfServiceDemo;

namespace WcfServiceDemo
{
    public partial class InsertData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // 設置各個 TextBox 的預設值
                txtOffice.Text = "TW";
                txtOrderNo.Text = "TS2250519";
                txtReqDate.Text = "2022/05/19";
                txtItem.Text = "TS500GSSD220Q";
                txtCompany.Text = "YIZHENZHANG Company"; // 如果有公司名稱，這裡設置
                txtSaleQ4.Text = "0";
                txtSaleQ3.Text = "0";
                txtSaleQ2.Text = "0";
                txtSaleQ1.Text = "0";
                txtCurrency.Text = "NTD";
                txtPrice.Text = "300";
                txtMSP.Text = "250.5";
            }

        }
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                CompositeType composite = new CompositeType();

                // 驗證輸入
                if (string.IsNullOrEmpty(txtOffice.Text))
                {
                    lblMessage.Text = "Office不能為空";
                    return;
                }
                composite.office = txtOffice.Text;

                if (string.IsNullOrEmpty(txtItem.Text))
                {
                    lblMessage.Text = "Item不能為空";
                    return;
                }
                composite.item = txtItem.Text;

                if (string.IsNullOrEmpty(txtCompany.Text))
                {
                    lblMessage.Text = "Company不能為空";
                    return;
                }
                composite.company = txtCompany.Text;

                if (!int.TryParse(txtSaleQ4.Text, out int saleQ4))
                {
                    lblMessage.Text = "SaleQ4應為整數";
                    return;
                }
                composite.saleQ4 = saleQ4;

                if (!int.TryParse(txtSaleQ3.Text, out int saleQ3))
                {
                    lblMessage.Text = "SaleQ3應為整數";
                    return;
                }
                composite.saleQ3 = saleQ3;

                if (!int.TryParse(txtSaleQ2.Text, out int saleQ2))
                {
                    lblMessage.Text = "SaleQ2應為整數";
                    return;
                }
                composite.saleQ2 = saleQ2;

                if (!int.TryParse(txtSaleQ1.Text, out int saleQ1))
                {
                    lblMessage.Text = "SaleQ1應為整數";
                    return;
                }
                composite.saleQ1 = saleQ1;

                if (!DateTime.TryParse(txtReqDate.Text, out DateTime reqDate))
                {
                    lblMessage.Text = "ReqDate應為日期";
                    return;
                }
                composite.reqdate = reqDate;

                if (string.IsNullOrEmpty(txtOrderNo.Text))
                {
                    lblMessage.Text = "OrderNo不能為空";
                    return;
                }
                composite.orderno = txtOrderNo.Text;
                
                if (string.IsNullOrEmpty(txtCurrency.Text))
                {
                    lblMessage.Text = "Currency不能為空";
                    return;
                }
                composite.currency = txtCurrency.Text;

                if (!decimal.TryParse(txtPrice.Text, out decimal price))
                {
                    lblMessage.Text = "Price應為小數";
                    return;
                }
                composite.price = price;

                if (!decimal.TryParse(txtMSP.Text, out decimal msp))
                {
                    lblMessage.Text = "MSP應為小數";
                    return;
                }
                composite.msp = msp;

                // 調用 WCF 服務方法
                Service1 service = new Service1();
                bool result = service.InserData(composite);

                lblMessage.Text = result ? "插入成功" : "插入失敗";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "發生錯誤：" + ex.Message;
            }
        }
    }
}


