<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="_30_11_task.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p>
        &nbsp;</p>
    <form id="form1" runat="server">
        Enter First Num&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="input1" runat="server" BackColor="#CCCCCC"></asp:TextBox>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter Second Num"></asp:Label>
            <asp:TextBox ID="input2" runat="server" BackColor="#CCCCCC"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Value="></asp:Label>
            <asp:TextBox ID="output" runat="server" BackColor="#CCCCCC" style="margin-left: 91px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="sum" runat="server" OnClick="sum_Click" style="margin-left: 121px" Text="+" Width="40px" />
        <asp:Button ID="sub" runat="server" OnClick="sub_Click" style="margin-left: 29px" Text="-" Width="40px" />
        <asp:Button ID="div" runat="server" style="margin-left: 32px" Text="÷" Width="40px" OnClick="div_Click" />
        <asp:Button ID="multi" runat="server" style="margin-left: 34px" Text="*" Width="35px" OnClick="multi_Click" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
