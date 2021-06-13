<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApp3.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Matt's Web App Database Example 1</title>
    <style type="text/css">
        .auto-style1 {
            width: 121px;
        }
    </style>
</head>
<body>
    <center>
    <img src="Mattnosekai_logo1.png" alt="Mattnosekai Logo" width="460" height="460">
    <form id="form1" runat="server">
        <div>
            <table>
            <tr>  
            <td>
                <asp:Label ID="lblContactID" runat="server" Text="ContactID"></asp:Label>
            </td>
            <td colspan="2" class="auto-style1">
                <asp:TextBox ID="txtContactID" runat="server" Width="157px"></asp:TextBox>
             </td>
             </tr>  
             <tr>   
             <td>
                <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
             </td> 
             <td colspan="2" class="auto-style1">
                <asp:TextBox ID="txtName" runat="server" Width="158px"></asp:TextBox>
            </td>
            </tr>
            
            <tr>  
            <td>
                <asp:Label ID="lblMobile" runat="server" Text="Phone"></asp:Label>
            </td>
            <td colspan="2" class="auto-style1">
                <asp:TextBox ID="txtMobile" runat="server" Width="158px"></asp:TextBox>
             </td>
             </tr>    

             <tr>  
            <td>
                <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
            </td>
            <td colspan="2" class="auto-style1">
                <asp:TextBox ID="txtAddress" runat="server" Width="158px"></asp:TextBox>
             </td>
             </tr>   


            </table>
            </div>
             
            <asp:Button ID="Button1" runat="server" Text="Query/Look-up" OnClick="Button1_Click" Width="103px" />
        
            <asp:Button ID="Button2" runat="server" Text="Add/Update" OnClick="Button2_Click" Width="92px" />
        
            <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Button3_Click" Width="92px" /> 

            <asp:Button ID="Button4" runat="server" Text="Clear" OnClick="Button4_Click" Width="92px" />
        <br />
            <asp:Label ID="lblResponse" runat="server" Text=""></asp:Label>
        
    </form>
</center>
</body>
</html>
