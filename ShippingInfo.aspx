<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="ShippingInfo.aspx.cs" Inherits="ShippingInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderData" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="BookImageHolder" Runat="Server">
    <table style="width: 100%">
        <tr >
            <td style="border-style: solid">
                <asp:Label ID="orderSumLbl" runat="server" Text="Order Summary" Font-Bold="True" Font-Size="Medium" />
                <br />
                <br />
                Items: <asp:Label ID="itemLbl"  runat="server" Text= "NUm Items" />&nbsp;
                <br />
                Quantity: <asp:Label ID="quantityLbl" runat="server" Text="Num Total" />
                <br />
                Weight: <asp:Label ID="weightLbl" runat="server" Text="Total Weight" />
                <br />
                <br />
                Book Price Total: <asp:Label ID="bookPriceLbl" runat="server" Text="book price total" />
                <br />
             
                Total Shipping Cost: <asp:Label ID="shippingCostLbl" runat="server" Text="Shipping Cost" />
                <br />
                <br />
                Order Total: <asp:Label ID="totalLbl" runat="server" Text="Order Total" />
            </td>
        </tr>
        <tr>
            <td style="border-style: solid"><asp:Label ID="shippingInfoID" runat="server" Text="Shipping Information" Font-Bold="True" />
                <br />
                <br />
                Name:&nbsp;&nbsp; <asp:TextBox ID="nameBox" runat="server" CssClass="textBoxStyle1" /> 
                <asp:RequiredFieldValidator ID="RequiredValidator" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="nameBox" ForeColor="Red" Font-Bold="true" Text="*" />
                <br />
                Street:&nbsp;&nbsp; <asp:TextBox ID="streetBox" runat="server" CssClass="textBoxStyle1"/> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="streetBox" ForeColor="Red" Font-Bold="true" Text="*" /> <br />
                City:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="cityBox" runat="server" CssClass="textBoxStyle1"/> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="cityBox" ForeColor="Red" Font-Bold="true" Text="*" /><br />
                State:&nbsp;&nbsp;&nbsp; <asp:TextBox ID="stateBox" runat="server" CssClass="textBoxStyle1"/>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="stateBox" ForeColor="Red" Font-Bold="true" Text="*" /><br />
                Zip:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="zipBox" runat="server" CssClass="textBoxStyle1"/> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="zipBox" ForeColor="Red" Font-Bold="true" Text="*" /><br />
                Email:&nbsp;&nbsp;<asp:TextBox ID="emailBox" runat="server" CssClass="textBoxStyle1"/> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Value is Required"
                     ControlToValidate="emailBox" ForeColor="Red" Font-Bold="true" Text="*" />
                <asp:RegularExpressionValidator ID="RegexForEmail" runat="server" ControlToValidate="emailBox" ValidationExpression="\w+@+\w+.+\w+.?\w*"
                    ErrorMessage="Not a Valid E-mail" ForeColor="Red" Font-Bold="true" Text="*" /><br />
                <asp:ValidationSummary ID="Errors" runat="server" ForeColor="Red" />
            </td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <asp:Button ID="contShopBtn" runat="server" Text="Continue Shopping" /> &nbsp;&nbsp; <asp:Button ID="checkoutBtn" runat="server" Text="Checkout" OnClick="cmdOK_Click"/>
</asp:Content>

