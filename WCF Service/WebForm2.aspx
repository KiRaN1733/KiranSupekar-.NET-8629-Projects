<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WCFservice.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <table style="margin-left: 35%; height: 122px;">
            <tr>
                <td>
                    <asp:Label ID="lbl_id" runat="server" Text="Cust_Id: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbl_name" runat="server" Text="Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Mobile</td>
                <td>
                    <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
                </td>
            </tr>

            <tr>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" />
                    <br />
                </td>
            </tr>

        </table>

        <span style="font-weight:900;margin-left:30%">Note: </span><span style="font-style:italic;">You can not set <span style="font-weight:700"> Cust_Id</span> because that column is set as primary key.</span>
    </form>
</body>
</html>
