<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmLogin.aspx.cs" Inherits="PrjCalculadoraWeb.FrmLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width:200px; border:solid;">

                <tr>
                    
                    <td>
                        <asp:Label ID="lbLogin" runat="server" Text="Login"/>
                    </td>
                    <td>
                        <asp:TextBox ID="TxLogin" runat="server" Width="70px"/>
                    </td>
               
                </tr>




                <tr>
                    <td>
                        <asp:Label ID="lbSenha" runat="server" Text="Senha"/>
                    </td>
                    <td>
                        <asp:TextBox ID="TxSenha" runat="server" Width="70px" TextMode="Password"/>
                    </td>
                </tr>





                  <tr>
                    <td colspan="2" style="text-align:center:">
                        <asp:Button ID="btOk" runat="server" Text="Ok" style="width:90%" OnClick="btOk_Click"/>
                    </td>
                    <td>

                    </td>
               
                  </tr>





                  <tr colspan="2">
                    <td>
                        <asp:Label ID="lbMensagem" runat="server" Text=" - "/>
                    </td>
                    <td>

                    </td>
               
                  </tr>

             </table>
        </div>
    </form>
</body>
</html>
