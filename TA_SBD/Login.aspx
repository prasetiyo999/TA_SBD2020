<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TA_SBD.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
 <div>
     <td>HALAMAN LOGIN</td>
     <br />
    <br />
 <table>
 <tr>
 <td >Username :</td>
 <td><asp:TextBox ID="txtNama"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Password :</td>
 <td><asp:TextBox ID="txtPassword"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>
 </td>

<td>
 <asp:Button
ID="btnLogin" runat="server" Text="Login" BackColor="DeepSkyBlue" ForeColor="White" Font-Bold OnClick="btnLogin_Click" />
    <br />
    <br />
    <asp:Button
ID="btnSignUp" runat="server" Text="Daftar" BackColor="Green" ForeColor="White" OnClick="btnSignUp_Click" />
 </td>
 </tr>
 </table>
 </div>

 </form>
</body>
</html>
