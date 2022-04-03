using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Client_App
{
    public partial class UpdateSupplierDetail : System.Web.UI.Page
    {
        ServiceReference1.Supplier supplier = new ServiceReference1.Supplier();
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                SetPanel(true, false);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                supplier.SupplierID = txtSearch.Text.Trim();
                ds = new DataSet();
                ds = client.SearchSupplierRecord(supplier);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblSupplierID.Text = ds.Tables[0].Rows[0]["SupplierID"].ToString();
                    txtSupplierName.Text = ds.Tables[0].Rows[0]["SupplierName"].ToString();
                    txtProductSupplied.Text = ds.Tables[0].Rows[0]["ProductSupplied"].ToString();
                    txtProductCategory.Text = ds.Tables[0].Rows[0]["ProductCategory"].ToString();
                    txtSuppliedQuantity.Text = ds.Tables[0].Rows[0]["SuppliedQuantity"].ToString();
                    txtSellPrice.Text = ds.Tables[0].Rows[0]["SellPrice"].ToString();
                    SetPanel(false, true);
                }
                else
                {
                    lblSearchResult.Text = "Please Enter valid Supplier ID";
                    lblSearchResult.ForeColor = System.Drawing.Color.White;
                }
            }
            else
            {
                lblSearchResult.Text = "Please Enter  Supplier ID";
            }
        }

        protected void bntUpdated_Click(object sender, EventArgs e)
        {
            supplier.SupplierID = lblSupplierID.Text.Trim();
            supplier.SupplierName = txtSupplierName.Text;
            supplier.ProductSupplied = txtProductSupplied.Text;
            supplier.ProductCategory = txtProductCategory.Text;
            supplier.SuppliedQuantity = txtSuppliedQuantity.Text;
            supplier.SellPrice = txtSellPrice.Text;


            string result = client.UpdateSupplierDetails(supplier);
            lblSearchResult.Text = result;
            SetPanel(true, false);
            txtSupplierName.Text = "";
            txtProductSupplied.Text = "";
            txtProductCategory.Text = "";
            txtSuppliedQuantity.Text = "";
            txtSuppliedQuantity.Text = "";
            txtSellPrice.Text = "";
            lblSupplierID.Text = "";
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            SetPanel(true, false);
            lblMsg.Text = "";
        }
        private void SetPanel(bool pSearch, bool pUpdate)
        {
            panSearch.Visible = pSearch;
            panUpdate.Visible = pUpdate;
        }
    }
}