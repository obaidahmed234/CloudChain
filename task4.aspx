<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="task4.aspx.cs" Inherits="task4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script src="jquery-2.1.4.js"></script>
    <script src="jquery-2.1.4.min.js"></script>
    <script type="text/javascript">

         $(document).ready(function () {
             $("#div2").hide();
             $("#div3").hide();

             $("#cc").click(function () {

                 $("#div2").show("slow");
                 $("#div3").hide("slow");

             });
             $("#wt").click(function () {

                 $("#div3").show("slow");
                 $("#div2").hide("slow");

             });
             $("#buy").click(function () {

             });
         });
    </script>    <div style="transform:translate(100px,0px)">
     <p style="color:#001c9f;font-size:larger">JQUERY EXERCISE </p><br />
    <p style="font-size:large;color:lightblue"><b> Payment :</b></p><br />
    <div id="div1">
        <input id="cc" type="radio" name="payment"/>Credit Card<br /><br />
        <input id="wt" type="radio" name="payment"/>Wire Transfer
    </div>
    <div id="div2">
        Card Number : <input type="number" /> <br /><br />
        Expiration : <input type="number" style="width:100px" /> / <input type="number" style="width:100px" /><br /><br />
        3-diget number : <input type="number" style="width:50px"/><br /><br />

    </div>
    <div id="div3" >
        <p style="transform:translate(0px,50px)">Transfer the amount to: reg. 9570, account 0009286322 (in Pakistan)</p>
    </div>
    <br /><br /><br /><br />
    <button id="buy" style="border-color:#001c9f;border:thin; background-color:lightblue;width:50px;height:30px">Buy</button>
        </div>
</asp:Content>

