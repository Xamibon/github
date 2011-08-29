<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateItem.aspx.cs" Inherits="XAF.CreateItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
<table>
        <tr>
            <td>
                <h3>Opret ny artikel</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Artikel nr.:</td>
                        <td><asp:Textbox id="txtItemID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Navn:</td>
                        <td><asp:Textbox id="txtItemName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Beskrivelse:</td>
                        <td><asp:TextBox id="txtItemDescription" runat="server" Height="128px" TextMode="MultiLine" /></td>
                    </tr>
                    <tr>
                        <td>Lager:</td>
                        <td><asp:Textbox id="txtItemStock" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Pris:</td>
                        <td><asp:Textbox id="txtItemPrice" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Leverandør:</td>
                        <td><asp:Textbox id="txtItemSupplierID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnCreateItem" text="Gem artikel" runat="server" onclick="btnCreateItem_Click" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
