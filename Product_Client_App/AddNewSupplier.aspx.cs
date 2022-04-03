using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Client_App
{
    public partial class AddNewSupplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtSupplierID.Text = "";
                txtSupplierName.Text = "";
                txtProductSupplied.Text = "";
                txtSuppliedQuantity.Text = "";
                txtSellPrice.Text = "";
                txtProductCategory.Text = "";
                lblMsg.Text = "";
                txtSupplierID.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtSupplierID.Text != "") || (txtSupplierName.Text != "") || (txtProductSupplied.Text != "") || (txtSuppliedQuantity.Text != ""))
            {
                try
                {
                    ServiceReference1.Supplier supplier = new ServiceReference1.Supplier();
                    supplier.SupplierID = txtSupplierID.Text;
                    supplier.SupplierName = txtSupplierName.Text;
                    supplier.ProductSupplied = txtProductSupplied.Text;
                    supplier.ProductCategory = txtProductCategory.Text;
                    supplier.SuppliedQuantity = txtSuppliedQuantity.Text;
                    supplier.SellPrice = txtSellPrice.Text;

                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    lblMsg.Text = "Supplier ID: " + supplier.SupplierID + ", " + client.AddSupplierRecord(supplier);
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Supplier ID must be unique ";
                }
            }
            else
            {
                lblMsg.Text = "All fields are mandatory! ";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void bntReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            txtSupplierID.Text = "";
            txtSupplierName.Text = "";
            txtProductSupplied.Text = "";
            txtProductCategory.Text = "";
            txtSuppliedQuantity.Text = "";
            txtSellPrice.Text = "";
            lblMsg.Text = "";
            txtSupplierID.Focus();
        }
    }
}