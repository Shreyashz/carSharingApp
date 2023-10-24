<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Req.aspx.cs" Inherits="carSharingApp.Req" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table cellpadding="7" cellspacing="7" >
            <tr>
                <td class="auto-style2" colspan="2" style="color:deepskyblue">Login Page For <br />Users</td>
            </tr>
            <tr>
                <td >Vehicle Id</td>
                <td>
                    <asp:TextBox ID="vehTextBox" runat="server" Width="233px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="VehTextBox" Display="Dynamic" ErrorMessage="Please enter Vehicle Id" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >TO</td>
                <td>
                    <asp:TextBox ID="ToTextBox" runat="server" Width="231px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ToTextBox" Display="Dynamic" ErrorMessage="Please Enter Owner Of the vehicle" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="center">
                    <asp:Button  ID="Button1" runat="server" Height="29px" Text="Request" Width="59px" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>
    </div>
</form>
</body>
</html>
