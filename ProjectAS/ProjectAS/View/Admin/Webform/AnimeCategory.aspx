<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AnimeCategory.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.AnimeCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Quản lý thể loại</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w3-container">

        <div class="w3-bar w3-white w3-border-right w3-border-left">
            <button class="w3-bar-item w3-button tablink w3-gray w3-border-right" onclick="openTab(event,'Summary')">Tổng quan</button>
            <button class="w3-bar-item w3-button tablink w3-border-right" onclick="openTab(event,'Add')">Thêm</button>
        </div>

        <div id="Summary" class="w3-container w3-border tab">
            <h2>Tổng quan</h2>
            <form runat="server">
                <asp:GridView ID="gvSummaryAnimeCategory" runat="server">
                </asp:GridView>
            </form>
        </div>

        <div id="Add" class="w3-container w3-border tab" style="display: none">
            <h2>Thêm</h2>
            <p>Paris is the capital of France.</p>
        </div>

    </div>

    <script>
        function openTab(evt, tabName) {
            var i, x, tablinks;
            x = document.getElementsByClassName("tab");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            tablinks = document.getElementsByClassName("tablink");
            for (i = 0; i < x.length; i++) {
                tablinks[i].className = tablinks[i].className.replace(" w3-gray", "");
            }
            document.getElementById(tabName).style.display = "block";
            evt.currentTarget.className += " w3-gray";
        }
    </script>
</asp:Content>
