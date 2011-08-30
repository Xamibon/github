<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Items.aspx.cs" Inherits="XAF.Items" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Håndter artikler</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button id="CreateItem" text="Opret artikel" runat="server" 
                    onclick="CreateItem_Click1" />
            </td>
            <td>
                <asp:Button id="SearchItem" text="Søg artikel" runat="server" />
            </td>
        </tr>
    </table>
</asp:Content>
