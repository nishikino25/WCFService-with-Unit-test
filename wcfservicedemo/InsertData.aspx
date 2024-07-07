<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertData.aspx.cs" Inherits="WcfServiceDemo.InsertData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>    
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <title>Insert Data</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-wEmeIV1mKuiNpC+IOBjI7aAzPcEZeedi5yW5f2yOq55WWLwNGmvvx4Um1vskeMj0" crossorigin="anonymous">
</head>

<body>
    <form id="form1" runat="server" class="container mt-5">
        <div class="form-group">
            <label for="txtOffice">Office:</label>
            <asp:TextBox ID="txtOffice" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtItem">Item:</label>
            <asp:TextBox ID="txtItem" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtCompany">Company:</label>
            <asp:TextBox ID="txtCompany" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSaleQ4">Sale Q4:</label>
            <asp:TextBox ID="txtSaleQ4" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSaleQ3">Sale Q3:</label>
            <asp:TextBox ID="txtSaleQ3" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSaleQ2">Sale Q2:</label>
            <asp:TextBox ID="txtSaleQ2" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtSaleQ1">Sale Q1:</label>
            <asp:TextBox ID="txtSaleQ1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtReqDate">Request Date:</label>
            <asp:TextBox ID="txtReqDate" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtOrderNo">Order No:</label>
            <asp:TextBox ID="txtOrderNo" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtCurrency">Currency:</label>
            <asp:TextBox ID="txtCurrency" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="txtPrice">Price:</label>
            <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        
        <div class="form-group">
            <label for="txtMSP">MSP:</label>
            <asp:TextBox ID="txtMSP" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="mt-2 align-middle">            
            <asp:Button ID="Button1" runat="server" Text="Insert" CssClass="btn btn-primary mt-2" OnClick="btnInsert_Click" />
            <asp:Label ID="lblMessage" runat="server" CssClass="text-danger mt-3 ms-3"></asp:Label>
        </div>
    </form>

    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.0.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-p34f1UUtsS3wqzfto5wAAmdvj+osOnFyQFpp4Ua3gs/ZVWx6oOypYoCJhGGScy+8" crossorigin="anonymous"></script>
</body>
</html>
