<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="CartPage.aspx.cs" Inherits="CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderData" runat="server">
    <div id="CartTitles" runat="server">

        <table style="width: 100%">
            <tr>
                <td style="width: 267px">
                    <asp:Label ID="Label2" runat="server" Text="Title"></asp:Label>
                </td>
                <td style="width: 156px">
                    <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Weight"></asp:Label>
                </td>
            </tr>
        </table>

    </div>

    
    

</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BookImageHolder" runat="server">
    <asp:Label ID="lblNoCart" runat="server" Text="Cart is currently empty" />
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Label ID="orderTotalLbl" runat="server" Text="The total price of order" /><br />
    <asp:Button ID="checkoutBtn2" runat="server" Text="Checkout" OnClick="checkout_Click"/>
</asp:Content>
