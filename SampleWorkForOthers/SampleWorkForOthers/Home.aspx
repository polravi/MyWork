<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="SampleWorkForOthers.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formListBox" runat="server">
        <div style="background-color:lightgrey; padding:20px">
     <div style="padding-top:10px;padding-bottom:10px;"> Add New Team Member :  <asp:TextBox id="txtNewTM" runat="server"></asp:TextBox>  <asp:Label ID="lblmessage" runat="server"></asp:Label></div>
     <div><asp:Button runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" Text ="Add TM"  /></div> 
            </div>
        <br />
        <hr />
           <div>
            All Team Members List<br />
        <asp:ListBox id="lstTeamMembers" runat="server" />
    </div>
    </form>
</body>
</html>
