<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteItem.aspx.cs" Inherits="XAF.DeleteItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Slet artikel</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Artikel nummer:</td>
                        <td><asp:Textbox id="txtItemID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnDeleteItem" text="Slet" runat="server" onclick="btnDeleteItem_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
