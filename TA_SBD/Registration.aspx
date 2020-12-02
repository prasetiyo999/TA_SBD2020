<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="TA_SBD.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
 <div>
     <td>REGISTRATION</td>
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
 <td>Admin/User :</td>
 <td><asp:TextBox ID="txtLevel"
runat="server"></asp:TextBox></td>
 </tr>
 <tr>
 <td>
 </td>

<td>
 <asp:Button
ID="btnSignUp" runat="server" Text="Daftar" BackColor="Green" ForeColor="White" Font-Bold OnClick="btnSignUp_Click" />

    <br />
    <br />
    <asp:Button
ID="btnExit" runat="server" Text="Keluar" BackColor="Red" ForeColor="Black" OnClick="btnExit_Click" />
 </td>
 </tr>
 </table>
 </div>

 </form>
</body>
</html>
