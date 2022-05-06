<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStockID" runat="server" Text="StockID"></asp:Label>
        <asp:TextBox ID="txtStockID" runat="server" style="margin-left: 45px" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockName" runat="server" Text="StockName"></asp:Label>
        <asp:TextBox ID="txtStockName" runat="server" style="margin-left: 21px" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblStockQuantity" runat="server" Text="StockQuantity"></asp:Label>
        <asp:TextBox ID="txtStockQuantity" runat="server" Width="171px"></asp:TextBox>
        <br />
        <asp:Label ID="lblDateAdded" runat="server" Text="DateAdded"></asp:Label>
        <asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 20px" width="168px"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="margin-left: 67px" width="168px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkAvailable" runat="server" Text="Available" />
        <br />
        <asp:Label ID="lblErrors" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
