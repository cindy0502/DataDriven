<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchCriteria.aspx.cs" Inherits="TestSurvay.SearchCriteria" %>

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
    
        <asp:Label ID="Label1" runat="server" Font-Size="Larger" Text="SEARCH CRITERIA"></asp:Label>
    
    </div>
       <div align="center">
           <br />
           <br />
        <asp:Label ID="Label2" runat="server" Text="Search by: " Font-Bold="True" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>First Name</asp:ListItem>
            <asp:ListItem>Last Name</asp:ListItem>
            <asp:ListItem>Gender</asp:ListItem>
            <asp:ListItem>Email</asp:ListItem>
            <asp:ListItem>Address</asp:ListItem>
            <asp:ListItem>State/Territory</asp:ListItem>
            <asp:ListItem>Postcode</asp:ListItem>
            <asp:ListItem>Bank Used</asp:ListItem>
            <asp:ListItem>Bank Services</asp:ListItem>
            <asp:ListItem>Newspaper Read</asp:ListItem>
        </asp:DropDownList>
           <br />
           <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" Height="34px" Width="650px"></asp:TextBox>
           <br />
           <br />
           <br />
           <asp:Button ID="Button1" runat="server" BackColor="#CEF19E" Height="28px" Text="Search" Width="234px" OnClick="Button1_Click" />
           <br />
           <br />
           <br />
           <br />
           <br />
       </div>

        <div style="height:100px;background-color:#CEF19E" align="center">
    
        <br />
        <br />
    
        <asp:Label ID="Label3" runat="server" Font-Size="Larger" Text="SEARCH RESULTS"></asp:Label>
    
    </div>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="188px" Width="1347px" align="center">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField HeaderText="FirstName" />
                <asp:BoundField HeaderText="LastName" />
                <asp:BoundField HeaderText="Gender" />
                <asp:BoundField HeaderText="Email" />
                <asp:BoundField HeaderText="Address" />
                <asp:BoundField HeaderText="State/Territory" />
                <asp:BoundField HeaderText="Postcode" />
                <asp:BoundField HeaderText="Bank Used" />
                <asp:BoundField HeaderText="Bank Services" />
                <asp:BoundField HeaderText="Newspaper Read" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</body>
</html>
