<%@ Page Title="" Language="C#" MasterPageFile="~/timepass.master" AutoEventWireup="true" CodeFile="service.aspx.cs" Inherits="service" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h2>Our Services</h2>
    <div class="row">
        <div class="col-md-4">
            <div class="card mb-4">
                <img class="card-img-top" src="image/gym.jpeg">
                <div class="card-body">
                    <h5 class="card-title">Gym</h5>
                    <p class="card-text">This can include details about what the service offers and how students can benefit from it.</p>
                    <a href="#" class="btn btn-primary">Learn More</a>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card mb-4">
                <img class="card-img-top" src="image/baseball.jpg">
                <div class="card-body">
                    <h5 class="card-title">Baseball</h5>
                    <p class="card-text">This can include details about what the service offers and how students can benefit from it.</p>
                    <a href="#" class="btn btn-primary">Learn More</a>
                </div>
            </div>
        </div>
        <div class="col-md-4">
            <div class="card mb-4">
                <img class="card-img-top" src="image/auditorium.JPG">
                <div class="card-body">
                    <h5 class="card-title">Auditorium</h5>
                    <p class="card-text">This can include details about what the service offers and how students can benefit from it.</p>
                    <a href="#" class="btn btn-primary">Learn More</a>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

