<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewSupplier.aspx.cs" Inherits="Product_Client_App.AddNewSupplier" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;color:black;font-family:'Segoe MDL2 Assets' 'Juice ITC'; font-size:14px;float:left;text-align:left;">
        <tr>
            <td colspan="2"><asp:Label ID="lblMsg" runat="server" Font-Size="Medium" ></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Supplier ID</td>
            <td><asp:TextBox ID="txtSupplierID" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Supplier Name</td>
            <td><asp:TextBox ID="txtSupplierName" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Product Supplied</td>
            <td><asp:TextBox ID="txtProductSupplied" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Product Catergory</td>
            <td><asp:TextBox ID="txtProductCategory" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Supplied Quantity</td>
            <td><asp:TextBox ID="txtSuppliedQuantity" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Sell Price</td>
            <td><asp:TextBox ID="txtSellPrice" runat="server" CssClass="textBox"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="button" onclick="btnSave_Click" />
                <asp:Button ID="bntReset" runat="server" Text="Reset" CssClass="button" onclick="bntReset_Click" />
            </td>
        </tr>
    </table>
</asp:Content>