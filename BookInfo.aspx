<%@ Page Title="" Language="C#" MasterPageFile="./MasterPage.master" AutoEventWireup="true" CodeFile="BookInfo.aspx.cs" Inherits="BookInfo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PlaceHolderData" Runat="Server">
    <div style="float:left; width: 263px;">

        <asp:Image ID="BigBookImage" runat="server" Height="504px" ImageUrl="https://images-na.ssl-images-amazon.com/images/I/71deVIyvWsL.jpg" style="margin-top: 0px; margin-left: 10px;" Width="398px" />

    </div>
    <div style="float:right; width: 700px;">

        <table style="width: 100%; height: 389px;">
            <tr>
                <td style="width: 326px">
                    <asp:Label ID="Label2" runat="server" Text="Title: "></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">
                    <asp:Label ID="Label3" runat="server" Text="Author:"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lblAuthor" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">ISBN: </td>
                <td>
                    <asp:Label ID="lblISBN" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">Style:</td>
                <td>
                    <asp:Label ID="lblStyle" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">Pages:</td>
                <td>
                    <asp:Label ID="lblPages" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">Weight:</td>
                <td>
                    <asp:Label ID="lblWeight" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">Price: </td>
                <td>
                    <asp:Label ID="lblPrice" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 326px">
                    <asp:Button ID="Button1" runat="server" Text="Add to Cart" OnClick="cartBtn_Click"/>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>

    </div>
</asp:Content>
<asp:Content ID="BookImageDisplay" ContentPlaceHolderID="BookImageHolder" runat="server">

</asp:Content>
