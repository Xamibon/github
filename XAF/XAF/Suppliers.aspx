<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="XAF.Suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function CreareSupplier_onclick() {
            window.location = "CreateSupplier.aspx";
        }

        function SearchSupplier_onclick() {
            window.location = "SearchSupplier.aspx";
        }

// ]]>
    </script>
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
                <input id="CreareSupplier" type="button" value="Opret leverandør" onclick="return CreareSupplier_onclick()" />
            </td>
            <td>
                <input id="SearchSupplier" type="button" value="Søg leverandør" onclick="return SearchSupplier_onclick()" />
            </td>
        </tr>
    </table>
</asp:Content>
