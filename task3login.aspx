<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="task3login.aspx.cs" Inherits="task3login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="jquery-2.1.4.js"></script>
    <script src="jquery-2.1.4.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
        $("#txtName").blur(function () {
        if ($("#txtName").val() == "")
        $("#NameValidator").show("slow");
        else
        $("#NameValidator").hide("slow");
        });
        $("#txtPassword").blur(function () {
        if ($("#txtPassword").val() == "")
        $("#PassValidator").show("slow");
        else
        $("#PassValidator").hide("slow");
        });
     $("#btnLogin").click(function () {

            if ($("#txtName").val() == "Salar" && $("#txtPassword").val() == "123123") {
                window.open("home.html");
            }
            else {
                window.alert("Username or Password is wrong");
            }
        });

        });


        </script>

    <div style="transform:translate(200px,60px)">
     <table id ="tblLogin" style="background-color:lightblue;color:white;">
        <tr>
            <td>
                Please Enter your Name
            </td>
            <td>
                <input id ="txtName" type="text" />
                <div id ="NameValidator" style="display:none; color:Red;">Name is missing</div>
            </td>
        </tr>
        <tr>
            <td>
                Please Enter your Password
            </td>
            <td>
                <input id ="txtPassword" type="password" />
                <div id ="PassValidator" style="display:none; color:Red;">Password is missing</div>
            </td>
        </tr>
        <tr>
            <td colspan ="2" style="text-align:right;">
                <input id ="btnLogin" type="button" value="Login" />
                </td>
        </tr>
        </table>
        </div>
</asp:Content>

