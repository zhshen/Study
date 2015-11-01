<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AngularTemplates.aspx.cs" Inherits="PhoneCat.demos.AngularTemplates" %>

<!doctype html>
<html lang="en" ng-app="phonecatApp">
<head>
    <meta charset="utf-8">
    <title>My HTML File</title>
    <link rel="stylesheet" href="../lib/bootstrap-3.3.5-dist/css/bootstrap.min.css">
    <link rel="stylesheet" href="../css/app.css">
    <script src="../lib/angular/angular.min.js"></script>
    <script src="AngularTemplatesController.js"></script>
</head>
<body ng-controller="PhoneListCtrl">
    <ul>
        <li ng-repeat="phone in phones">{{phone.name}}
            <p>{{phone.snippet}}</p>
        </li>
    </ul>
</body>
</html>
