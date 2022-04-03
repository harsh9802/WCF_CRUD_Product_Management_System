using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Client_App
{
    public partial class AddProduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtProductID.Text = "";
                txtName.Text = "";
                txtCategory.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                lblMsg.Text = "";
                txtProductID.Focus();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if ((txtProductID.Text != "") || (txtName.Text != "") || (txtCategory.Text != "") || (txtQuantity.Text != "") || (txtPrice.Text != ""))
            {
                try
                {
                    ServiceReference1.Product product = new ServiceReference1.Product();
                    product.ProductId = txtProductID.Text;
                    product.ProductName = txtName.Text;
                    product.ProductCategory = txtCategory.Text;
                    product.ProductQuantity = txtQuantity.Text;
                    product.ProductPrice = txtPrice.Text;
                    ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
                    lblMsg.Text = "Product ID: " + product.ProductId + ", " + client.AddProduct(product);
                }
                catch (Exception ex)
                {
                    lblMsg.Text = "Product ID must be unique! ";
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
            txtProductID.Text = "";
            txtName.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            lblMsg.Text = "";
            txtProductID.Focus();
        }
    }
}