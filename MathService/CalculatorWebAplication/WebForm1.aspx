<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebAplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
            <table style="font-family:Arial">

                <tr>
                    <td>
                        <b>First number</b>
                    </td>

                    <td>
                        <asp:TextBox ID="textFirstNumber" runat="server"></asp:TextBox>
                    </td>
                    </tr>




                <tr>

                    <td>
                        <b>Second number</b>
                    </td>

                    <td>
                        <asp:TextBox ID="textSecondNumber" runat="server"></asp:TextBox>
                    </td>

                    </tr>


                    <tr>
                     <td>
                        <b>Result</b>
                         </td>

                    <td>
                        <asp:Label ID="LabeResult" runat="server" ></asp:Label>
                    </td>
                        </tr>
                <tr>

                    <td colspan="2">
                        <asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click" />
                        </td>
                    </tr>

                </table>
        
    </form>
</body>
</html>
