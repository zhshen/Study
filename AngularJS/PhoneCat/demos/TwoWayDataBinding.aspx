﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TwoWayDataBinding.aspx.cs" Inherits="PhoneCat.demos.TwoWayDataBinding" %>

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
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-2">
                <!--Sidebar content-->
                <div>
                    Search:
                <input ng-model="query">
                </div>
                <div>
                    Sort by:
                <select ng-model="orderProp">
                    <option value="name">Alphabetical</option>
                    <option value="age">Newest</option>
                </select>
                </div>
            </div>
            <div class="col-md-10">
                <!--Body content-->

                <ul class="phones">
                    <li ng-repeat="phone in phones | filter:query | orderBy:orderProp"><span>{{phone.name}}</span>
                        <p>{{phone.snippet}}</p>
                    </li>
                </ul>

            </div>
        </div>
    </div>
</body>
</html>
