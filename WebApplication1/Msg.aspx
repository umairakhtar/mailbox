<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Msg.aspx.cs" Inherits="WebApplication1.Msg" %>

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
        .auto-style21 {
            height: 20px;
        }
    </style>
</asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="C2">
    <div style="height: 410px; width: 495px; color: #000080;">
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
    <div>

        <table>

            <tr>
                <td class="auto-style21">
                    <asp:Button ID="Button1" runat="server" Text="MARK AS SPAM" OnClick="Button1_Click" />
                </td>
                <td class="auto-style21">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>

                 <td class="auto-style21">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="ADD TO TRASH" OnClick="Button3_Click" Height="26px" />
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
