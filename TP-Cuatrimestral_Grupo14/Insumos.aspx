<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Insumos.aspx.cs" Inherits="TP_Cuatrimestral_Grupo14.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main aria-labelledby="title">
   
    
    <meta charset="utf-8">
    <meta name = "viewport" content="width=device-width">

    <meta name="description" content = "portfolio de González Luciano">
    <meta name="url" content="https://lucianoGonzález.com">
    <link rel = "icon" href="chico.ico">
    
    <script src="https://kit.fontawesome.com/fb3527f234.js" crossorigin="anonymous"></script>
    
    

    
    <div class="cont_bg">
        <div class="efect_bg"></div>
    </div>
    <div class="cont_sidebar">
        <nav class="sidebar">
            <ul class="nav">
                <li id="btnConocimientos">
                    <a href="#">
                        <i class="fa-solid fa-brain"></i>
                        <div class="tooltip">Conocimientos</div>
                    </a>
                </li>
                <li id="btnProyectos">
                    <a href="#">
                        <i class="fa-solid fa-diagram-project"></i>
                        <div class="tooltip">Proyectos</div>
                    </a>
                </li>
                <li class="active" id="btnMenu">
                    <a href="#">
                        <i class="fa-solid fa-user"></i>
                        <div class="tooltip">Menú</div>
                    </a>
                </li>
                <li id="btnContacto">
                    <a href="#" >
                        <i class="fa-solid fa-address-book"></i>
                        <div class="tooltip">Contacto</div>
                    </a>
                </li>
            </ul>

        </nav>
    </div>

    <div class="container_home" id="contMenu">
        <div class="contenido">
                    <div class="imagen_detail">
                        <img src="imagenes/imagen.jpg" alt="">
                    </div>
                <div class="text_detail">
                    <h1>Luciano González</h1>
                    <span></span>
                    <h2>Mi página web</h2>
                    <p>Bienvenido a mi página web, en esta página encontrará información sobre mis conocimientos
                        además de mis redes y contacto si así lo desea.
                    </p>
                </div>
                <div class="redes">
                    <a href="https://www.linkedin.com/in/luciano-gonz%C3%A1lez-8713151a7/" target="_blank">
                        <i class="fa-brands fa-linkedin"></i>
                    </a>
                    <a href="https://www.facebook.com/profile.php?id=100004292027572" target="_blank">
                        <i class="fa-brands fa-facebook"></i>
                    </a>
                    <a href="https://www.instagram.com/gonzzalez__/" target="_blank">
                        <i class="fa-brands fa-square-instagram"></i>
                    </a>
                </div>
        </div>
    </div>
    <div class="container_Conocimiento" id="contConocimiento">
        <div class="contenido">
                    <h1>Conocimientos</h1>
                    <div class="imagenesConocimiento">
                        <img src="imagenes/c.png" alt="">
                        <img src="imagenes/c++.png" alt="">
                        <img src="imagenes/GitHub.jpg" alt="">
                        <img src="imagenes/sqlServer.jpg" alt="">
                        <img src="imagenes/web.png" alt="">
                    </div>
        </div>
    </div>
    <div class="container_Proyectos" id="contProyectos">
        <div class="contenido">
                    <h1>Proyectos</h1>
        </div>
    </div>
    <div class="container_Contacto" id="contContacto">
        <div class="contenido">
                    <h1>Contacto</h1>
                    <div class="containerForm">
                        <div class="infoForm">
                            <h2>Contactame</h2>
                            <a href="">
                                <i class="fa-solid fa-phone"></i>
                                +54 (011) 55610538
                            </a>
                            <a href="">
                                <i class="fa-solid fa-envelope"></i>
                                luchogon1002@hotmail.com
                            </a>
                            <form action="" autocomplete="off">
                                <input type="text" name="nombre"
                                placeholder="Ingrese su nombre"
                                class="campo">
                                <input type="email" name="email"
                                placeholder="Ingresa tu correo"
                                class="campo">
                                <textarea name="mensaje"
                                placeholder="Ingresa tu mensaje">
                                </textarea>
                                <input type="submit" name="enviar"
                                value="Enviar mensaje" class="btn-enviar">
                            </form>
                        </div>
                    </div>
        </div>
    </div>


    </main>
</asp:Content>
