<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Survay.aspx.cs" Inherits="TestSurvay.Survay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
         <div style="height:100px;background-color:#94CFC9" align="center">
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Font-Size="Larger" Text="AIT RESEARCH SURVEY"></asp:Label>
        <br />
        <br />
        <br />
    
        </div>
    <div align="center">

        <br />
        <br />

        <asp:Label ID="QuestionText" runat="server" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Next" OnClick="Button1_Click" Width="155px" BackColor="#94CFC9" />
        <br />
        <asp:Label ID="Label1" runat="server" ></asp:Label>
    </div>
    </form>
</body>
</html>
