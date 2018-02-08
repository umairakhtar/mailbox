<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Trashmsg.aspx.cs" Inherits="WebApplication1.Trashmsg" %>
<asp:Content ContentPlaceHolderID="head" runat="server" ID="C1"></asp:Content>
<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="C2">


     <div style="height: 428px; width: 537px; color: #000080;">
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
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>

                 <td>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
        </table>
    </div>
    </asp:Content>
