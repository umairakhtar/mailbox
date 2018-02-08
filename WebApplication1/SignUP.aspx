<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUP.aspx.cs" Inherits="WebApplication1.SignUP" %>

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
	/*color: #5379fa !important;*/
    color:deeppink;
}

.signup{
	position: absolute;
	top: calc(50% - 250px);
	left: calc(50% - 50px);
	height: 350px;
	width: 350px;
	padding: 2px;
	z-index: 2;
}

.signup input[type=text]{
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

.signup input[type=password]{
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

.signup input[type=button]{
	width: 260px;
	height: 35px;
	background: #fff;
	border: 1px solid #fff;
	cursor: pointer;
	border-radius: 2px;
	color: #a18d6c;
	font-family: 'Exo', sans-serif;
	font-size: 130px;
	font-weight: 400;
	padding: 6px;
	margin-top: 10px;
}

.signup input[type=button]:hover{
	opacity: 0.8;
}

.signup input[type=button]:active{
	opacity: 0.6;
}

.signup input[type=text]:focus{
	outline: none;
	border: 1px solid rgba(255,255,255,0.9);
}

.signup input[type=password]:focus{
	outline: none;
	border: 1px solid rgba(255,255,255,0.9);
}

.signup input[type=button]:focus{
	outline: none;
}

::-webkit-input-placeholder{
   color: rgba(255,255,255,0.6);
}

::-moz-input-placeholder{
   color: rgba(255,255,255,0.6);
}
        .auto-style1 {
            position: absolute;
            top: -11px;
            left: -20px;
            right: -40px;
            bottom: -200px;
            width: auto;
            height: auto;
            background-image: url('http://ginva.com/wp-content/uploads/2012/07/city-skyline-wallpapers-008.jpg');
            background-size: cover;
            -webkit-filter: blur(4px);
            z-index: 0;
        }
        .auto-style2 {
            position: absolute;
            top: -20px;
            left: -20px;
            right: -40px;
            bottom: -105px;
            width: auto;
            height: 800px;
/* Chrome,Safari4+ */z-index: 1;
            opacity: 0.7;
        }
    </style>

    
</head>

<body>
<form id="form1" runat="server">
  <div class="auto-style1"></div>
		<div class="auto-style2"></div>
		<div class="header">
			<div>MAIL<span>BOX</span></div>
		</div>
		<br>
		<div class="signup">
            <asp:TextBox ID="txtFirst" runat="server" placeholder="FIRST NAME"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtFirst"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:TextBox ID="txtLast" runat="server" placeholder="LAST NAME"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtLast"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:TextBox ID="txtEmail" runat="server" placeholder="EMAIL"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtEmail"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:TextBox ID="txtPass" runat="server" placeholder="PASSWORD" TextMode="Password" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtPass"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:TextBox ID="txtConfirm" runat="server" placeholder="CONFIRM PASSWORD" TextMode="Password" ></asp:TextBox><asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password should Match" ControlToCompare="txtPass" ControlToValidate="txtConfirm"></asp:CompareValidator><br /><br /><br />
            <asp:TextBox ID="txtCountry" runat="server" placeholder="COUNTRY" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtCountry"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:TextBox ID="txtMobile" runat="server" placeholder="MOBILE" ></asp:TextBox>
            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Field Cannot Be Empty" ControlToValidate="txtMobile"></asp:RequiredFieldValidator><br /><br /><br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="124px">
            <asp:ListItem>MALE</asp:ListItem><asp:ListItem>FEMALE</asp:ListItem>
            </asp:RadioButtonList><br /><br /><br />
            <asp:Calendar ID="Calender1" runat="server" Visible="False" OnSelectionChanged="Calender1_SelectionChanged"></asp:Calendar>
            <asp:LinkButton ID="LinkButton1" runat="server" onClick="LinkButton1_Click">
            <asp:TextBox ID="txtDOB" runat="server" placeholder="DATE OF BIRTH" OnTextChanged="txtDOB_TextChanged1"></asp:TextBox>
            </asp:LinkButton><br /><br /><br />
			<asp:Button ID="btnSignUp" runat="server" Text="SIGN UP" align="right" OnClick="btnSignUp_Click"/>

             <asp:Button ID="btnReset" runat="server" 
            Text="CANCEL" onclick="btnReset_Click" />
            	
		</div>

  <script src='http://codepen.io/assets/libs/fullpage/jquery.js'></script>
</form>
</body>

</html>
