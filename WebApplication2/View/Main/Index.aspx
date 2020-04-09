<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebApplication2.View.Main.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="menu">
            <ul class="nav">
                <li>111</li>
                <asp:Repeater ID="rptNav" runat="server" OnItemDataBound="rptNav_ItemDataBound">
                    <ItemTemplate>
                        <li><a href='<%# DataBinder.Eval(Container.DataItem,"navUrl")%>'>
                            <%# DataBinder.Eval(Container.DataItem,"navTitle") %></a>
                            <asp:Repeater ID="rptSub" runat="server">
                                <HeaderTemplate>
                                    <ul class="sub-nav">
                                </HeaderTemplate>
                                <ItemTemplate>
                                    <li><a href='<%# DataBinder.Eval(Container.DataItem,"navUrl")%>'>
                                        <%# DataBinder.Eval(Container.DataItem,"navTitle") %></a></li>
                                </ItemTemplate>
                                <FooterTemplate>
                                    </ul>
                                </FooterTemplate>
                            </asp:Repeater>
                        </li>
                    </ItemTemplate>
                </asp:Repeater>
            </ul>
        </div>
        <p>
            1111</p>
    </form>
</body>

</html>
