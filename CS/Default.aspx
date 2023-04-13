<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="grid" runat="server" AutoGenerateColumns="False" KeyFieldName="ProductID"
                         OnHtmlDataCellPrepared="grid_HtmlDataCellPrepared" OnExportRenderBrick="grid_ExportRenderBrick">
            <Columns>
                <dx:GridViewDataTextColumn FieldName="ProductID" ReadOnly="True" />
                <dx:GridViewDataTextColumn FieldName="ProductName" />
                <dx:GridViewDataTextColumn FieldName="UnitPrice" />
                <dx:GridViewDataTextColumn FieldName="UnitsOnOrder" />
            </Columns>
        </dx:ASPxGridView>
        <dx:ASPxButton ID="btnExport" runat="server" OnClick="btnExport_Click" Text="Export Grid" />
    </form>
</body>
</html>
