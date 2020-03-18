<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="WebApplication2.View.Main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 606px; width: 1144px">
    <form id="form1" runat="server">
        <div>
            <div style="height: 602px; width: 1137px">
                <div style="width: 500px; height: 400px; top: 500px; right: 10px; clip: rect(300px, auto, auto, auto); left: 100px;">
                    <input id="File1" type="file" /><asp:Image ID="Image1" runat="server" />
                    <asp:ImageButton ID="ImageButton1" runat="server" />
                    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
                    <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="查看SEssion" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>
