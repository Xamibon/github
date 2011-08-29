<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateUser.aspx.cs" Inherits="XAF.CreateUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Opret ny bruger</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Fornavn:</td>
                        <td><asp:Textbox id="txtFirstName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td>Efternavn:</td>
                        <td><asp:Textbox id="txtLastName" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnAddUser" text="Opret" runat="server" onclick="btnAddUser_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
