﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="CaffeOrganizerWeb.Home" %>

<!doctype html>
<html lang="en">
<head runat="server">
    <title>Sidebar 05</title>
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
                <h1><a href="index.html" class="logo" style="color: #babebe;">Caffe Organizer<span id="currwork" runat="server" style="color: rgb(128, 128, 128);">Caffe Elixir</span></a></h1>
                <ul class="list-unstyled components mb-5">
                    <li class="active">
                        <a href="#"><span class="fa fa-sitemap mr-3" aria-hidden="true" style="color: #babebe;"></span>Stolovi</a>
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
                <div id="maindiv" runat="server" style="color: white" class="row">
                </div>
            </form>
        </div>
    </div>

    <script src="js/jquery.min.js"></script>
    <script src="js/popper.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/main2.js"></script>
</body>
</html>
