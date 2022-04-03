using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Client_App
{
    public partial class UpdateProduct : System.Web.UI.Page
    {
        ServiceReference1.Product product = new ServiceReference1.Product();
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
                product.ProductId = txtSearch.Text.Trim();
                ds = new DataSet();
                ds = client.SearchProduct(product);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    lblProductID.Text = ds.Tables[0].Rows[0]["ProductID"].ToString();
                    txtName.Text = ds.Tables[0].Rows[0]["ProductName"].ToString();
                    txtCategory.Text = ds.Tables[0].Rows[0]["ProductCategory"].ToString();
                    txtQuantity.Text = ds.Tables[0].Rows[0]["ProductQuantity"].ToString();
                    txtPrice.Text = ds.Tables[0].Rows[0]["ProductPrice"].ToString();
                    SetPanel(false, true);

                }
                else
                {
                    lblSearchResult.Text = "Please Enter Valid Product ID !";
                    lblSearchResult.ForeColor = System.Drawing.Color.White;
                }

            }
            else
            {
                lblSearchResult.Text = "Please Enter Product ID !";
            }
        }

        protected void bntUpdated_Click(object sender, EventArgs e)
        {
            product.ProductId = lblProductID.Text.Trim();
            product.ProductName = txtName.Text;
            product.ProductCategory = txtCategory.Text;
            product.ProductQuantity = txtQuantity.Text;
            product.ProductPrice = txtPrice.Text;
            string result = client.UpdateProduct(product);
            lblSearchResult.Text = result;
            SetPanel(true, false);
            txtName.Text = "";
            txtCategory.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            lblProductID.Text = "";
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