<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteSupplier.aspx.cs" Inherits="XAF.DeleteSupplier" %>
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
                        <td>Leverandør nummer:</td>
                        <td><asp:Textbox id="txtSupplierID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnDeleteSupplier" text="Slet" runat="server" onclick="btnDeleteSupplier_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
