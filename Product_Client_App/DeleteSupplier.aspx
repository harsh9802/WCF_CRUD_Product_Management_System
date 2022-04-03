<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteSupplier.aspx.cs" Inherits="Product_Client_App.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="pansearch" runat="server" style="width:auto; color:black; font-family:Segoe UI; font-size:14px; float:left; text-align:left;padding:10px;padding-bottom:20px;">
        <tr>
            <td>Supplier ID</td>
            <td>
                <asp:TextBox ID="txtsearch" runat="server" CssClass="textbox" Placeholder="Enter Supplier ID to delete it" >
                </asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button" OnClientClick="return confirm('are you sure you want to delete?')" onclick="btnDelete_Click">
                </asp:Button>
            </td>
        </tr>
        <tr>
            <td colspan="3" ><asp:Label ID="lblSearchResult" runat="server" Font-Size="Medium" ></asp:Label>
            </td>
        </tr>
    </table>
    <hr />
    <div style="float:left" >
        <asp:GridView ID="grdSupplier" runat="server">
            <AlternatingRowStyle BackColor="White" />
            <HeaderStyle BackColor="#003300" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </div>
</asp:Content>
