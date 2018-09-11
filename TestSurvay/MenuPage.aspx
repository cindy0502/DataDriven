<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MenuPage.aspx.cs" Inherits="TestSurvay.MenuPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Button ID="Button1" runat="server"  Text="Register" Width="120px" BackColor="#94CFC9" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Admin" Width="120px" BackColor="#CEF19E" OnClick="Button2_Click" />
        </p>
    </div>
        
    </form>
</body>
</html>
