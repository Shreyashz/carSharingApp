<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="carSharingApp.User" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Student Page</title>
    <style >
        .PlaceHolder{
    
            margin:auto;
   
            width:400px;
        }
        .PlaceHolder4{
            
           margin:auto;
           
           width:400px;
        }
        .PlaceHolder2{
    
           margin:auto;
   
           width:400px;
        }
        .PlaceHolder3{
    
           margin:auto;
   
           width:400px;
        }
        .Label1{
            margin:auto;
            width:250px;
            color:green;
            font-size:25px;
        }
        .Label2{
            margin:auto;
            width:250px;
            color:green;
            font-size:25px;
        }
        .Label3{
            margin:auto;
            width:250px;
            color:green;
            font-size:25px;
        }
        .Heads{
            margin-left:105px;
            margin:auto;
            width:250px;
            color: green;
            font-size: 25px;
        }
        .auto-style1 {
            margin-left: 105px;
        }
        .auto-style2 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="button1">
            <asp:Button ID="Button1" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Button1_Click" Text="Logout" CssClass="auto-style1" Height="37px" Width="105px"   />
            <asp:Button ID="Button2" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Button2_Click" Text="Delete Account" CssClass="auto-style2" Height="37px" Width="115px" />
            <asp:Button ID="Button3" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Button3_Click" Text="Home" CssClass="auto-style2" Height="37px" Width="115px" />
        </div>
        <div class="Label1">
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
               
        <br />

        <div class="Label2">
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </div>
        
               

        
        
        <br />
            <label class="Heads">Your Cars</label>
        <br />
        <asp:Button ID="Button4" runat="server" Font-Size="Larger" ForeColor="Red" OnClick="Button4_Click" Text="New" CssClass="auto-style2" Height="37px" Width="115px" />
        <br />
        <div class="PlaceHolder2">
            <asp:PlaceHolder ID="PlaceHolder2" runat="server"></asp:PlaceHolder>
        </div>
        <br />
        <br />
 
        <br />
            <label class="Heads">Your Requests</label>
        <br />
       <br />
       <div class="PlaceHolder3">
           <asp:PlaceHolder ID="PlaceHolder3" runat="server"></asp:PlaceHolder>
       </div>
       <br />
        <br />
        
        <br />
            <label class="Heads">Requests to you</label>
        <br />
        <br />
        <div class="PlaceHolder4">
            <asp:PlaceHolder ID="PlaceHolder4" runat="server"></asp:PlaceHolder>
        </div>
        <br />
        <br />
        
        <br />
            <label class="Heads">About you</label>
        <br />
        <br />
        <div class="PlaceHolder">
            <asp:PlaceHolder ID="PlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
        <br />
        <br />
    </form>
</body>
</html>
