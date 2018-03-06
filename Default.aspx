<%@ Page Title="" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
  
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:Label ID="lblError" runat="server"></asp:Label>
    </p>
   
</asp:Content>

<asp:Content ID="PlaceHolderData1" ContentPlaceHolderID="PlaceHolderData" runat="server">
    <div>
    <asp:Label ID="Label2" runat="server" Text="Choose from the items below:" CssClass="label1" ></asp:Label>
        <br />
    <asp:Label ID="lblChoose" runat="server" Text="(Click for more Information)" CssClass="label1" />
    </div>

</asp:Content>

<asp:Content ID="ImageDataPlaceHolder" ContentPlaceHolderID="BookImageHolder" runat="server">
    
    <div style="border-style: double">
       
        &nbsp;&nbsp;
       
        <asp:ImageButton ID="Book1Button" runat="server" Height="214px" Width="148px" OnClick="onCoverClick" BorderStyle="Double" ImageUrl="./Pictures/BRCover.jpg" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Book2Button" runat="server" BorderStyle="Double" Height="214px" ImageUrl="./Pictures/BDKRCover.jpg" Width="148px" OnClick="onCoverClick"/>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Book3Button" runat="server" BorderStyle="Double" Height="214px" ImageUrl="./Pictures/wrinkle3.jpg" Width="148px" OnClick="onCoverClick"/>
        <br />
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <asp:Label ID="lblTitle1" runat="server" Text="Battle Royale" BorderStyle="Groove" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTitle2" runat="server" Text="Batman: Dark Knight Returns" BorderStyle="Groove" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblTitle3" runat="server" Text="A Wrinkle in Time" BorderStyle="Groove" />

</div>
</asp:Content>

