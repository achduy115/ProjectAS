<%@ Page Title="" Language="C#" MasterPageFile="~/View/User/Master/UserMaster.Master" AutoEventWireup="true" CodeBehind="WatchMovie.aspx.cs" Inherits="ProjectAS.View.User.Webform.WatchMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <link rel="stylesheet" type="text/css" href="../../../Content/Style/User/Webform/styleWM.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:DataList ID="DataListWatch" runat="server" CssClass="games">
            <ItemTemplate>
                <div class="main">
                    <div class="playVideo">
                        <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# Eval("VideoUrl") %>'>HyperLink</asp:HyperLink>
                        <br />
                        <asp:HyperLink ID="HyperLink3" runat="server" Text='<%# Eval("NameDisplay") %>'></asp:HyperLink>
                        <br /><br />
                        <div class="w3-panel w3-card-2 w3-hover-shadow">
                            <p>Thông Tin</p>
                            <asp:HyperLink ID="HyperLink2" runat="server" Text='<%# Eval("Content") %>'></asp:HyperLink>
                        </div>
                        <br />
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </div>
</asp:Content>
