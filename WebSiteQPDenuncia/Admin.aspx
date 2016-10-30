<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<!DOCTYPE html>
<!--[if lt IE 7]>      <html class="no-js lt-ie9 lt-ie8 lt-ie7"> <![endif]-->
<!--[if IE 7]>         <html class="no-js lt-ie9 lt-ie8"> <![endif]-->
<!--[if IE 8]>         <html class="no-js lt-ie9"> <![endif]-->
<!--[if gt IE 8]><!-->
<html class="no-js">
<!--<![endif]-->


<html xmlns="http://www.w3.org/1999/xhtml">
<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
    <title></title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width">

    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/bootstrap-responsive.css">
    <link rel="stylesheet" href="css/custom-styles.css">
    <link rel="stylesheet" href="css/font-awesome.css">
    <link rel="stylesheet" href="css/component.css">
    <link rel="stylesheet" href="css/font-awesome-ie7.css">
    <script src="js/modernizr-2.6.2-respond-1.1.0.min.js"></script>
    <script src="Scripts/jquery-3.1.0.min.js"></script>
    <script src="ckJS/jquery.cookie.js"></script>
    <script src="Scripts/ControlAdmin.js"></script>

</head>
<body>
    <!--[if lt IE 7]>
            <p class="chromeframe">You are using an <strong>outdated</strong> browser. Please <a href="http://browsehappy.com/">upgrade your browser</a> or <a href="http://www.google.com/chromeframe/?redirect=true">activate Google Chrome Frame</a> to improve your experience.</p>
        <![endif]-->
    <!-- This code is taken from http://twitter.github.com/bootstrap/examples/hero.html -->
    <div class="header-wrapper">
        <div class="container">
            <div class="logo">
                <h1>¿Qué paso con mi denuncia?</h1>
            </div>
            <div class="menu">
                <div class="navbar">
                    <a class="btn btn-navbar" data-toggle="collapse" data-target=".nav-collapse">
                        <i class="fw-icon-th-list"></i>
                    </a>
                    <div class="nav-collapse collapse">
                        <ul class="nav">
                            <li><a href="#">Inicio</a></li>
                            <li><a href="#">Acerca</a></li>
                            <li>
                                <div class="site-name">
                                    <h1>¿Que paso</h1>
                                    <h2>con mi</h2>
                                    <h1>denuncia?</h1>
                                </div>
                            </li>
                            <li><a href="#">FAQ</a></li>
                            <li><a href="#">Contacto</a></li>
                        </ul>
                    </div>
                    <!--/.nav-collapse -->
                </div>
            </div>
        </div>
    </div>
    <div class="banner">
        <div class="featured-blocks" style="background-color: #f5e2e2">
            <label>Folio:</label>
            <input type="text" id="txtBuscar" />
            <a role="button" class="btn" id="btnBuscar" data-toggle="modal">Buscar </a>
        </div>
    </div>
    <div class="featured-blocks">
        <div class="container">
            <div id="divHistoricos"></div>


        </div>


        <div>
            <div id="popRespuesta" class="modal hide fade" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
            </div>
        </div>


    </div>
                <div class="footer-wrapper">
                    <div class="container">
                        <div class="site-footer">
                            <div class="row-fluid">
                                <div class="span3">
                                    <div class="block">
                                        <h1>QuePaso TEAM</h1>
                                        <ul>
                                            <li><a href="#">Edgardo Calderon</a></li>
                                            <li><a href="#">Fernando Ricardez</a></li>
                                            <li><a href="#">Kevin Marquez</a></li>
                                            <li><a href="#">Rafael Gomez</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class="span3">
                                    <div class="block">
                                        <h1>Universidad De La Salle Bajio</h1>
                                    </div>
                                </div>
                                <div class="span3">
                                    <div class="block">
                                        <h1>HackBAjio e-gov</h1>
                                    </div>
                                </div>
                                <div class="span3">
                                    <div class="block">
                                        <h1>Contacto</h1>
                                        <ul>
                                            <li>

                                                <i class="fw-icon-mobile-phone icon2"></i>

                                                <div class="info">
                                                    <span>Hablanos</span><br>
                                                    <a href="#">(+52) 477 3095020</a>
                                                </div>
                                            </li>
                                            <li>

                                                <i class="fw-icon-envelope-alt icon2"></i>

                                                <div class="info">
                                                    <span>Un correo</span><br>
                                                    <a href="#">qpcmd@gmail.com</a>
                                                </div>
                                            </li>

                                        </ul>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="copy-rights">
                            Copyright (c) websitename. All rights reserved. Designed by :  <strong><a href="http://www.alltemplateneeds.com">www.alltemplateneeds.com</a></strong><br>
                            Images From . <a href="http://www.photorack.net">www.photorack.net </a>/<a href="http://www.wallcoo.net"> www.wallcoo.net</a>
                        </div>
                    </div>
                </div>


    <script src="js/jquery-1.9.1.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/masonry.pkgd.min.js"></script>
    <script src="js/imagesloaded.js"></script>
    <script src="js/classie.js"></script>
    <%--<script src="js/AnimOnScroll.js"></script>--%>

    <%--<script>
      new AnimOnScroll( document.getElementById( 'grid' ), {
        minDuration : 0.4,
        maxDuration : 0.7,
        viewportFactor : 0.2
      } );
    </script>--%>
    <script>
        $('#myCarousel').carousel({
            interval: 1800
        });
    </script>
</body>
</html>
