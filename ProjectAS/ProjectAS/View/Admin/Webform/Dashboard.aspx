<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Add CSS -->
    <link href="../../../Content/Style/Admin/Webform/styleDashboard.css" rel="stylesheet" />
    <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Allerta+Stencil"/>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w3-container">
        <!-- Web View -->
        <div class="w3-row">
            <div class="w3-col l3">
                <!-- View theo ngày -->
                <div class="w3-round w3-teal card">
                    <div class="w3-row row-in-card">
                        <div class="w3-col l12">
                            <p class="w3-large w3-allerta" style="margin: 5% 0 0 5%">View ngày</p>
                        </div>
                    </div>
                    <div class="w3-row row-in-card">
                        <!-- Icon View -->
                        <div class="w3-col l6">
                            <span class="fa fa-bar-chart fa-4x" style="margin: 0 0 0 7%"></span>
                        </div>
                        <div class="w3-col l6">
                            <p style="font-size: 25px; margin: 5% 0 0 5%">
                                <asp:Label runat="server" ID="txbViewDay" Text="10"/>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="w3-col l3">
                <!-- View theo tuần -->
                <div class="w3-round w3-teal card">
                    <div class="w3-row row-in-card">
                        <div class="w3-col l12">
                            <p class="w3-large w3-allerta" style="margin: 5% 0 0 5%">View tuần</p>
                        </div>
                    </div>
                    <div class="w3-row row-in-card">
                        <!-- Icon View -->
                        <div class="w3-col l6">
                            <span class="fa fa-bar-chart fa-4x" style="margin: 0 0 0 7%"></span>
                        </div>
                        <div class="w3-col l6">
                            <p style="font-size: 25px; margin: 5% 0 0 5%">
                                <asp:Label runat="server" ID="Label1" Text="10"/>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="w3-col l3">
                <!-- View theo tháng -->
                <div class="w3-round w3-teal card">
                    <div class="w3-row row-in-card">
                        <div class="w3-col l12">
                            <p class="w3-large w3-allerta" style="margin: 5% 0 0 5%">View tháng</p>
                        </div>
                    </div>
                    <div class="w3-row row-in-card">
                        <!-- Icon View -->
                        <div class="w3-col l6">
                            <span class="fa fa-bar-chart fa-4x" style="margin: 0 0 0 7%"></span>
                        </div>
                        <div class="w3-col l6">
                            <p style="font-size: 25px; margin: 5% 0 0 5%">
                                <asp:Label runat="server" ID="Label2" Text="10"/>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
            <div class="w3-col l3">
                <!-- Tổng view -->
                <div class="w3-round w3-teal card">
                    <div class="w3-row row-in-card">
                        <div class="w3-col l12">
                            <p class="w3-large w3-allerta" style="margin: 5% 0 0 5%">View tổng</p>
                        </div>
                    </div>
                    <div class="w3-row row-in-card">
                        <!-- Icon View -->
                        <div class="w3-col l6">
                            <span class="fa fa-bar-chart fa-4x" style="margin: 0 0 0 7%"></span>
                        </div>
                        <div class="w3-col l6">
                            <p style="font-size: 25px; margin: 5% 0 0 5%">
                                <asp:Label runat="server" ID="Label3" Text="10"/>
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <!-- Something else-->
        <div class="w3-row">
            <!-- Anime 5 Top Views Week-->
            <div class="w3-col l6">
                <div class="w3-grey anime-view-card">
                    <div class="w3-card-4" style="width:100%">
                        <header class="w3-container w3-blue w3-center w3-large w3-allerta ">
                            Top 5 anime trong tuần
                        </header>
                        <div class="w3-container">
                            <asp:DataList ID="dlAnimeTopViews" runat="server">
                                <ItemTemplate>
                                    <div class="w3-row">

                                    </div>
                                </ItemTemplate>
                            </asp:DataList>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Something else -->
            <div class="w3-col l6">
                <div class="w3-grey anime-view-card">
                    s6
                </div>
            </div>
        </div>

    </div>
</asp:Content>
