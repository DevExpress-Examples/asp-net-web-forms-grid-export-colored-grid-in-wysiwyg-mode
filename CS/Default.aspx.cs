using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using DevExpress.Web;
using DevExpress.XtraPrinting;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Init(object sender, EventArgs e) {
        grid.DataSource = Product.GetData();
        grid.DataBind();
    }
    protected void btnExport_Click(object sender, EventArgs e) {
        XlsExportOptionsEx options = new XlsExportOptionsEx() { ExportType = DevExpress.Export.ExportType.WYSIWYG };
        options.SheetName = "DevExpress";
        grid.ExportXlsToResponse(options);
    }
    protected void grid_HtmlDataCellPrepared(object sender, ASPxGridViewTableDataCellEventArgs e) {
        if (e.DataColumn.FieldName == "UnitPrice") {
            if (Convert.ToInt32(e.CellValue) > 15)
                e.Cell.BackColor = Color.Yellow;
            else
                e.Cell.BackColor = Color.Green;
        }
    }
    protected void grid_ExportRenderBrick(object sender, ASPxGridViewExportRenderingEventArgs e) {
        if (e.RowType != GridViewRowType.Data)
            return;
        if ((e.Column as GridViewDataColumn).FieldName == "UnitPrice" && e.RowType != GridViewRowType.Header) {
            if (Convert.ToInt32(e.TextValue) > 15)
                e.BrickStyle.BackColor = Color.Yellow;
            else
                e.BrickStyle.BackColor = Color.Green;
        }
    }
}
