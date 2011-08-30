<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="XAF.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Håndter brugere</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <asp:Button id="btnCreateUser" text="Opret bruger" runat="server" 
                    onclick="btnCreateUser_Click" />
            </td>
            <td>
                <asp:Button id="btnSearchUser" text="Søg bruger" runat="server" 
                    onclick="btnSearchUser_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
