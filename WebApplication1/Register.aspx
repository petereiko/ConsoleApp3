<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebApplication1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        Username
                    </td>
                    <td>
                        <input type="text" id="txtUsername" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Password
                    </td>
                    <td>
                        <input type="password" id="txtPassword" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Email
                    </td>
                    <td>
                        <input type="email" id="txtEmail" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        Phone
                    </td>
                    <td>
                        <input type="text" id="txtPhone" runat="server"/>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" OnClick="btnRegister_Click" Text="Register" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <label id="message" runat="server"></label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
