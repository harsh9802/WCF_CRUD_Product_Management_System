<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplaySupplierRecord.aspx.cs" Inherits="Product_Client_App.DisplaySupplierRecord" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<asp:GridView ID="grdSupplier" runat="server">
    <AlternatingRowStyle BackColor="White" />
    <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />
</asp:GridView>
</asp:Content>