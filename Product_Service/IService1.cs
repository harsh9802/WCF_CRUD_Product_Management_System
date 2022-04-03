using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Product_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        string AddProduct(Product p);

        [OperationContract]
        DataSet GetProducts();

        [OperationContract]
        string DeleteProducts(Product p);

        [OperationContract]
        DataSet SearchProduct(Product p);

        [OperationContract]
        string UpdateProduct(Product p);
        // TODO: Add your service operations here

        [OperationContract]
        string AddSupplierRecord(Supplier sup);

        [OperationContract]
        DataSet GetSupplierRecords();

        [OperationContract]
        string DeleteRecords(Supplier sup);

        [OperationContract]
        DataSet SearchSupplierRecord(Supplier sup);

        [OperationContract]
        string UpdateSupplierDetails(Supplier sup);
    }

    [DataContract]
    public class Product
    {
        string Id = "";
        string Name = "";
        string Category = "";
        string Quantity = "";
        string Price = "";
        [DataMember]
        public string ProductId
        {
            get {return Id; }
            set {Id=value; }
        }
        [DataMember]
        public string ProductName
        {
            get { return Name; }
            set { Name = value; }
        }
        [DataMember]
        public string ProductCategory
        {
            get { return Category; }
            set { Category = value; }
        }
        [DataMember]
        public string ProductQuantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        [DataMember]
        public string ProductPrice
        {
            get { return Price; }
            set { Price = value; }
        }
    }

    [DataContract]
    public class Supplier
    {
        string _supplierid = "";
        string _suppliername = "";
        string _productsupplied = "";
        string _suppliedquantity = "";
        string _sellprice = "";
        string _productcategory = "";

        [DataMember]
        public string SupplierID
        {
            get { return _supplierid; }
            set { _supplierid = value; }
        }

        [DataMember]
        public string SupplierName
        {
            get { return _suppliername; }
            set { _suppliername = value; }
        }

        [DataMember]
        public string ProductSupplied
        {
            get { return _productsupplied; }
            set { _productsupplied = value; }
        }

        [DataMember]
        public string SuppliedQuantity
        {
            get { return _suppliedquantity; }
            set { _suppliedquantity = value; }
        }

        [DataMember]
        public string SellPrice
        {
            get { return _sellprice; }
            set { _sellprice = value; }
        }

        [DataMember]
        public string ProductCategory
        {
            get { return _productcategory; }
            set { _productcategory = value; }
        }
    }
    // Use a data contract as illustrated in the sample below to add composite types to service operations.

}
