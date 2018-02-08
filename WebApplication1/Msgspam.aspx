
<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Msgspam.aspx.cs" Inherits="WebApplication1.Msgspam" %>

<asp:Content ContentPlaceHolderID="head" runat="server" ID="C1">
    <style type="text/css">
        .auto-style13 {
            height: 46px;
        }
        .auto-style14 {
            width: 485px;
            height: 46px;
        }
        .auto-style15 {
            height: 53px;
        }
        .auto-style16 {
            width: 485px;
            height: 53px;
        }
        .auto-style17 {
            height: 214px;
        }
        .auto-style18 {
            width: 485px;
            height: 214px;
        }
        .auto-style19 {
            height: 57px;
        }
        .auto-style20 {
            width: 485px;
            height: 57px;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="C2">
    <div style="height: 428px; width: 537px">
        <br />
     <table border="1">
        <tr>
            <td class="auto-style13">
                <b>From</b>
            </td>
            <td class="auto-style14">
                <asp:Label ID="lblFrom" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td class="auto-style15">
                <b>Subject</b>
            </td>
            <td class="auto-style16">
                <asp:Label ID="lblSub" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style17">
                <b>Message</b>
            </td>
            <td class="auto-style18">
                <asp:Label ID="lblMsg" runat="server"></asp:Label>
            </td>
        </tr>
         <tr>
            <td class="auto-style19">
                <b>Time</b>
            </td>
            <td class="auto-style20">
                <asp:Label ID="lblTime" runat="server"></asp:Label>
            </td>
        </tr>
    </table>
        
    </div>  
   

</asp:Content>

