<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="InfoAnime.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.InfoAnime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 30%;
        }

        .auto-style2 {
            width: 30%;
        }

        .auto-style3 {
            width: 40%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <section class="w3-container">
            <!-- Anime Name -->
            <header class="w3-container w3-light-blue">
                <asp:Label runat="server" ID="lbAnimeName" CssClass=" w3-allerta w3-xlarge w3-text-white">
                    Anime name
                </asp:Label>
            </header>
            <!-- Content -->
            <div>
                <table class="w3-table-all w3-centered">
                    <!-- Image Anime -->
                    <tr>
                        <td rowspan="6" class="auto-style1">
                            <asp:Image runat="server" ID="imgAnime" BackColor="Yellow" Width="600px" Heigh="800px" />
                        </td>
                        <!-- ID Anime -->
                        <td class="auto-style2">ID : </td>
                        <td class="auto-style3">
                            <asp:Label runat="server" ID="txbID" CssClass="w3-input w3-border" Enabled="False"></asp:Label>
                        </td>
                    </tr>
                    <!-- Content -->
                    <tr>
                        <td class="auto-style2">Nôi dung : </td>
                        <td class="auto-style3">
                            <asp:TextBox runat="server" ID="txbContent" TextMode="MultiLine" CssClass="w3-input w3-border">
                            </asp:TextBox>
                        </td>
                    </tr>
                    <!-- Edit Img -->
                    <tr>
                        <td class="auto-style2">Sửa ảnh : </td>
                        <td class="auto-style3">
                            <asp:FileUpload runat="server" ID="fluOpen" />
                        </td>
                    </tr>
                    <!-- Current Episode -->
                    <tr>
                        <td class="auto-style2">Số tập : </td>
                        <td class="auto-style3">
                            <asp:TextBox runat="server" ID="txbCurrentEpisode" CssClass="w3-input w3-border"></asp:TextBox>
                        </td>
                    </tr>
                    <!-- Max Episode -->
                    <tr>
                        <td class="auto-style2">Tổng số tập : </td>
                        <td class="auto-style3">
                            <asp:TextBox runat="server" ID="txbMaxEpisode" CssClass="w3-input w3-border"></asp:TextBox>
                        </td>
                    </tr>
                    <!-- Button -->
                    <tr>
                        <td class="auto-style2">&nbsp</td>
                        <td class="auto-style3">
                            <asp:Button runat="server" ID="btnEdit" Text="Sửa"
                                CssClass="w3-button w3-gray w3-text-white w3-round w3-allerta w3-margin-left w3-margin-right"
                                OnClick="btnEdit_Click" />
                            <asp:Button runat="server" ID="btnDelete" Text="Xóa"
                                CssClass="w3-button w3-gray w3-text-white w3-round w3-allerta w3-margin-left w3-margin-right"
                                OnClick="btnDelete_Click" />
                        </td>
                    </tr>
                </table>
            </div>

            <!-- Header Add SubTeam -->
            <div class="w3-container w3-light-blue" style="margin: 10px 0px 10px 0px">
                <p class="w3-allerta w3-xlarge w3-text-white">Thêm nhóm sub</p>
            </div>
            <!-- DropDownList SubTeam -->
            <div class="w3-row" style="margin: 30px 10px 10px 10px">
                <!-- DropDownList SubTeam -->
                <div class="w3-col l11">
                    <asp:DropDownList runat="server" ID="ddlSubTeam" CssClass="w3-input w3-border w3-round"
                        OnSelectedIndexChanged="ddlSubTeam_SelectedIndexChanged"
                        AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <!-- Add SubTeam Button -->
                <div class="w3-col l1">
                    <asp:Button runat="server" ID="btnAddSubTeam"
                        CssClass="w3-button w3-gray w3-text-white w3-round w3-allerta w3-margin-left w3-margin-right" Text="Thêm"
                        OnClick="btnAddSubTeam_Click" />
                </div>
            </div>
            <!-- ** Episode ** -->
            <div class="w3-container w3-light-blue">
                <p class="w3-allerta w3-xlarge w3-text-white">Quản lý tập phim</p>
            </div>
            <!-- Header -->
            <div style="margin: 50px 10px 0px 10px">
                <div class="w3-row w3-large w3-teal">
                    <!-- ID Episode Header -->
                    <div class="w3-col l3">
                        <p>Mã tập phim</p>
                    </div>
                    <!-- ID Anime Header -->
                    <div class="w3-col l3">
                        <p>Mã anime</p>
                    </div>
                    <!-- ID SubTeam Header -->
                    <div class="w3-col l3">
                        <p>Mã nhóm sub</p>
                    </div>
                    <!-- Button Header -->
                    <div class="w3-col l3">
                        &nbsp
                    </div>
                </div>
            </div>

            <!-- Datalist Episode -->
            <div style="margin: 0px 10px 40px 10px">
                <asp:DataList ID="dlEpisode" runat="server" Width="100%" CellPadding="4" ForeColor="#333333">
                    <AlternatingItemStyle BackColor="White" ForeColor="#284775" />
                    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                    <ItemStyle BackColor="#F7F6F3" ForeColor="#333333" />
                    <ItemTemplate>
                        <div class="w3-row w3-large">
                            <!-- ID Episode  -->
                            <div class="w3-col l3">
                                <asp:Label runat="server" ID="lbIdEpisode" CssClass="w3-center" Text='<%# Eval("ID") %>'></asp:Label>
                            </div>
                            <!-- ID Anime  -->
                            <div class="w3-col l3">
                                <asp:Label runat="server" ID="lbIdAnime" CssClass="w3-center" Text='<%# Eval("IDAnime") %>'></asp:Label>
                            </div>
                            <!-- ID SubTeam  -->
                            <div class="w3-col l3">
                                <asp:Label runat="server" ID="lbIdSubTeam" CssClass="w3-center" Text='<%# Eval("IDSubTeam") %>'></asp:Label>
                            </div>
                            <!-- &nbsp -->
                            <div class="w3-col l2">
                                &nbsp
                            </div>
                            <!-- Button -->
                            <div class="w3-col l1">
                                <asp:Button runat="server" ID="btnViewEpisode"
                                    Width="100%"
                                    CssClass="w3-button w3-gray w3-text-white w3-round w3-allerta"
                                    PostBackUrl='<%# "InfoEpisode.aspx?idepisode=" + Eval("ID") %>'
                                    Text="Xem" />
                            </div>
                        </div>
                    </ItemTemplate>
                    <SelectedItemStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                </asp:DataList>
            </div>
        </section>
    </form>
</asp:Content>
