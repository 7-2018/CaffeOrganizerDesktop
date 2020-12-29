<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bills.aspx.cs" Inherits="CaffeOrganizerWeb.Bills" %>

<!doctype html>
<html lang="en">
<head runat="server">
    <title></title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">

    <link href="https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700,800,900" rel="stylesheet">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
    <link rel="stylesheet" href="css/stylefikss.css">
</head>
<body style="background-image: url('images/bg_2.jpg');">

    <div class="wrapper d-flex align-items-stretch">
        <nav id="sidebar">
            <div class="custom-menu">
                <button type="button" id="sidebarCollapse" class="btn btn-primary">
                    <i class="fa fa-bars"></i>
                    <span class="sr-only">Toggle Menu</span>
                </button>
            </div>
            <div class="p-4">
                <h1><a href="index.html" class="logo" style="color: #babebe;">Caffe Organizer<span id="curworker" runat="server" style="color: rgb(128, 128, 128);">Caffe Elixir</span></a></h1>
                <ul class="list-unstyled components mb-5">
                    <li class="active">
                        <a href="Home.aspx"><span class="fa fa-sitemap mr-3" aria-hidden="true" style="color: #babebe;"></span>Stolovi</a>
                    </li>
                    <li>
                        <a href="Bills.aspx"><span class="fa fa-money mr-3" aria-hidden="true" style="color: #babebe;"></span>Dnevni izveštaj</a>
                    </li>
                    <li>
                        <a href="Login.aspx"><span class="fa fa-user-circle-o mr-3" aria-hidden="true" style="color: #babebe;"></span>Odjavljivanje</a>
                    </li>
                </ul>
            </div>
    </nav>

        <!-- Page Content  -->
    <div id="content" class="p-4 p-md-5 pt-5">
        <form id="form1" runat="server">
            <div id="maindiv" runat="server" style="color: white" class="row text-center">
                <div class="col-12">
                    <h1 style="font-family: 'Times New Roman'; text-align: center; color: darkred; text-transform: uppercase; font-weight: 700;">Dnevni izveštaj:</h1>
                </div>
            </div>
            <div class="col-12 mx-0 px-0">
                <h3 class=" mb-3" style="color:white;">Pošalji dnevni izveštaj na e-mail</h3>
                <input type="text" id="emailtx" runat="server" class="form-control bg-dark w-25 mx-0" style="color: white" placeholder="Unesi e-mail adresu"></div>
            <button type="button" runat="server" id="buttonemail" onserverclick="buttonemail_ServerClick" class="btn btn-secondary mt-4">Pošalji</button>
        </form>
    </div>
    </div>

    <script src="js/jquery.min.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main2.js"></script>
</body>
</html>
