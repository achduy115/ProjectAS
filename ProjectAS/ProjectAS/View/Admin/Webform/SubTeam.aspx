<%@ Page Title="" Language="C#" MasterPageFile="~/View/Admin/Master/AdminMaster.Master" AutoEventWireup="true" CodeBehind="SubTeam.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.SubTeam" %>

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
                        <h2 class="w3-text-gray w3-allerta w3-center">Tổng quan thể loại</h2>
                        <div class="w3-container" style="margin: 15px">
                            <!-- GridView -->
                            <asp:GridView ID="gvSubTeam" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" 
                                OnRowCancelingEdit="gvSubTeam_RowCancelingEdit" OnRowDeleting="gvSubTeam_RowDeleting" 
                                OnRowEditing="gvSubTeam_RowEditing" OnRowUpdating="gvSubTeam_RowUpdating"
                                Width="100%" Height="100px">
                                <AlternatingRowStyle BackColor="#CCCCCC" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Mã nhóm sub">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("ID") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("ID") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Tên nhóm sub">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("NameDisplay") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label2" runat="server" Text='<%# Bind("NameDisplay") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField HeaderText="Thông tin">
                                        <EditItemTemplate>
                                            <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("Info") %>'></asp:TextBox>
                                        </EditItemTemplate>
                                        <ItemTemplate>
                                            <asp:Label ID="Label3" runat="server" Text='<%# Bind("Info") %>'></asp:Label>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:CommandField CancelText="Hủy" DeleteText="Xóa" EditText="Sửa" ShowDeleteButton="True" ShowEditButton="True" />
                                </Columns>
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
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
                        <h2 class="w3-text-gray w3-allerta w3-center"><b>Thêm thể loại</b></h2>
                        <!-- Mã thể loài -->
                        <label class="w3-text-blue"><b>Mã nhóm sub:</b></label>
                        <br />
                        <asp:TextBox runat="server" ID="txbID" CssClass="w3-input w3-border" placeholder="VNS, ZFS, KRT, ..."></asp:TextBox>
                        <!-- Tên thể loài -->
                        <label class="w3-text-blue"><b>Tên nhóm sub:</b></label>
                        <br />
                        <asp:TextBox runat="server" ID="txbNameDisplay" CssClass="w3-input w3-border" placeholder="Vnsharing, Zing fansub, ..."></asp:TextBox>
                        <!-- Info -->
                        <label class="w3-text-blue"><b>Thông tin:</b></label>
                        <br />
                        <asp:TextBox runat="server" ID="txbInfo" CssClass="w3-input w3-border" placeholder="Thông tin của nhóm sub" TextMode="MultiLine" Height="100px"></asp:TextBox>
                        <!-- Nút nhấn -->
                        <div class="w3-row" style="margin: 10px 10px 40px 10px">
                            <div class="w3-col l4">
                                <asp:Button runat="server" ID="btnAdd" CssClass="w3-button w3-gray w3-text-white w3-round" Text="Thêm" OnClick="btnAdd_Click"/>
                                <asp:Button runat="server" ID="btnReset" CssClass="w3-button w3-gray w3-text-white w3-round" Text="Reset" OnClick="btnReset_Click"/>
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
