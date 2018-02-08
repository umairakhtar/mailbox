<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="DraftsForm.aspx.cs" Inherits="WebApplication1.DraftsForm" %>

<asp:Content ContentPlaceHolderID="head" runat="server" ID="C1"></asp:Content>
    <asp:Content ContentPlaceHolderID="ContentPlaceHolder1" runat="server" ID="C2">
        <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White"
    RowStyle-BackColor="#A1DCF2" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"
    runat="server" AutoGenerateColumns="false">
    <Columns>
        <asp:BoundField DataField="ToUser" HeaderText="From" ItemStyle-Width="30" />        
         <asp:BoundField DataField="MessageSubject" HeaderText="Subject" ItemStyle-Width="30" />           
        <asp:TemplateField HeaderText="Message">
            <ItemTemplate>
                <div style="overflow:hidden;text-overflow:ellipsis;white-space:nowrap;width:100px">
                    <asp:Label ID="lblMsg" runat="server" Text='<%# Bind("InboxMessage") %>' ToolTip='<%# Bind("InboxMessage") %>'></asp:Label>
                </div>
            </ItemTemplate>
            <HeaderStyle Wrap="false" Width="100" HorizontalAlign="Left" />
            <ItemStyle Wrap="false" Width="100" />
        </asp:TemplateField>
        
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lnkDetails" runat="server" Text="Open Message" PostBackUrl='<%# "~/Compose.aspx?RowIndex=" + Container.DataItemIndex+"?Index=" +1%>'></asp:LinkButton>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
