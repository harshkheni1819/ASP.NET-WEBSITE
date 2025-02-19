<%@ Page Language="C#" AutoEventWireup="true" CodeFile="item_dis.aspx.cs" Inherits="item_dis" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnsumit_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1000px;
        }
        .auto-style2 {
            width: 165px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Item Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtiname" runat="server" Width="186px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Item Price"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtprice" runat="server" Width="188px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Item Qty"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtqty" runat="server" Width="185px"></asp:TextBox>
   &nbsp;</td>
                <td>
                    <asp:Button ID="btnsumit" runat="server" Text="Submit" OnClick="btnsumit_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnreset" runat="server" Text="Reset" />
                </td>
            </tr>
        </table>
    
    </div>
        <div id="                                                                                                                                                                                                                                                                                                                                  ">

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" DataKeyNames="Item_id" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnRowDeleting ="GridView1_RowDeleting" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="item_id" HeaderText="Item Id" ReadOnly="True" />
                    <asp:BoundField DataField="iname" HeaderText="Item Name" />
                    <asp:BoundField DataField="price" HeaderText="Item Price" />
                    <asp:BoundField DataField="qty" HeaderText="Item qty" />
                    <asp:CommandField ButtonType="Button" ShowEditButton="True" />
                    <asp:CommandField ButtonType="Button" ShowDeleteButton="True" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>

            ss</div>
    </form>
</body>
</html>
