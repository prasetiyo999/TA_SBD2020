<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LIstPenyewAdmin.aspx.cs" Inherits="TA_SBD.LIstPenyewAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
 <div>
     <td>PENYEWA</td>
     <br />
    <br />
 <table>
      <tr>
 <td>Id Penyewa :</td>
 <td><asp:TextBox ID="txtIdPenyewa"
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
 <td>Email :</td>
 <td><asp:TextBox ID="txtEmail"
runat="server"></asp:TextBox></td>
 </tr>
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
    <asp:Button ID="btnPenyimpanan" runat="server"
Text="Penyimpanan>>" BackColor ="Orange" Font-Bold OnClick="btnPenyimpanan_Click"/>
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
         Daftar Penyewa :<asp:GridView ID="ViewPenyewa" runat="server" >
 </asp:GridView>
 </form>
</body>
</html>
