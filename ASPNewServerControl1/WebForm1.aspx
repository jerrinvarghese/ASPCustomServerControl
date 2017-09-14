<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ASPNewServerControl1.WebForm1" %>

<%@ Register Assembly="ServerControlLibrary" Namespace="ServerControlLibrary.Controls" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <cc1:CustomCalender ID="CustomCalender1" ImageUrl="Image/calendar.png" runat="server" />
    </div>
    </form>
</body>
</html>
