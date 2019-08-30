<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <meta name="description" content="Progrma desenvolvido como forma de avaliação de entrevista de emprego para a Alcoweb" />
    <meta name="author" content="Felipe Luis Pinheiro" />
    <title>Tabuada</title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"  type="text/css" />
    <style>
        table {
            max-width:200px;
            width:200px;
            margin:15px;
            padding:10px;
        }
        .tabuada {
            margin-top:40px;
        }
    </style>
</head>
<body class="container">
    <h1>Tabuada</h1>
    <form id="form1" runat="server">
        <div>
            <p>Quantas Tabuada deseja gerar?</p> 
            <asp:TextBox runat="server" ID="Max" />
            <asp:Button runat="server" ID="GreetButton" Text="Gerar Tabuadas" />
            <br />
            <asp:Label runat="server" ID="Tabuada" CssClass="tabuada"></asp:Label>
            <br />
            
        </div>
    </form>
</body>
</html>
