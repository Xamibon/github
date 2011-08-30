<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateSupplier.aspx.cs" Inherits="XAF.CreateSupplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Opret ny leverandør</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Firmanavn:</td>
                        <td><asp:Textbox id="txtSupplierName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>SE/CVR nr.:</td>
                        <td><asp:Textbox id="txtSupplierSE" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnAddSupplier" text="Opret" runat="server" onclick="btnAddSupplier_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
