<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Penyewaan.aspx.cs" Inherits="TA_SBD.Penyewaan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
 <div>
     <td>HALAMAN PENYEWAAN</td>
     <br />
    <br />
 <table>
      <tr>
 <td>Id Bluray :</td>
 <td><asp:TextBox ID="txtIdBluray"
     runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Judul :</td>
 <td><asp:TextBox ID="txtJudul"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Tahun Terbit :</td>
 <td><asp:TextBox ID="txtTahun"
runat="server"></asp:TextBox> </td>
 </tr>
 <tr>
 <td>Id Penyewa :</td>
 <td><asp:TextBox ID="txtIdPenyewa"
runat="server"></asp:TextBox></td>
 </tr>
     <tr>
 <td>Id Toko :</td>
 <td><asp:TextBox ID="txtIdToko"
runat="server"></asp:TextBox> </td>
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
    <asp:Button ID="btnPenyewa" runat="server"
Text="Penyewa>>" BackColor="WindowFrame" ForeColor="White" Font-Bold OnClick="btnPenyewa_Click"/><br />
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
         Daftar Penyewa dan Daftar Bluray:<asp:GridView ID="ViewPenyewa" runat="server"  Align="Left">
 </asp:GridView>
         <asp:GridView ID="ViewBluray" runat="server" Align="Right">
 </asp:GridView>
         <br />
         <br /><br /><br /><br /><br /><br /><br /><br />
         Status Penyewaan :<asp:GridView ID="ViewPenyewaan" runat="server" >
 </asp:GridView>
 </form>
</body>
</html>