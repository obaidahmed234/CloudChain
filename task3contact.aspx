<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="task3contact.aspx.cs" Inherits="task3contact" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <style type="text/css">
  
        table
        {
        color: #001c9f;
        background-color:lightblue;

        }
    </style>
    <div style="transform:translate(200px,30px)">
        <table style="width:100px; height:400px">
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table style="width:100px; height:300px">
            <tr>
                <td>Please Enter your Name</td>
                <td><input type ="text" id="txtName" /></td>
            </tr>
            <tr>
                <td>Please Select your Gender</td>
                <td>
                    <input type ="radio" name="gen" />Male
                    <input type ="radio" name="gen" />female
                </td>
            </tr>
            <tr>
                <td>Please Provide your Feedback</td>
                <td><textarea cols ="40" rows="5"></textarea></td>
            </tr>
            <tr><td><input type ="button" value="Submit Feedback" /></td></tr>
            </table>
            </td>
            </tr>
            </table>
        </div>
</asp:Content>

