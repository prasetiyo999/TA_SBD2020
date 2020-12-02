<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Penyimpanan.aspx.cs" Inherits="TA_SBD.Penyimpanan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
 <div>
     <td>HALAMAN PENYIMPANAN</td>
     <br />
    <br />
 <table>
      <tr>
 <td>Id Toko :</td>
 <td><asp:TextBox ID="txtIdToko"
     runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Nama :</td>
 <td><asp:TextBox ID="txtNama"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Alamat :</td>
 <td><asp:TextBox ID="txtAlamat"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Telepon :</td>
 <td><asp:TextBox ID="txtTelepon"
runat="server"></asp:TextBox></td>
 </tr>
 <tr>
 <tr>
 <td>
 </td>

<td>
 <asp:Button
ID="btnAdd" runat="server" Text="ADD" BackColor="DeepSkyBlue" ForeColor="White" OnClick="btnAdd_Click" />
 <asp:Button ID="btnDelete" runat="server"
Text="DELETE" BackColor="DeepSkyBlue" ForeColor="White" OnClick="btnDelete_Click" />

<asp:Button ID="btnUpdate" runat="server"
Text="UPDATE" BackColor="DeepSkyBlue" ForeColor="White" OnClick="btnUpdate_Click" />

    <asp:Button ID="btnClear" runat="server"
Text="CLEAR" BackColor="DeepSkyBlue" ForeColor="White" OnClick="btnClear_Click" />

    <br />
    <br />
    <asp:Button ID="btnPenyewaan" runat="server"
Text="Penyewaan>>" BackColor ="GreenYellow" Font-Bold OnClick="btnPenyewaan_Click"/>
    <asp:Button ID="btnPenyewa" runat="server"
Text="Penyewa>>" BackColor="WindowFrame" ForeColor="White" Font-Bold OnClick="btnPenyewa_Click"/>
    <br />
    <br />
    <asp:Button
ID="btnExit" runat="server" Text="Keluar" BackColor="Red" ForeColor="Black" OnClick="btnExit_Click" />

 </td>
 </tr>
 </table>
 </div>
         <br />
         <asp:TextBox ID="searchText"
     runat="server"></asp:TextBox> </td>
         <asp:Button ID="btnSearch" runat="server"
Text="SEARCH" Font-Bold OnClick ="btnSearch_Click"/>
        <asp:GridView ID="SearchView" runat="server">
 </asp:GridView>
		 <br />
         Daftar Toko dan Daftar Bluray:<asp:GridView ID="ViewToko" runat="server"  Align="Left">
 </asp:GridView>
         <asp:GridView ID="ViewBluray" runat="server" Align="Right">
 </asp:GridView>
         <br />
         <br /><br /><br /><br /><br /><br /><br /><br />
         Status Penyimpanan :<asp:GridView ID="ViewPenyimpanan" runat="server" >
 </asp:GridView>
 </form>
</body>
</html>
