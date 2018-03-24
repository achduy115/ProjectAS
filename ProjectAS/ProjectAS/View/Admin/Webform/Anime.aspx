<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Anime.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.Anime" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="w3-container">

        <div class="w3-bar w3-white w3-border-right w3-border-left">
            <button class="w3-bar-item w3-button tablink w3-gray w3-border-right" onclick="openTab(event,'Summary')">Tổng quan</button>
            <button class="w3-bar-item w3-button tablink w3-border-right" onclick="openTab(event,'Add')">Thêm</button>
        </div>
        <!-- Tổng quan -->
        <form runat="server">
            <div id="Summary" class="w3-container w3-border tab">
                <div class="w3-container" style="height: 100%; margin: 25px">
                    <div class="w3-container w3-card-4">
                        <h2 class="w3-text-gray w3-allerta w3-center">Tổng quan anime</h2>
                        <div class="w3-container" style="margin: 15px">
                            <!-- GridView -->
                            <asp:GridView ID="gvAnimeList" runat="server" DataKeyNames="ID" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" 
                                Width="100%" Height="100px">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Mã Anime">
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tên Anime">
                                        <ItemTemplate>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("NameDisplay") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tập">
                                        <ItemTemplate>
                                            <asp:Label ID="Label4" runat="server" Text='<%# Bind("CurrentEpisode") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tổng tập">
                                        <ItemTemplate>
                                            <asp:Label ID="Label5" runat="server" Text='<%# Bind("MaxEpisode") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Info">
                                        <ItemTemplate>
                                            <asp:Button runat="server" ID="btnInfo" 
                                                PostBackUrl='<%# "InfoAnime.aspx?idanime=" + Eval("ID") %>' Text="Xem" 
                                                CssClass="w3-button w3-gray w3-text-white w3-allerta" Width="100%" Height="100%"/>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="Gray" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>

            <div id="Add" class="w3-container w3-border tab" style="display: none">
                <div class="w3-container" style="height: 100%; margin: 25px">

                    <div class="w3-container w3-card-4">
                        <h2 class="w3-text-gray w3-allerta w3-center"><b>Thêm anime</b></h2>
                        <!-- Mã anime -->
                        <label class="w3-text-blue"><b>Mã thể loại:</b></label>
                        <br />
                        <asp:TextBox runat="server" ID="txbID" CssClass="w3-input w3-border" placeholder="VD: SUM15001, SPT16002, WIN17001, ..." ReadOnly="True"></asp:TextBox>
                        <!-- Tên anime -->
                        <label class="w3-text-blue"><b>Tên thể loại:</b></label>
                        <br />
                        <asp:TextBox runat="server" ID="txbNameDisplay" CssClass="w3-input w3-border" placeholder="VD: Boku no pico, SAO, ..."></asp:TextBox>
                        <!-- Mùa phim và năm ra mắt -->
                        <div class="w3-row" style="margin:15px 15px 15px 0px">
                            <!-- Mùa phim -->
                            <div class="w3-col l1"> 
                                <label class="w3-text-blue"><b>Mùa :</b></label>                                
                            </div>
                            <div class="w3-col l1">
                                <asp:ListBox ID="lbSeason" runat="server" OnSelectedIndexChanged="lbSeason_SelectedIndexChanged" AutoPostBack="true" ></asp:ListBox>
                            </div>
                            <!-- Năm ra mắt-->
                            <div class="w3-col l1">
                                <label class="w3-text-blue"><b>Năm :</b></label>                                
                            </div>
                            <div class="w3-col l1">
                                <asp:ListBox ID="lbYear" runat="server" OnSelectedIndexChanged="lbSeason_SelectedIndexChanged" AutoPostBack="true" ></asp:ListBox>
                            </div>
                        </div>
                        <!-- Thể loại phim -->
                        <div class="w3-row" style="margin:15px 15px 15px 0px">
                            <div class="w3-col l2">
                                <label class="w3-text-blue"><b>Thể loại phim :</b></label>
                            </div>
                            <div class="w3-col l2">
                                <asp:ListBox ID="lbCategory" runat="server" />
                            </div>
                        </div>
                        <!-- Content  -->
                        <div class="w3-row" style="margin:15px 15px 15px 0px">
                            <div class="w3-col l1">
                                <label class="w3-text-blue"><b>Mô tả :</b></label>
                            </div>
                            <div class="w3-col l1">
                                <asp:TextBox ID="txbContent" runat="server" TextMode="MultiLine" Width="500px" Height="100px" />
                            </div>
                        </div>

                        <!-- Image -->
                        <div class="w3-row" style="margin:15px 15px 15px 0px">
                            <div class="w3-col l1">
                                <label class="w3-text-blue"><b>Ảnh </b></label>
                            </div>
                            <div class="w3-col l1">
                                <asp:FileUpload runat="server" ID="flOpen" />
                            </div>
                            <div class="w3-col l1">
                                <asp:Label runat="server" ID="lbFileName" />
                            </div>
                        </div>

                        <!-- Nút nhấn -->
                        <div class="w3-row" style="margin: 10px 10px 40px 10px">
                            <div class="w3-col l4">
                                <asp:Button runat="server" ID="btnAdd" CssClass="w3-button w3-gray w3-text-white w3-round" Text="Thêm" OnClick="btnAdd_Click"  />
                                <asp:Button runat="server" ID="btnReset" CssClass="w3-button w3-gray w3-text-white w3-round" Text="Reset"  />
                            </div>
                            <div class="w3-col l4">
                                <b>
                                    <asp:Label runat="server" ID="txbResult" CssClass="w3-text-blue w3-large" /></b>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </form>
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
