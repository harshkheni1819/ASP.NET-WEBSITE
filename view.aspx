<%@ Page Title="" Language="C#" MasterPageFile="~/adminpanel.master" AutoEventWireup="true" CodeFile="view.aspx.cs" Inherits="view" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Book_ID" DataSourceID="SqlDataSource1" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" OnRowDeleting="GridView1_RowDeleting1">
    <Columns>
        <asp:BoundField DataField="Book_ID" HeaderText="Book_ID" InsertVisible="False" ReadOnly="True" SortExpression="Book_ID" />
        <asp:BoundField DataField="Book_Name" HeaderText="Book_Name" SortExpression="Book_Name" />
        <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        <asp:BoundField DataField="Price" HeaderText="Price" SortExpression="Price" />
        <asp:BoundField DataField="Author_Name" HeaderText="Author_Name" SortExpression="Author_Name" />
        <asp:CommandField ButtonType="Button" ShowEditButton="True" />
        <asp:ButtonField ButtonType="Button" CommandName="Delete" Text="Delete" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [lib]"></asp:SqlDataSource>
    <asp:DataList ID="DataList1" runat="server" DataKeyField="Book_ID" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" BackColor="White" BorderColor="Black" BorderStyle="Ridge" BorderWidth="2px" CellPadding="3" CellSpacing="1" GridLines="Both" RepeatColumns="4">
        <FooterStyle BackColor="#C6C3C6" ForeColor="Black" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#E7E7FF" />
        <ItemStyle BackColor="#DEDFDE" ForeColor="Black" />
        <ItemTemplate>
            Book_ID:
            <asp:Label ID="Book_IDLabel" runat="server" Text='<%# Eval("Book_ID") %>' />
            <br />
            Book_Name:
            <asp:Label ID="Book_NameLabel" runat="server" Text='<%# Eval("Book_Name") %>' />
            <br />
            Quantity:
            <asp:Label ID="QuantityLabel" runat="server" Text='<%# Eval("Quantity") %>' />
            <br />
            Price:
            <asp:Label ID="PriceLabel" runat="server" Text='<%# Eval("Price") %>' />
            <br />
            Author_Name:
            <asp:Label ID="Author_NameLabel" runat="server" Text='<%# Eval("Author_Name") %>' />
            <br />
            Image:
            <image src="image/<%#Eval("image") %>" height="150" width="180" />
            <br />
<br />
        </ItemTemplate>
        <SelectedItemStyle BackColor="#9471DE" Font-Bold="True" ForeColor="White" />
    </asp:DataList>
</asp:Content>

