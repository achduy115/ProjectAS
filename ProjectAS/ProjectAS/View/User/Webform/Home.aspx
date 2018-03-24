<%@ Page Title="" Language="C#" MasterPageFile="~/View/User/Master/UserMaster.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ProjectAS.View.User.Webform.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Content/Style/User/Webform/style.css" type="text/css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- Slide -->
    <section class="mainSlides">
        <!-- Slide img -->
        <asp:DataList ID="DataListSlides" runat="server" DataKeyField="ID">          
            <ItemTemplate>
                <asp:HyperLink ID="HyperLink3" runat="server" ImageUrl='<%# "~/Content/Image/Wallpaper/" + Eval("ImageUrl") %>' CssClass="mySlides">HyperLink</asp:HyperLink>
            </ItemTemplate>
        </asp:DataList>
    </section>
    <div class="main">
        <section class="content">
            <div class="w3-container">    
                <!-- New episode -->
                <div class="w3-panel w3-card-2 w3-hover-shadow">
                    <p>Tập mới nhất ></p>
                </div>
                <!-- Datalist new episode -->
                <asp:DataList ID="DataListNewEpisode" runat="server" RepeatColumns="4" DataKeyField="ID">
                    <ItemTemplate>
                        <div class="w3-card-2 w3-hover-shadow">
                            <asp:HyperLink Target="_blank" ID="HyperLink1" runat="server" ImageUrl='<%# "~/Content/Image/Wallpaper/" + Eval("ImageUrl") %>' NavigateUrl='<%# "WatchMovie.aspx?id=" + Eval("ID") %>' CssClass="imageAnime">HyperLink</asp:HyperLink>
                            <div class="w3-container w3-center">
                                <asp:HyperLink Target="_blank" ID="HyperLink2" runat="server" NavigateUrl='<%# "WatchMovie.aspx?id=" + Eval("ID") %>' Text='<%# Eval("NameDisplay") %>' CssClass="nameAnime" Width="100%"></asp:HyperLink>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <!-- New anime -->
                <div class="w3-panel w3-card-2 w3-hover-shadow">
                    <p>Anime mới ></p>
                </div>
                <!-- Datalist new anime -->
                <asp:DataList ID="DataListNewAnime" runat="server" RepeatColumns="4" DataKeyField="ID">
                    <ItemTemplate>
                        <div class="w3-card-2 w3-hover-shadow">
                            <asp:HyperLink Target="_blank" ID="HyperLink1" runat="server" ImageUrl='<%# "~/Content/Image/Wallpaper/" + Eval("ImageUrl") %>' NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' CssClass="imageAnime">HyperLink</asp:HyperLink>
                            <div class="w3-container w3-center">
                                <asp:HyperLink Target="_blank" ID="HyperLink2" runat="server" NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' Text='<%# Eval("NameDisplay") %>' CssClass="nameAnime" Width="100%"></asp:HyperLink>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <!-- Most anime view -->
                <div class="w3-panel w3-card-2 w3-hover-shadow">
                    <p>Xem nhiều nhất ></p>
                </div>
                <!-- Datalist anime view -->
                <asp:DataList ID="DataListTop" runat="server" RepeatColumns="4" DataKeyField="ID">
                    <ItemTemplate>
                        <div class="w3-card-2 w3-hover-shadow">
                            <asp:HyperLink Target="_blank" ID="HyperLink1" runat="server" ImageUrl='<%# "~/Content/Image/Wallpaper/" + Eval("ImageUrl") %>' NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' CssClass="imageAnime">HyperLink</asp:HyperLink>
                            <div class="w3-container w3-center">
                                <asp:HyperLink Target="_blank" ID="HyperLink2" runat="server" NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' Text='<%# Eval("NameDisplay") %>' CssClass="nameAnime" Width="100%"></asp:HyperLink>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
                <!-- Random today -->
                <div class="w3-panel w3-card-2 w3-hover-shadow">
                    <p>Hôm nay xem gì ></p>
                </div>
                <!-- Datalist random today -->
                <asp:DataList ID="DataListRandom" runat="server" RepeatColumns="4" DataKeyField="ID">
                    <ItemTemplate>
                        <div class="w3-card-2 w3-hover-shadow">
                            <asp:HyperLink Target="_blank" ID="HyperLink1" runat="server" ImageUrl='<%# "~/Content/Image/Wallpaper/" + Eval("ImageUrl") %>' NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' CssClass="imageAnime">HyperLink</asp:HyperLink>
                            <div class="w3-container w3-center">
                                <asp:HyperLink Target="_blank" ID="HyperLink2" runat="server" NavigateUrl='<%# "WatchMovie.aspx?a=" + Eval("ID") %>' Text='<%# Eval("NameDisplay") %>' CssClass="nameAnime" Width="100%"></asp:HyperLink>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </section>
    </div>
    <script type="text/javascript" src="../../../Scripts/User/User/slide.js"></script>
</asp:Content>
