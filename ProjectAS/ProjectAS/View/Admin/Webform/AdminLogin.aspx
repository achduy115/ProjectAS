<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="ProjectAS.View.Admin.Webform.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập quản lý</title>

    <!-- Add Bootstrap, Fontawesome, W3, Css-->
    <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>
    <link rel="stylesheet" href="https://www.w3schools.com/w3css/4/w3.css"/> 
    <link rel="stylesheet" type="text/css" href="https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.css" />
    <link href="../../../Content/Style/Admin/Webform/styleLogin.css" rel="stylesheet" />

</head>
<body>
    <form id="formLogin" runat="server">
        <div class="container main-section">
	        <div class="row">
		        <div class="col-md-12 text-center user-login-header">
			        <h1 style="color:lightblue">Đăng nhập</h1>
		        </div>
	        </div>
	        <div class="row">
		        <div class="col-md-4 col-sm-8 col-xs-12 col-md-offset-4 col-sm-offset-2 login-image-main text-center" style="background-color:lightblue">
			        <div class="row">
				        <div class="col-md-12 col-sm-12 col-xs-12 user-image-section">
                            <img src="../../../Content/Image/Admin/Webform/businessman.png" />
				        </div>
				        <div class="col-md-12 col-sm-12 col-xs-12 user-login-box">
					        <div class="form-group">
                                <asp:TextBox runat="server" ID="txbUserName" CssClass="form-control" placeholder="Tên đẳng nhập" />
					        </div>
					        <div class="form-group">
                                <asp:TextBox runat="server" ID="txbPassword" TextMode="Password" CssClass="form-control" placeholder="Mật khẩu" />
					        </div>
                            <asp:Button runat="server" ID="btnLogin" Text="Đăng nhập" CssClass="btn btn-danger" OnClick="btnLogin_Click"/>
				        </div>
			        </div>
		        </div>
	        </div>
        </div>
    </form>
</body>
</html>
