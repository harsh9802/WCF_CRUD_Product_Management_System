<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="AddProduct.aspx.cs" Inherits="Product_Client_App.AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">  
  
</asp:Content>  
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
    <table style="width:100%; color:Black; font-family:Segoe UI; font-size:14px; float:left; text-align:left;">  
<tr>  
<td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" ></asp:Label></td>  
</tr>  
<tr>  
<td>Product ID</td>  
<td><asp:TextBox ID="txtProductID" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Name</td>  
<td><asp:TextBox ID="txtName" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Category</td>  
<td><asp:TextBox ID="txtCategory" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Quantity</td>  
<td><asp:TextBox ID="txtQuantity" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>  
<tr>  
<td>Price</td>  
<td><asp:TextBox ID="txtPrice" runat="server" CssClass="textBox" ></asp:TextBox></td>  
</tr>
<tr>  
<td colspan="2">  
<asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button"   
        onclick="btnSave_Click" />  
<asp:Button ID="bntReset" runat="server" Text="Reset" CssClass="button"   
        onclick="bntReset_Click" />  
</td>  
</tr>  
</tr>  
</table>  
</asp:Content>  