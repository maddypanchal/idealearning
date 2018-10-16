<%@ Page Title="" Language="C#" MasterPageFile="~/Public/MasterPage.master" AutoEventWireup="true" CodeFile="Store.aspx.cs" Inherits="Public_Store" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="Description" content="Best web template store is available with Yooneek IT Solutions. We design web2.0 templates. Our cutom high quality templates provide great looks to the websites of small and big business as well" />
    <meta name="Keywords" content="Best Templates in India, Custom Templates, Best web templates India, Template Store India, Graphic Design India, Best Logo Design Haryana, Business Card Design Kurukshetra" />
    <title>Yooneek Portfolio</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script src="prettyPhoto/js/jsapi.js" type="text/javascript"></script>
    <script type="text/javascript" charset="utf-8">
        google.load("jquery", "1.3");
    </script>
    <link rel="stylesheet" href="prettyPhoto/css/prettyPhoto.css" type="text/css" media="screen"
    title="prettyPhoto main stylesheet" charset="utf-8" />
    <script src="prettyPhoto/js/jquery.prettyPhoto.js" type="text/javascript" charset="utf-8"></script>
    <style type="text/css" media="screen">
       ul li
        {
            display: inline;
        }
        .wide
        {
            border-bottom: 1px #000 solid;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="content_about2">
     <div class="content_train_WAR2">
     <div class="out_form">
     <div class="image_gallery_out">
     <ul class="gallery clearfix">
     <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;">
                            <a href="prettyPhoto/images/fullscreen/1.jpg" rel="prettyPhoto[gallery2]"><img src="prettyPhoto/images/thumbnails/t_1.jpg" width="215" height="250" alt="" /></a></li>
                            <div class="ribbon">
                            <a href="#">
                                <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                            <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/5.jpg"
                            rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_5.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/6.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_6.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/7.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_7.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/8.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_8.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/9.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_9.jpg" width="215" height="250" alt="" /></a></li>
                        <div class="ribbon">
                            <a href="#">
                                <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/10.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_10.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                        <li style="margin: 20px 20px 0  0px; border: 1px solid #FFFFFF; box-shadow: 1px 1px 2px  0 #000;
                            width: 215px; height: 250px; float: left;"><a href="prettyPhoto/images/fullscreen/11.jpg"
                                rel="prettyPhoto[gallery2]">
                                <img src="prettyPhoto/images/thumbnails/t_11.jpg" width="215" height="250" alt="" /></a></li><div
                                    class="ribbon">
                                    <a href="#">
                                        <img src="prettyPhoto/images/thumbnails/ribbon.png" /></a></div>
                     
                    </ul>
                    <div class="another">
                    </div>
                    <script type="text/javascript" charset="utf-8">
                        $(document).ready(function () {
                            $(".gallery a[rel^='prettyPhoto']").prettyPhoto({ theme: 'facebook' });
                        });
                    </script>
                </div>
            </div>
        </div>
        <div class="contact2_bottom">
        </div>
    </div>
</asp:Content>

