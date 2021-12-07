<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFservice.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="Customer_id" HeaderText="Cust_Id" ItemStyle-Width="70" />
                <asp:BoundField DataField="Customer_name" HeaderText="Name" ItemStyle-Width="180" />
                <asp:BoundField DataField="Customer_mobile" HeaderText="Mobile" ItemStyle-Width="70" />
            </Columns>
        </asp:GridView>
        <p>
            <asp:Button ID="btnInsert1" runat="server" OnClick="Button1_Click" Text="Insert" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnDelete1" runat="server" OnClick="btnDelete1_Click" Text="Delete" />
        </p>
    </form>
</body>
</html>
