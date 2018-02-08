<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGIN.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 700px;
        }
        .auto-style2 {
            width: 33%;
            height: 258px;
        }
        .auto-style3 {
            height: 78px;
        }
        .auto-style4 {
            height: 78px;
            width: 147px;
        }
        .auto-style5 {
            height:240px ;
            width: 33%;
        }
        .auto-style6 {
            width: 147px;
        }
        .auto-style7 {
            width: 100%;
            height: 240px;
        }
        .auto-style8 {
            height: 78px;
            width: 512px;
        }
        .auto-style9 {
            height: 240px;
            width: 33%;
        }
        .auto-style10 {
            width: 512px;
        }
        .auto-style11 {
            height: 132px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1" style="background-color: #66FFCC">
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style8"></td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style5"></td>
                <td class="auto-style9">
                    <table class="auto-style7">
                        <tr>
                            <td>USERNAME : </td>
                            <td><asp:TextBox ID="UserText" runat="server"></asp:TextBox><br /></td>
                        </tr>
                        <tr>
                            <td>PASSWORD : </td>
                            <td><asp:TextBox ID="PassText" runat="server"></asp:TextBox><br /></td>
                        </tr>
                        
                        <tr>
                            
                            <td class="auto-style11"><br />
                                <asp:Button ID="btnLogin" runat="server" Text="LOGIN" align="right" Height="43px" Width="108px" OnClick="btnLogin_Click"/>
                            </td>
                            <td class="auto-style11"><br /><asp:Button ID="btnSignUp" runat="server" Text="SIGN UP" align="middle" Height="46px" Width="115px"/><br /></td>
                        </tr>
                    </table>
                </td>
                <td class="auto-style2"></td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>--%>

<!DOCTYPE html>
<html>

<head>

  <meta charset="UTF-8">

  <title>CodePen - Random Login Form</title>

    <style>
@import url(http://fonts.googleapis.com/css?family=Exo:100,200,400);
@import url(http://fonts.googleapis.com/css?family=Source+Sans+Pro:700,400,300);

body{
	margin: 0;
	padding: 0;
	background: #fff;

	color: #fff;
	font-family: Arial;
	font-size: 12px;
}

.body{
	position: absolute;
	top: -20px;
	left: -20px;
	right: -40px;
	bottom: -40px;
	width: auto;
	height: auto;
	background-image: url(http://ginva.com/wp-content/uploads/2012/07/city-skyline-wallpapers-008.jpg);
	background-size: cover;
	-webkit-filter: blur(5px);
	z-index: 0;
}

.grad{
	position: absolute;
	top: -20px;
	left: -20px;
	right: -40px;
	bottom: -40px;
	width: auto;
	height: auto;
	background: -webkit-gradient(linear, left top, left bottom, color-stop(0%,rgba(0,0,0,0)), color-stop(100%,rgba(0,0,0,0.65))); /* Chrome,Safari4+ */
	z-index: 1;
	opacity: 0.7;
}

.header{
	position: absolute;
	top: calc(50% - 35px);
	left: calc(50% - 255px);
	z-index: 2;
}

.header div{
	float: left;
	color: #fff;
	font-family: 'Exo', sans-serif;
	font-size: 35px;
	font-weight: 200;
}

.header div span{
	color: #5379fa !important;
}

.login{
	position: absolute;
	top: calc(50% - 75px);
	left: calc(50% - 50px);
	height: 150px;
	width: 350px;
	padding: 10px;
	z-index: 2;
}

.login input[type=text]{
	width: 250px;
	height: 30px;
	background: transparent;
	border: 1px solid rgba(255,255,255,0.6);
	border-radius: 2px;
	color: #fff;
	font-family: 'Exo', sans-serif;
	font-size: 16px;
	font-weight: 400;
	padding: 4px;
}

.login input[type=password]{
	width: 250px;
	height: 30px;
	background: transparent;
	border: 1px solid rgba(255,255,255,0.6);
	border-radius: 2px;
	color: #fff;
	font-family: 'Exo', sans-serif;
	font-size: 16px;
	font-weight: 400;
	padding: 4px;
	margin-top: 10px;
}

.login input[type=button]{
	width: 260px;
	height: 35px;
	background: #fff;
	border: 1px solid #fff;
	cursor: pointer;
	border-radius: 2px;
	color: #a18d6c;
	font-family: 'Exo', sans-serif;
	font-size: 16px;
	font-weight: 400;
	padding: 6px;
	margin-top: 10px;
}

.login input[type=button]:hover{
	opacity: 0.8;
}

.login input[type=button]:active{
	opacity: 0.6;
}

.login input[type=text]:focus{
	outline: none;
	border: 1px solid rgba(255,255,255,0.9);
}

.login input[type=password]:focus{
	outline: none;
	border: 1px solid rgba(255,255,255,0.9);
}

.login input[type=button]:focus{
	outline: none;
}

::-webkit-input-placeholder{
   color: rgba(255,255,255,0.6);
}

::-moz-input-placeholder{
   color: rgba(255,255,255,0.6);
}
</style>

    <script src="js/prefixfree.min.js"></script>

</head>

<body>
    <form id="form1" runat="server">
  <div class="body"></div>
		<div class="grad"></div>
		<div class="header">
			<div>MAIL<span>BOX</span></div>
		</div>
		<br>
		<div class="login">
            <asp:TextBox ID="UserText" runat="server" placeholder="USERNAME"></asp:TextBox><br /><br /><br /> 
                <asp:TextBox ID="PassText" runat="server" placeholder="PASSWORD" TextMode="Password"></asp:TextBox><br /><br /><br />
            <asp:Button ID="btnLogin" runat="server" Text="LOGIN" align="right" Height="43px" Width="108px" OnClick="btnLogin_Click"/>
		
            <asp:Button ID="btnSignUp" runat="server" Text="SIGN UP" align="middle" Height="46px" Width="115px" OnClick="btnSignUp_Click" />
             </div>
        

  <script src='http://codepen.io/assets/libs/fullpage/jquery.js'></script>
</form>
</body>

</html>