<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffStaffNo" runat="server" Text="Staff Number"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffNo" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffFullName" runat="server" Text="Staff Full Name" width="114px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffFullName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffGender" runat="server" Text="Staff Gender" width="82px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="chkMale" runat="server" Text="Male" />
        <asp:CheckBox ID="chkFemale" runat="server" Text="Female" />
        <br />
        <asp:Label ID="lblStaffDOB" runat="server" Text="Staff DOB" width="82px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffDOB" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblStaffActivity" runat="server" Text="Staff Activity" width="98px"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtStaffActivity" runat="server"></asp:TextBox>
        <br />
        &nbsp;&nbsp;
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="Ok" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
