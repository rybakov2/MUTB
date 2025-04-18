<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="MUTB.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table style="width: 100%;">
        <tr>
            <td style="text-align:right">&nbsp;
                <asp:Label ID="lblDate" Text="" Font-Bold="true" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
        <tr>
            <td style="align-content:start">&nbsp;
                <asp:Label ID="lblRefDate" Text="Ref. Date: " Font-Bold="true" runat="server"></asp:Label>&nbsp;&nbsp;
                <asp:TextBox ID="txtRefDate" TextMode="Date" ReadOnly="false" runat="server"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnLoad" Text="Load" OnClick="btnLoad_Click" width="200px" runat="server" />&nbsp;&nbsp;&nbsp;&nbsp;
                
            </td>
        </tr>
        <tr>
            <td>&nbsp;
                <asp:GridView ID="GridView1" Visible="true" runat="server"></asp:GridView>
            </td>
        </tr>
        <tr>
            <td style="text-align:left">&nbsp;
                <asp:Label ID="lblOut" Text="" runat="server"></asp:Label>
                <br />
            </td>
        </tr>
    </table>

    <br />
    <br />

</asp:Content>
