<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="WebApplication2.View.Main.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 661px; width: 1156px">
    <form id="form1" runat="server">
        <div style="width: 1200px; height: 800px; top: 50px; right: 50px; bottom: 20px; left: 20px">
            <div>
                <div style="width: 838px; height: 461px; top: 124px; left: 305px; position: absolute">
                    <asp:GridView ID="GridView1" runat="server">
                        <Columns>
                            <asp:ButtonField Text="按钮" />
                            <asp:CheckBoxField />
                            <asp:CommandField ShowEditButton="True" />
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:CommandField ShowDeleteButton="True" />
                            <asp:DynamicField />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
        <div style="height: 463px; width: 244px; margin-top: 0px; top: 123px; right: 923px; position: absolute; left: 19px; text-align: center;">
            <asp:Menu ID="Menu1" runat="server" BackColor="#FF6699" CssClass="dynamic" Orientation="Horizontal" Width="100px" OnMenuItemClick="Menu1_MenuItemClick1">
                <Items>
                    <asp:MenuItem Text="编号管理" Value="新建项">
                        <asp:MenuItem Text="新建编号" Value="新建项"></asp:MenuItem>
                        <asp:MenuItem Text="可租编号" Value="新建项"></asp:MenuItem>
                        <asp:MenuItem Text="新建项" Value="新建项">
                            <asp:MenuItem Text="新建项" Value="新建项"></asp:MenuItem>
                        </asp:MenuItem>
                    </asp:MenuItem>
                </Items>
            </asp:Menu>
        </div>
    </form>
</body>
</html>
