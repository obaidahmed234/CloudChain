<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="Theme.aspx.cs" Inherits="Theme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <h2 style="text-align:center;font-family:'Old English Text MT'">Theme Manager</h2>
<h3 style="text-align:center;font-family:'Old English Text MT'">Select Any one of the Following Themes</h3>
    <div style="transform:translate(450px,100px)">
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" onselectedindexchanged="DropDownList1_SelectedIndexChanged">
        <asp:ListItem Value="Select Any Theme">Select Any Theme</asp:ListItem>
        <asp:ListItem >Blue</asp:ListItem>
        <asp:ListItem >Gold</asp:ListItem>
        <asp:ListItem >Green</asp:ListItem>
        <asp:ListItem >Pink</asp:ListItem>
        <asp:ListItem >Red</asp:ListItem>
        <asp:ListItem >MultiColor</asp:ListItem>
            
    </asp:DropDownList>
 
        </div>
</asp:Content>

