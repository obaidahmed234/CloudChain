<%@ Page Title="" Language="C#"  MasterPageFile="~/MainPage.master" AutoEventWireup="true" CodeFile="task5.aspx.cs" Inherits="task5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <script src="jquery-2.1.4.js"></script>
    <script src="jquery-2.1.4.min.js"></script>
     <script type="text/javascript">
        $(document).ready(function () {
            $("#playaudio").click(function () {
                $.ajax({
                    type: "POST",
                    url: "task5.aspx/GetAudio",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (result)
                    {
                        $("#audio").src = result.d;
                        $("#audio").trigger("play");
                    },
                    error: function (err)
                    {
                        alert(err.status + " - " + err.statusText);
                    }
                });

            });

            $("#playvideo").click(function () {
                $.ajax({
                    type: "POST",
                    url: "task5.aspx/GetVideo",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (result) {
                        $("#video").src = result.d;
                        $("#video").trigger("play");
                    },
                    error: function (err) {
                        alert(err.status + " - " + err.statusText);
                    }
                });

            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
     <header>
        <h1 style="font-family:'Old English Text MT';text-align:center;">Playing Random Audio and Video Files</h1>
    </header>
    <div style="transform:translate(100px,0px)">
        <input type="button" id="playaudio" value="Play Audio File" />
        <br />
        <br />
        <audio id="audio" src="audio1.mp3"  controls="" ></audio>
        <br />
        <br />
        <input type="button" id="playvideo" value="Play Video" />
        <br />
        <br />
        <video id="video" src="video1.mp4" controls="" ></video>
    </div>
</asp:Content>

