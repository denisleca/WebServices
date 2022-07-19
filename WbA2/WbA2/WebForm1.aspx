<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WbA2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            Enter IdCarte <asp:TextBox ID="TextIdCarte" runat="server"></asp:TextBox></br>
            Enter Titlu <asp:TextBox ID="TextTitlu" runat="server"></asp:TextBox></br>
            Enter Autor <asp:TextBox ID="TextAutor" runat="server"></asp:TextBox></br>
            Enter Pret <asp:TextBox ID="TextPret" runat="server"></asp:TextBox></br>
            </br>
            <asp:Button ID="Insert" runat="server" Text="Insert" OnClick="Insert_Click" />
        </p>
        <p>
        <asp:Button ID="Update" runat="server" OnClick="Update_Click" Text="Update" />
        </p>
        <p>
        <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete" />
            </p>

    </form>
</body>
</html>
