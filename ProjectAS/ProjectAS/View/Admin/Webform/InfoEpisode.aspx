<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="InfoEpisode.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.InfoEpisode" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server" class="w3-container">
        <!-- Header anime nane and sub team -->
        <header class="w3-container w3-light-blue">
            <asp:Label runat="server" ID="lbHeader" CssClass=" w3-allerta w3-xlarge w3-text-white">
                Anime name + subteam
            </asp:Label>
        </header>

        <!-- Add Info Episode -->
        <div class="w3-container w3-card-4 " style="margin: 30px 10px 40px 10px; padding: 0px 0px 10px 0px">
            <div class="w3-container w3-teal">
                <label class="w3-allerta w3-large">Thêm tập phim</label>
            </div>
            <div class="w3-row">
                <!-- Text box Id InfoEpisode -->
                <div class="w3-col l6 w3-padding">
                    <asp:TextBox runat="server" ID="txbID"
                        CssClass="w3-input w3-border" ReadOnly="True" Enabled="False"></asp:TextBox>
                </div>
                <!-- Text box Name display -->
                <div class="w3-col l6 w3-padding">
                    <asp:TextBox runat="server" ID="txbNameDisplay"
                        CssClass="w3-input w3-border"
                        placeholder="01, 02, OVA, SPC">

                    </asp:TextBox>
                </div>
            </div>
            <div class="w3-row">
                <!-- Text box Video url -->
                <div class="w3-col l6 w3-padding">
                    <asp:TextBox runat="server" ID="txbVideUrl"
                        CssClass="w3-input w3-border"
                        placeholder="Đường dẫn đến video url">

                    </asp:TextBox>
                </div>
                <!-- Button add and reset -->
                <div class="w3-col l6 w3-padding">
                    <asp:Button runat="server" ID="btnAdd"
                        Class="w3-button w3-gray w3-text-white w3-round w3-allerta w3-margin-right"
                        Text="Thêm" OnClick="btnAdd_Click" />
                    <asp:Button runat="server" ID="btnReset"
                        Class="w3-button w3-gray w3-text-white w3-round w3-allerta w3-margin-right"
                        Text="Reset" OnClick="btnReset_Click" />
                </div>
            </div>
        </div>

        <!-- Header Datalist info episode -->
        <div class="w3-container w3-light-blue">
            <asp:Label runat="server" CssClass="w3-allerta w3-xlarge w3-text-white">
                Thông tin tập phim
            </asp:Label>
        </div>

        <!-- Datalist info episode -->
        <asp:DataList runat="server" ID="dlInfoEpisode" Width="100%" CellPadding="4" ForeColor="#333333">
            <AlternatingItemStyle BackColor="White" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <ItemStyle BackColor="#E3EAEB" />
            <ItemTemplate>
                <!-- -->
                <div class="w3-row">
                    <!-- ID Info Episode -->
                    <div class="w3-col l2">

                    </div>
                    <!-- NameDisplay Info Episode -->
                    <div class="w3-col l4">

                    </div>
                    <!-- VideoUrl Info Episode -->
                    <div class="w3-col l4">

                    </div>
                    <!-- Button View -->
                    <div class="w3-col l2">

                    </div>
                </div>
            </ItemTemplate>
            <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        </asp:DataList>

    </form>
</asp:Content>
