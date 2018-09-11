<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCriteria.aspx.cs" Inherits="TestSurvay.SearchCriteria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div  style="height:100px;background-color:#CEF19E" align="center">
      
    
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="SEARCH CRITERIA"></asp:Label>
        <br />
    
        </div>
            <br />
        <div align="center">
            <br />
        First name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last name<p>
            <asp:TextBox ID="TextBox1" runat="server" Width="270px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox10" runat="server" Width="270px"></asp:TextBox>
        </p>
        <p>
            Age range&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Gender</p>
        <p>
        &nbsp;&nbsp;<asp:DropDownList ID="DropDownList1" runat="server" Width="275px">
                <asp:ListItem>18-25</asp:ListItem>
                <asp:ListItem>26-32</asp:ListItem>
                <asp:ListItem>33-38</asp:ListItem>
                <asp:ListItem>39 +</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="DropDownList2" runat="server" Width="275px">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:DropDownList>
        </p>
        &nbsp;Email<p>
            <asp:TextBox ID="TextBox7" runat="server" Width="570px"></asp:TextBox>
        </p>
        &nbsp;Address<p>
            <asp:TextBox ID="TextBox12" runat="server" Width="570px"></asp:TextBox>
        </p>
            <br />
        State/Territory&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Post code<p>
            <asp:TextBox ID="TextBox13" runat="server" Width="270px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox14" runat="server" Width="270px"></asp:TextBox>
        </p>
        &nbsp;Bank used<p>
            <asp:TextBox ID="TextBox15" runat="server" Width="570px"></asp:TextBox>
        </p>
        &nbsp;Bank services<p>
            <asp:TextBox ID="TextBox16" runat="server" Width="570px"></asp:TextBox>
        </p>
        &nbsp;Newspaper read <p>
            <asp:TextBox ID="TextBox17" runat="server" Width="570px"></asp:TextBox>
            
        </p>
        <p>
            &nbsp;<p>
            <asp:Button ID="Button1" runat="server" Text="Search" Width="277px" BackColor="#CEF19E" OnClick="Button1_Click" />
            </div>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
