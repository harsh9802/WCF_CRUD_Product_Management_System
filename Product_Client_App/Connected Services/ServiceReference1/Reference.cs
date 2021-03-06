//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Product_Client_App.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Product", Namespace="http://schemas.datacontract.org/2004/07/Product_Service")]
    [System.SerializableAttribute()]
    public partial class Product : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductQuantityField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategory {
            get {
                return this.ProductCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductCategoryField, value) != true)) {
                    this.ProductCategoryField = value;
                    this.RaisePropertyChanged("ProductCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductId {
            get {
                return this.ProductIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductIdField, value) != true)) {
                    this.ProductIdField = value;
                    this.RaisePropertyChanged("ProductId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductName {
            get {
                return this.ProductNameField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductNameField, value) != true)) {
                    this.ProductNameField = value;
                    this.RaisePropertyChanged("ProductName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductPrice {
            get {
                return this.ProductPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductPriceField, value) != true)) {
                    this.ProductPriceField = value;
                    this.RaisePropertyChanged("ProductPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductQuantity {
            get {
                return this.ProductQuantityField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductQuantityField, value) != true)) {
                    this.ProductQuantityField = value;
                    this.RaisePropertyChanged("ProductQuantity");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Supplier", Namespace="http://schemas.datacontract.org/2004/07/Product_Service")]
    [System.SerializableAttribute()]
    public partial class Supplier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductCategoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProductSuppliedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SellPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SuppliedQuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SupplierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SupplierNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductCategory {
            get {
                return this.ProductCategoryField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductCategoryField, value) != true)) {
                    this.ProductCategoryField = value;
                    this.RaisePropertyChanged("ProductCategory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ProductSupplied {
            get {
                return this.ProductSuppliedField;
            }
            set {
                if ((object.ReferenceEquals(this.ProductSuppliedField, value) != true)) {
                    this.ProductSuppliedField = value;
                    this.RaisePropertyChanged("ProductSupplied");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SellPrice {
            get {
                return this.SellPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.SellPriceField, value) != true)) {
                    this.SellPriceField = value;
                    this.RaisePropertyChanged("SellPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SuppliedQuantity {
            get {
                return this.SuppliedQuantityField;
            }
            set {
                if ((object.ReferenceEquals(this.SuppliedQuantityField, value) != true)) {
                    this.SuppliedQuantityField = value;
                    this.RaisePropertyChanged("SuppliedQuantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SupplierID {
            get {
                return this.SupplierIDField;
            }
            set {
                if ((object.ReferenceEquals(this.SupplierIDField, value) != true)) {
                    this.SupplierIDField = value;
                    this.RaisePropertyChanged("SupplierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SupplierName {
            get {
                return this.SupplierNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SupplierNameField, value) != true)) {
                    this.SupplierNameField = value;
                    this.RaisePropertyChanged("SupplierName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        string AddProduct(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddProduct", ReplyAction="http://tempuri.org/IService1/AddProductResponse")]
        System.Threading.Tasks.Task<string> AddProductAsync(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Data.DataSet GetProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetProducts", ReplyAction="http://tempuri.org/IService1/GetProductsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetProductsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProducts", ReplyAction="http://tempuri.org/IService1/DeleteProductsResponse")]
        string DeleteProducts(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteProducts", ReplyAction="http://tempuri.org/IService1/DeleteProductsResponse")]
        System.Threading.Tasks.Task<string> DeleteProductsAsync(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchProduct", ReplyAction="http://tempuri.org/IService1/SearchProductResponse")]
        System.Data.DataSet SearchProduct(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchProduct", ReplyAction="http://tempuri.org/IService1/SearchProductResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchProductAsync(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProduct", ReplyAction="http://tempuri.org/IService1/UpdateProductResponse")]
        string UpdateProduct(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateProduct", ReplyAction="http://tempuri.org/IService1/UpdateProductResponse")]
        System.Threading.Tasks.Task<string> UpdateProductAsync(Product_Client_App.ServiceReference1.Product p);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSupplierRecord", ReplyAction="http://tempuri.org/IService1/AddSupplierRecordResponse")]
        string AddSupplierRecord(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddSupplierRecord", ReplyAction="http://tempuri.org/IService1/AddSupplierRecordResponse")]
        System.Threading.Tasks.Task<string> AddSupplierRecordAsync(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSupplierRecords", ReplyAction="http://tempuri.org/IService1/GetSupplierRecordsResponse")]
        System.Data.DataSet GetSupplierRecords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetSupplierRecords", ReplyAction="http://tempuri.org/IService1/GetSupplierRecordsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetSupplierRecordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        string DeleteRecords(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRecords", ReplyAction="http://tempuri.org/IService1/DeleteRecordsResponse")]
        System.Threading.Tasks.Task<string> DeleteRecordsAsync(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSupplierRecord", ReplyAction="http://tempuri.org/IService1/SearchSupplierRecordResponse")]
        System.Data.DataSet SearchSupplierRecord(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SearchSupplierRecord", ReplyAction="http://tempuri.org/IService1/SearchSupplierRecordResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> SearchSupplierRecordAsync(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateSupplierDetails", ReplyAction="http://tempuri.org/IService1/UpdateSupplierDetailsResponse")]
        string UpdateSupplierDetails(Product_Client_App.ServiceReference1.Supplier sup);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateSupplierDetails", ReplyAction="http://tempuri.org/IService1/UpdateSupplierDetailsResponse")]
        System.Threading.Tasks.Task<string> UpdateSupplierDetailsAsync(Product_Client_App.ServiceReference1.Supplier sup);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Product_Client_App.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Product_Client_App.ServiceReference1.IService1>, Product_Client_App.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string AddProduct(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.AddProduct(p);
        }
        
        public System.Threading.Tasks.Task<string> AddProductAsync(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.AddProductAsync(p);
        }
        
        public System.Data.DataSet GetProducts() {
            return base.Channel.GetProducts();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetProductsAsync() {
            return base.Channel.GetProductsAsync();
        }
        
        public string DeleteProducts(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.DeleteProducts(p);
        }
        
        public System.Threading.Tasks.Task<string> DeleteProductsAsync(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.DeleteProductsAsync(p);
        }
        
        public System.Data.DataSet SearchProduct(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.SearchProduct(p);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchProductAsync(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.SearchProductAsync(p);
        }
        
        public string UpdateProduct(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.UpdateProduct(p);
        }
        
        public System.Threading.Tasks.Task<string> UpdateProductAsync(Product_Client_App.ServiceReference1.Product p) {
            return base.Channel.UpdateProductAsync(p);
        }
        
        public string AddSupplierRecord(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.AddSupplierRecord(sup);
        }
        
        public System.Threading.Tasks.Task<string> AddSupplierRecordAsync(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.AddSupplierRecordAsync(sup);
        }
        
        public System.Data.DataSet GetSupplierRecords() {
            return base.Channel.GetSupplierRecords();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetSupplierRecordsAsync() {
            return base.Channel.GetSupplierRecordsAsync();
        }
        
        public string DeleteRecords(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.DeleteRecords(sup);
        }
        
        public System.Threading.Tasks.Task<string> DeleteRecordsAsync(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.DeleteRecordsAsync(sup);
        }
        
        public System.Data.DataSet SearchSupplierRecord(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.SearchSupplierRecord(sup);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> SearchSupplierRecordAsync(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.SearchSupplierRecordAsync(sup);
        }
        
        public string UpdateSupplierDetails(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.UpdateSupplierDetails(sup);
        }
        
        public System.Threading.Tasks.Task<string> UpdateSupplierDetailsAsync(Product_Client_App.ServiceReference1.Supplier sup) {
            return base.Channel.UpdateSupplierDetailsAsync(sup);
        }
    }
}
