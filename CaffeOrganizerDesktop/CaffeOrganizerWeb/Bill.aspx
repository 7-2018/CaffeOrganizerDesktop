<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="CaffeOrganizerWeb.Bill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-6">
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                </div>
            <div class="col-6">
                <div class="row">
                    <div class="col-6">
        <asp:ListBox ID="ListBox2" runat="server"></asp:ListBox><br />
                <button id="dodaj" runat="server" onserverclick="dodaj_ServerClick" >Dodaj na racun</button>
                        </div>
                    <div class="col-6">
                         <button id="Pica" runat="server" onserverclick="Pica_ServerClick" >Pica</button>
                    </div>
                </div>
                
                </div>
            </div>
        <asp:Label ID="Label1" runat="server" Text="Total"></asp:Label>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
<script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</body>
</html>
