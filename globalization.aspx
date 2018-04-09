<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="globalization.aspx.cs" Inherits="globalization" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="transform:translate(250px,0px)">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
        <asp:ListItem>Select Language</asp:ListItem>
        <asp:ListItem Value="en-US">English</asp:ListItem>
        <asp:ListItem Value="fr">French</asp:ListItem>
        <asp:ListItem Value="uz">Uzbek</asp:ListItem>
        <asp:ListItem Value="ur">Urdu</asp:ListItem>
    </asp:DropDownList><br /><br />
        </div>
    <asp:Label ID="Label1" runat="server" Text="<%$ Resources:Resource, Text1 %>" Font-Bold="True" Font-Size="X-Large"></asp:Label><br /><br />
    <asp:Label ID="Label2" runat="server" Text="<%$ Resources:Resource, Text2 %>"></asp:Label><br /><br />
    <asp:Label ID="Label3" runat="server" Text="<%$ Resources:Resource, Text3 %>" Font-Bold="True" Font-Size="X-Large"></asp:Label><br /><br />
    <asp:Label ID="Label4" runat="server" Text="<%$ Resources:Resource, Text4 %>"></asp:Label><br /><br />
    <asp:Label ID="Label5" runat="server" Text="<%$ Resources:Resource, Text5 %>" Font-Bold="True" Font-Size="X-Large"></asp:Label><br /><br />
    <asp:Label ID="Label6" runat="server" Text="<%$ Resources:Resource, Text6 %>"></asp:Label><br /><br />
</asp:Content>

