using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Product_Client_App
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGridData();
            }
        }
        public void BindGridData()
        {
            DataSet ds = new DataSet();
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            ds = client.GetSupplierRecords();
            grdSupplier.DataSource = ds;
            grdSupplier.DataBind();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            ServiceReference1.Supplier supplier = new ServiceReference1.Supplier();
            supplier.SupplierID = txtsearch.Text.Trim();
            string result = client.DeleteRecords(supplier);

            if (result == "Record Deleted Successfully!")
            {
                BindGridData();
                lblSearchResult.Text = "Supplier ID: " + txtsearch.Text.Trim() + "Deleted Successfully";
            }
            else
            {
                lblSearchResult.Text = "Supplier ID: " + txtsearch.Text.Trim() + "Not Found";
            }
        }
    }
}