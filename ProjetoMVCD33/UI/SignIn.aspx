<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="ProjetoMVCD33.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Content/bootstrap.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-top:10%;" class="row">
            <div class="col-4">        
                
            </div>
            <div class="col-4">        
                <div class="row">
                    <asp:Label Font-Size="18px" runat="server">Consulta de Benefício</asp:Label>
                </div>
                

                <asp:Label runat="server">CPF</asp:Label>
                <asp:TextBox ID="txtCpfD33" runat="server" type="number" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ControlToValidate="txtCpfD33" 
                    runat="server" ID="cpf_validar" 
                    ErrorMessage="Campo CPF é obrigatório"
                    ForeColor="Red"/>
                <br />


                <asp:Label runat="server">Nome Completo</asp:Label>
                <asp:TextBox ID="txtNomeD33" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ControlToValidate="txtNomeD33" 
                    runat="server" ID="nome_validar" 
                    ErrorMessage="Campo Nome é obrigatório"
                    ForeColor="Red"/>
                <br />

                <asp:Label runat="server">Nome da mãe</asp:Label>
                <asp:TextBox ID="txtNomeMaeD33" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator 
                    ControlToValidate="txtNomeMaeD33" 
                    runat="server" ID="nomeMae_validar" 
                    ErrorMessage="Campo Nome da Mãe é obrigatório"
                    ForeColor="Red"/>
                    <br/>

                <asp:Button ID="btn_login" runat="server" text="Consultar" CssClass="btn btn-outline-success btn-block" OnClick="btn_login_Click"/>
                <br />
                <asp:Label ID="erro" runat="server" Visible="false"></asp:Label>
            </div>
            <div class="col-4">        
                
            </div>
        </div>
        
    </form>
</body>
</html>
