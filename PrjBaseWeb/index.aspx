<%@ Page Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="index.aspx.cs" 
    Inherits="PrjBaseWeb.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Clinica de Emagrecimento</title>
    <style type="text/css">
        .auto-style1 {
            width: 99px;
        }
    </style>
</head>
<body>
    <link href="estilo.css" rel="stylesheet " />
    <form runat="server">
        <div>
            <table style="width: 500px; border: solid">
                <tr>
                    <td colspan="4" style="text-align:center">
                        <h2>Fabrica de Monstros</h2>
                    </td>
                </tr>
                                <tr>
                    <td colspan="4">
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbNome" runat="server" Text="Nome:"></asp:Label>

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="TxNome" runat="server" Width="300px" />
                    </td>
                    <td>
                        <table style="text-align:right; width:100px">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="lbBusca" runat="server" Text="Busca"/>
                                </td>
                                <td>
                                    <asp:TextBox ID="txBusca" runat="server" style="width:30px" />
                                </td>
                                <td>
                                    <asp:Button ID="btOkBusca" runat="server" Text="Ok" OnClick="btOkBusca_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbCpf" runat="server" Text="CPF:"></asp:Label>

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txCpf" runat="server" Width="300px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbDataNascimento" runat="server" Text="Data Nascimento:"></asp:Label>

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txDataNascimento" runat="server" Width="300px"  />
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <table style="text-align:center; width:100%" >
                            <tr>
                                <td style="text-align: left">
                                    <asp:Label ID="lbSexo" runat="server" Text="Sexo:" />
                                </td>
                                <td style="text-align:center">
                                    <asp:RadioButton ID="rbFem" runat="server" GroupName="sex" Text="Fem" />
                                </td>
                                 <td style="text-align:center">
                                    <asp:RadioButton ID="rbMasc" runat="server" GroupName="sex" Text="Masc" />
                                </td>
                                <td style="text-align: center">
                                    <asp:RadioButton ID="rbNra" runat="server" GroupName="sex" Text="Nra" />
                                </td>
                            </tr>

                        </table>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbPeso" runat="server" Text="Peso:" />

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txPeso" runat="server" Width="300px" />
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>

                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbAltura" runat="server" Text="Altura:" />

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txAltura" runat="server" Width="300px" />
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td>&nbsp; </td>
                
                <td>
                        <asp:Label ID="lbResultado" runat="server" Text="Resultado:" />

                    </td>
                    <td style="text-align: center">
                        <asp:TextBox ID="txResultado" ReadOnly="true" runat="server" Width="300px" />
                    </td>

                </tr>
                <tr>
                    <td>&nbsp;  </td>
                </tr>
                <tr>
                    <td colspan="4">
                        <table style="width: 100%"> 
                            <td>&nbsp; </td>

                                <td >
                                    <asp:Button class="button-basic" ID="btOk" runat="server" Text="OK" Width="200px" OnClick="Calcula" />
                                </td>

                                
                                <td>
                                    <asp:Button class="button-basic" ID="btLimpar" runat="server" Text="Limpar" Width="200px" OnClick="btLimpar_Click" />
                                </td>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
