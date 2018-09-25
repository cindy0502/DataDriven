<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="TestSurvay.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div style="height:100px;background-color:#CEF19E" align="center">
    
        <br />
        <br />
    
        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="SEARCH CRITERIA"></asp:Label>
    
    </div>
    <div align="center">
    
        <br />
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Font-Size="Large" Text="Admin Login"></asp:Label>
           <p>
               &nbsp;</p>
        <p>
            Username</p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" Width="131px" BackColor="#CEF19E" />
    
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" ForeColor="Red" Text="Username: student6011"></asp:Label>
        <br />
        <asp:Label ID="Label4" runat="server" ForeColor="Red" Text="Password: 123456"></asp:Label>
        <br />
    
    </div>
     
        
     
    </form>
</body>
</html>
