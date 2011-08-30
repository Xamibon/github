<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="XAF.Suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Håndter leverandører</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button id="btnCreateSupplier" text="Opret leverandør" runat="server" 
                    onclick="btnCreateSupplier_Click" />
            </td>
            <td>
                <asp:Button id="btnSearchSupplier" text="Søg leverandør" runat="server" 
                    onclick="btnSearchSupplier_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
