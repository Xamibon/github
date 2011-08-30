<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteOrder.aspx.cs" Inherits="XAF.DeleteOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Slet ordre</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Ordre ID:</td>
                        <td><asp:Textbox id="txtOrderID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnDeleteOrder" text="Slet" runat="server" onclick="btnDeleteOrder_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
