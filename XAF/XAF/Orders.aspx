<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="XAF.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Håndter ordrer</h3>
            </td>
        </tr>
    </table>    
    <table>
        <tr>
            <td>
                <asp:Button id="btnCreateOrder" text="Opret ordre" runat="server" 
                    onclick="btnCreateOrder_Click"/>
            </td>
            <td>
                <asp:Button id="btnSearchOrder" text="Søg ordre" runat="server" 
                    onclick="btnSearchOrder_Click"/>
            </td>
        </tr>
    </table>
</asp:Content>
