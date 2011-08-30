<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateOrder.aspx.cs" Inherits="XAF.CreateOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Opret ny ordre</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Ordre nr.:</td>
                        <td><asp:Label id="lblOrderID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Oprettet d.:</td>
                        <td><asp:Label id="lblCreatedDate" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Oprettet af:</td>
                        <td><asp:Label id="lblCreatedBy" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Artikel nr.:</td>
                        <td><asp:Textbox id="txtItemID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Antal:</td>
                        <td><asp:Textbox id="txtItemQty" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnAddItemToOrder" text="Tilføj" runat="server" onclick="btnAddItemToOrder_Click" />
                        <asp:button id="btnSaveOrder" text="Gem" runat="server" onclick="btnSaveOrder_Click"/></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
