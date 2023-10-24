<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="carSharingApp.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
    form{
        margin-top:60px;
    }
    
    button:hover{
        background-color:aqua;
    }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="button1">
            <asp:Button ID="Button2" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Logout_Leave" Text="Logout" CssClass="auto-style1" Height="37px" Width="105px" />
            <asp:Button ID="UserButton" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="User_Leave" CssClass="auto-style2" Height="37px" Width="115px" />
        </div>
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSourceCarpool" AutoGenerateColumns="False" AllowSorting="True" AllowPaging="True" DataKeyNames="VehicalId">
            <Columns>
                <asp:BoundField DataField="VehicalId" HeaderText="VehicalId" ReadOnly="True" InsertVisible="False" SortExpression="VehicalId"></asp:BoundField>
                <asp:BoundField DataField="Vechicle name" HeaderText="Vechicle name" SortExpression="Vechicle name"></asp:BoundField>
                <asp:BoundField DataField="Satrting Location" HeaderText="Satrting Location" SortExpression="Satrting Location"></asp:BoundField>
                <asp:BoundField DataField="Destination" HeaderText="Destination" SortExpression="Destination"></asp:BoundField>
                <asp:BoundField DataField="By" HeaderText="By" SortExpression="By"></asp:BoundField>
                <asp:BoundField DataField="Gender" HeaderText="Gender" SortExpression="Gender"></asp:BoundField>
                <asp:BoundField DataField="Trip Date" HeaderText="Trip Date" SortExpression="Trip Date"></asp:BoundField>
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName"></asp:BoundField>
            </Columns>
            
            
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <div>
        <table cellpadding="7" cellspacing="7" >
            <tr>
                <td class="auto-style2" colspan="2" style="color:deepskyblue">Add Request</td>
            </tr>
            <tr>
                <td >Vehicle Id</td>
                <td>
                    <asp:TextBox ID="vehTextBox" runat="server" Width="233px" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="VehTextBox" Display="Dynamic" ValidationGroup="Request"  ErrorMessage="Please enter Vehicle Id" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td >TO</td>
                <td>
                    <asp:TextBox ID="ToTextBox" runat="server" Width="231px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="ToTextBox" Display="Dynamic" ValidationGroup="Request" ErrorMessage="Please Enter Owner Of the vehicle" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td colspan="2" class="center">
                    <asp:Button  ID="Button1" runat="server" Height="29px" Text="Request" Width="59px" OnClick="Button1_Click" ValidationGroup="Request"/>
                </td>
            </tr>
        </table>
    </div>
        <asp:SqlDataSource runat="server" ID="SqlDataSourceCarpool" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="select Carpool.[Id] as [VehicalId], [VehicalName] as [Vechicle name], [From] as [Satrting Location], [To] as [Destination], [firstname] as [By], gender as [Gender] , [date] as [Trip Date], [By] as [UserName] from Carpool INNER JOIN Users on [By] = [uName];"></asp:SqlDataSource>
    </form>
</body>
</html>
