<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bill.aspx.cs" Inherits="CaffeOrganizerWeb.Bill" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/css/bootstrap.min.css" integrity="sha384-TX8t27EcRE3e/ihU7zmQxVncDAy5uIKz4rEkgIXeMed4M0jlfIDPvg6uqKI2xXr2" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css" integrity="sha512-+4zCK9k+qNFUR5X+cKL9EIR+ZOhtIloNl9GIKS57V1MyNsYpYcUrUeQc9vNfzsWfV28IaLL3i96P9sdNyeRssA==" crossorigin="anonymous" />
    <title></title>
</head>
<body style="background-image: url('images/bg_1.jpg'); background-repeat: no-repeat; background-size: 100%;font-family: 'Times New Roman';">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <div class="col-12 text-center mb-5 mt-3">
                    <h3 id="naslov" runat="server"></h3>
                </div>
                <div class="col-6">
                   <div class="card" style="background-color:transparent; color:white; border:1px solid white;">
  <div id="contentmain" runat="server" class="card-body" >
      <h1 style="font-family:'Times New Roman'; font-size:2rem; text-align:center;">Račun</h1>
  </div>
                        <asp:Label CssClass="mx-auto d-block text-center my-3 text-light" style="font-size:1.3rem;" ID="Label1" runat="server" Text="Total"></asp:Label>
</div>
                   
                    <button class="btn btn-dark mt-4 mx-auto d-block" onserverclick="Button3_ServerClick" id="Button3" runat="server" style="font-size: 1.8rem;">Naplati</button><br />
                </div>
                <div class="col-6">

                    <div class="row" >
                        <div class="col-2">
                            <i class="fas fa-glass-whiskey py-3" style="color: white; font-size: 2rem;"></i>
                        </div>
                        <div class="col-10">
                            <select class="form-control btn btn-dark" style="font-size: 2rem;">
                                <option selected disabled hidden>Bezalkoholna pića</option>
                                <option>Coca Cola</option>
                                <option>Sprite</option>
                                <option>Fanta</option>
                                <option>Kvas</option>
                                <option>Schweppes Tonic</option>
                                <option>Schweppes Bitter Lemon</option>
                                <option>Limunada</option>
                                <option>Golf borovnica</option>
                                <option>Golf jabuka</option>
                                <option>Golf breskva</option>
                                <option>Golf jagoda</option>
                                <option>Golf visnja</option>
                                <option>Cedevita</option>
                            </select>
                        </div>
                    </div>
                    <div class="row mt-4">
                        <div class="col-2">
                            <i class="fas fa-beer py-3" style="color: white; font-size: 2rem;"></i>
                        </div>
                        <div class="col-10">
                            <select class="form-control btn btn-dark" style="font-size: 2rem;">
                                <option selected disabled hidden>Pivo</option>
                                <option>Bavaria</option>
                                <option>Heinken</option>
                                <option>Jelen</option>
                                <option>Lav</option>
                                <option>Valjevsko</option>
                                <option>Zajecarsko</option>
                                <option>Staropramen</option>
                                <option>Guiness</option>
                            </select>
                        </div>
                    </div>
                    <div class="row mt-4">
                        <div class="col-2">
                            <i class="fas fa-glass-martini-alt py-3" style="color: white; font-size: 2rem;"></i>
                        </div>
                        <div class="col-10">
                            <select class="form-control btn btn-dark" style="font-size: 2rem;">
                                <option selected disabled hidden>Žestina</option>
                                <option>Tequila(BLANCA)</option>
                                <option>Martini</option>
                                <option>Gin Tonic</option>
                                <option>Chivas Regal 12 years</option>
                                <option>Vodka</option>
                                <option>Malibu</option>
                            </select>
                        </div>
                    </div>
                    <div class="row mt-4">
                        <div class="col-2">
                            <i class="fas fa-mug-hot py-3" style="color: white; font-size: 2rem;"></i>
                        </div>
                        <div class="col-10">
                            <select runat="server" id="toplinapici" class="form-control btn btn-dark" style="font-size: 2rem;">
                                <option selected disabled hidden>Topli napici</option>
                                <option>Espresso sa mlekom</option>
                                <option>Espresso bez mleka</option>
                                <option>Cappuccino</option>
                                <option>Nescafe</option>
                                <option>Topla čokolada</option>
                                <option>Domaći čaj</option>
                            </select>
                            <button id="dodaj" class="btn btn-light mt-4 mx-auto d-block" runat="server" onserverclick="dodaj_ServerClick" style="font-size:1.8rem; font-family: 'Times New Roman';">Dodaj na račun</button>

                        </div>
                    </div>





                </div>
            </div>


        </div>
    </form>
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-ho+j7jyWK8fNQe+A12Hb8AhRq26LrZ/JpcUGGOn+Y7RsweNrtN/tE3MoK7ZeZDyx" crossorigin="anonymous"></script>
</body>
</html>
