<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="linq.aspx.cs" Inherits="linq" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style5 {
            width: 438px;
        }
        .auto-style6 {
            height: 23px;
            width: 438px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <table class="auto-style1">
        <tr>
            <td class="auto-style5">Name</td>
            <td>
                <asp:TextBox ID="txtName" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Address</td>
            <td>
                <asp:TextBox ID="txtAddress" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Cell Number</td>
            <td>
                <asp:TextBox ID="txtCellNumber" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Gender</td>
            <td>
                <asp:TextBox ID="txtGender" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">Occupation</td>
            <td>
                <asp:TextBox ID="txtOccupation" runat="server" style="width: 128px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style3"></td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" Width="55px" />
               <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" Width="55px" />
                <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" Width="55px" />
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="185px"></asp:ListBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                    <EditRowStyle BackColor="#999999" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#E9E7E2" />
                    <SortedAscendingHeaderStyle BackColor="#506C8C" />
                    <SortedDescendingCellStyle BackColor="#FFFDF8" />
                    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

