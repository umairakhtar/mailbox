<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Compose.aspx.cs" Inherits="WebApplication1.Compose" %>

<asp:Content ContentPlaceHolderID="head" runat="server" ID="C1">
    <style type="text/css">
        .auto-style12 {
            height: 32px;
        }
    </style>
    </asp:Content>
    <asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="C2">
        <table style="height: 357px; width: 542px">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="To"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtTo" runat="server" Width="417px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Subject"></asp:Label></td>
            <td>
                <asp:TextBox ID="txtSub" runat="server" Width="415px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Message</td>
            <td>
                <asp:TextBox ID="txtMsg" runat="server" Height="145px" Width="416px"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnSend" runat="server" Text="SEND" OnClick="btnSend_Click" />&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Cancel" Height="25px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style12"></td>
            <td class="auto-style12">
                &nbsp;</td>
        </tr>
    </table>
     </asp:Content>