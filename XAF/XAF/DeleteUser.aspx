<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteUser.aspx.cs" Inherits="XAF.DeleteUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <h3>Slet bruger</h3>
            </td>
        </tr>
    </table>
    <table>
        <tr>
            <td>
                <table>
                    <tr>
                        <td>Bruger ID:</td>
                        <td><asp:Textbox id="txtUserID" runat="server" /></td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                        <asp:Button id="btnDeleteUser" text="Slet" runat="server" onclick="btnDeleteUser_Click" /></td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</asp:Content>
