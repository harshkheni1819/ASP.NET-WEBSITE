<%@ Page Title="" Language="C#" MasterPageFile="~/timepass.master" AutoEventWireup="true" CodeFile="Books.aspx.cs" Inherits="Books" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .px-4 {
        margin-left: 680px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="text-center mx-auto mb-5 wow fadeInUp" data-wow-delay="0.1s" style="max-width: 600px; visibility: visible; animation-delay: 0.1s; animation-name: fadeInUp;">
                <h1 class="d-inline-block border rounded-pill py-1 px-4">BOOKS</h1>
                <h2>Our Most Selling Books</h2>
            </div>
    <br />
    <div class="container">
         <asp:DataList ID="DataList1" runat="server" RepeatColumns="4" Width="1106px" DataSourceID="SqlDataSource1" DataKeyField="Book_ID" BorderColor="Black" BorderWidth="0px" CellPadding="20" CellSpacing="20">
                <ItemTemplate>
                    <div class="card" style="width: 15rem;">
                        <asp:Image ID="book_image" runat="server" class="card-img-top" Height="200px" Width="238px" ImageUrl='<%#Eval("Image","~/image/{0}") %>' />
                    <div class="card-body">
                    <h5 class="card-title"><asp:Label ID="book_nameLabel" runat="server" Text='<%# Eval("Book_Name") %>' /></h5>
                    <p class="card-text"><strong>Price:</strong><asp:Label ID="priceLabel" runat="server" Text='<%# Eval("Price") %>' /></p>
                    <a href="#" class="btn btn-primary">Check Out</a>
                 </div>
                </div>
                </ItemTemplate>
            </asp:DataList>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [lib]"></asp:SqlDataSource>
    </div>
</asp:Content>

