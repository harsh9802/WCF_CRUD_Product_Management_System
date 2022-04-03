<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DisplayProducts.aspx.cs" Inherits="Product_Client_App.DisplayProducts" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
<asp:GridView ID="grdProducts" runat="server">  
       <AlternatingRowStyle BackColor="White" />  
       <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />  
</asp:GridView> 
</asp:Content>