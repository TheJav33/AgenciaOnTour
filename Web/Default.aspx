<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID_USR" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="ID_USR" HeaderText="ID_USR" ReadOnly="True" SortExpression="ID_USR" />
                    <asp:BoundField DataField="LOGIN_USR" HeaderText="LOGIN_USR" SortExpression="LOGIN_USR" />
                    <asp:BoundField DataField="PASS_USR" HeaderText="PASS_USR" SortExpression="PASS_USR" />
                    <asp:BoundField DataField="ID_TIPO_USUARIO" HeaderText="ID_TIPO_USUARIO" SortExpression="ID_TIPO_USUARIO" />
                    <asp:BoundField DataField="ACTIVO" HeaderText="ACTIVO" SortExpression="ACTIVO" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionStringOnTour %>" ProviderName="<%$ ConnectionStrings:ConnectionStringOnTour.ProviderName %>" SelectCommand="SELECT * FROM &quot;USUARIO&quot;"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
