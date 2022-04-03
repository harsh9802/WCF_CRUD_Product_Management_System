using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Product_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string AddProduct(Product p)
        {
            string result = "";
            try
            {
                SqlConnection con =new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                string Query = @"INSERT INTO tblProduct (ProductId,ProductName,ProductCategory,ProductQuantity,ProductPrice)  
                                               Values(@ProductId,@ProductName,@ProductCategory,@ProductQuantity,@ProductPrice)";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ProductId", p.ProductId);
                cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
                cmd.Parameters.AddWithValue("@ProductCategory", p.ProductCategory);
                cmd.Parameters.AddWithValue("@ProductQuantity", p.ProductQuantity);
                cmd.Parameters.AddWithValue("@ProductPrice", p.ProductPrice);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully !";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }
            return result;
        }
        public DataSet GetProducts()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM tblProduct";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }

            return ds;
        }
        public string DeleteProducts(Product p)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                string Query = @"DELETE FROM tblProduct WHERE ProductId=@ProductId";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@ProductId", p.ProductId);
                con.Open();
                int res = cmd.ExecuteNonQuery();
                if (res == 1)
                {
                    result = "Product Deleted Successfully!";
                }
                else
                {
                    result = "Error in deleting record";
                }
                con.Close();
                //result = "Record Deleted Successfully!";
            }
            catch(FaultException e)
            {
                result = "Error deleting record";
            }
            return result;
        }
        public DataSet SearchProduct(Product p)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM tblProduct WHERE ProductId=@ProductId";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@ProductId", p.ProductId);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error:  " + fex);
            }
            return ds;
        }
        public string UpdateProduct(Product p)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ProductDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();

            string Query = "UPDATE tblProduct SET ProductName=@ProductName,ProductCategory=@ProductCategory,ProductQuantity=@ProductQuantity,ProductPrice=@ProductPrice WHERE ProductId=@ProductId";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@ProductId", p.ProductId);
            cmd.Parameters.AddWithValue("@ProductName", p.ProductName);
            cmd.Parameters.AddWithValue("@ProductCategory", p.ProductCategory);
            cmd.Parameters.AddWithValue("@ProductQuantity", p.ProductQuantity);
            cmd.Parameters.AddWithValue("@ProductPrice", p.ProductPrice);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully !";
            con.Close();

            return result;
        }
        public string AddSupplierRecord(Supplier sup)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SupplierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();

                string Query = @"INSERT INTO tblSupplier (SupplierID,SupplierName,ProductSupplied,SuppliedQuantity,SellPrice,ProductCategory)
                                                Values(@SupplierID,@SupplierName,@ProductSupplied,@SuppliedQuantity,@SellPrice,@ProductCategory)";
                cmd = new SqlCommand(Query, con);
                cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
                cmd.Parameters.AddWithValue("@SupplierName", sup.SupplierName);
                cmd.Parameters.AddWithValue("@ProductSupplied", sup.ProductSupplied);
                cmd.Parameters.AddWithValue("@SuppliedQuantity", sup.SuppliedQuantity);
                cmd.Parameters.AddWithValue("@SellPrice", sup.SellPrice);
                cmd.Parameters.AddWithValue("@ProductCategory", sup.ProductCategory);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                result = "Record Added Successfully";
            }
            catch (FaultException fex)
            {
                result = "Error";
            }
            return result;
        }

        //Retrive Record
        public DataSet GetSupplierRecords()
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SupplierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM tblSupplier";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        //Delete Record
        public string DeleteRecords(Supplier sup)
        {
            string result = "";
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SupplierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                SqlCommand cmd = new SqlCommand();
                string Query = @"DELETE FROM tblSupplier WHERE SupplierID=@SupplierID";
                cmd = new SqlCommand(Query, con);

                cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
                con.Open();
                int res=cmd.ExecuteNonQuery();
                if(res==1)
                {
                    result = "Record Deleted Successfully!";
                }
                else
                {
                    result = "Error in deleting record";
                }
                con.Close();
            }
            catch (FaultException e)
            {
                result = "Error deleting record";
            }
            return result;
        }

        //Search Supplier Record
        public DataSet SearchSupplierRecord(Supplier sup)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SupplierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                string Query = "SELECT * FROM tblSupplier WHERE SupplierID=@SupplierID";

                SqlDataAdapter sda = new SqlDataAdapter(Query, con);
                sda.SelectCommand.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
                sda.Fill(ds);
            }
            catch (FaultException fex)
            {
                throw new FaultException<string>("Error: " + fex);
            }
            return ds;
        }

        //UPDATE RECORDS
        //Update by Phone Roll
        public string UpdateSupplierDetails(Supplier sup)
        {
            string result = "";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SupplierDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = new SqlCommand();

            string Query = "Update tblSupplier SET SupplierName=@SupplierName,ProductSupplied=@ProductSupplied,SuppliedQuantity=@SuppliedQuantity,SellPrice=@SellPrice,ProductCategory=@ProductCategory WHERE SupplierID=@SupplierID";

            cmd = new SqlCommand(Query, con);
            cmd.Parameters.AddWithValue("@SupplierID", sup.SupplierID);
            cmd.Parameters.AddWithValue("@SupplierName", sup.SupplierName);
            cmd.Parameters.AddWithValue("@ProductSupplied", sup.ProductSupplied);
            cmd.Parameters.AddWithValue("@SuppliedQuantity", sup.SuppliedQuantity);
            cmd.Parameters.AddWithValue("@SellPrice", sup.SellPrice);
            cmd.Parameters.AddWithValue("@ProductCategory", sup.ProductCategory);
            con.Open();
            cmd.ExecuteNonQuery();
            result = "Record Updated Successfully";
            con.Close();

            return result;
        }
    }
}
