<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="New.aspx.cs" Inherits="carSharingApp.New" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <div class="button1">
            <asp:Button ID="Button2" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Home_Leave" Text="Home" CssClass="auto-style1" Height="37px" Width="105px" />
            <asp:Button ID="UserButton" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="User_Leave" Text="User" CssClass="auto-style2" Height="37px" Width="115px" />
        </div>
    <div>
        <table cellpadding="5" cellspacing="5" class="auto-style1">
            <tr>
                <td class="auto-style3" colspan="2"> <h2>new Carpool Form</h2></td>
            </tr>
            <tr>
                <td class="auto-style2">Vehicle Name</td>
                <td>
                    <asp:TextBox ID="VehicleNameTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ValidationGroup="Form" Display="Dynamic" ErrorMessage="Please Enter Vehilcle Name" ForeColor="Red" SetFocusOnError="True" ControlToValidate="VehicleNameTextBox">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">From</td>
                <td>
                    <asp:TextBox ID="FromTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ValidationGroup="Form" Display="Dynamic" ErrorMessage="Please Enter Starting Location" ForeColor="Red" SetFocusOnError="True" ControlToValidate="FromTextBox">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            
            <tr>
                <td class="auto-style2">To</td>
                <td>
                    <asp:TextBox ID="ToTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Display="Dynamic" ValidationGroup="Form" ErrorMessage="Please Enter Ending Location" ForeColor="Red" SetFocusOnError="True" ControlToValidate="ToTextBox">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Max Capacity</td>
                <td>
                    <asp:TextBox ID="MaxTextBox" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Display="Dynamic" ValidationGroup="Form" ErrorMessage="Please Enter Max Capacity" ForeColor="Red" SetFocusOnError="True" ControlToValidate="MaxTextBox">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Journey Date</td>
                <td>
                    <asp:Calendar id="JourDate" runat="server">

                       <OtherMonthDayStyle ForeColor="LightGray">
                       </OtherMonthDayStyle>

                       <TitleStyle BackColor="Blue"
                                   ForeColor="White">
                       </TitleStyle>

                       <DayStyle BackColor="gray">
                       </DayStyle>

                       <SelectedDayStyle BackColor="LightGray"
                                         Font-Bold="True">
                       </SelectedDayStyle>

        </asp:Calendar>
                    <asp:customvalidator id="dateCustVal" onservervalidate="DateCustVal_Validate" ValidationGroup="Form" runat="server"> </asp:customvalidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="center">
                    <asp:Button ID="Button1" runat="server" Height="29px" Text="Add Journey" ValidationGroup="Form" OnClick="Button1_Click" />
                </td>
            </tr>
            <tr>
                <td  colspan="2" class="center">
                    <a href="Login.aspx" style="text-align:center"> Go To Login Form </a>
                </td>
            </tr>
        </table>

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" BackColor="#999999" Font-Size="Larger" ForeColor="Red" />



    </div>
</form>
</body>
</html>
