<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="connected.aspx.cs" Inherits="connected" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Cell Number</td>
            <td>
                <asp:TextBox ID="txtCellNumber" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Gender</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Occupation</td>
            <td>
                <asp:TextBox ID="txtOccupation" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Done" Width="83px" />
            </td>
        </tr>
    </table>
</asp:Content>

