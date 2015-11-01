<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemplatingLinksImages.aspx.cs" Inherits="PhoneCat.demos.TemplatingLinksImages" %>

<!doctype html>
<html lang="en" ng-app="phonecatApp">
<head>
    <meta charset="utf-8">
    <title>My HTML File</title>
    <link rel="stylesheet" href="../lib/bootstrap-3.3.5-dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/app.css">
    <script src="../lib/angular/angular.min.js"></script>
    <script src="../lib/angular/angular-route.min.js"></script>
    <script src="app.js"></script>
    <script src="controllers.js"></script>
</head>
<body>
    <div ng-view></div>
</body>
</html>
