<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128540123/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2533)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# How to export the colored ASPxGridView
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2533/)**
<!-- run online end -->


<p><strong>UPDATED:</strong><br><br>Starting with version v2015 vol 2 (v15.2), this functionality is available out of the box. Use <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridView_FormatConditionstopic">ASPxGridView.FormatCondition</a> rules to define conditional formatting in Browse Mode and keep the applied appearance in the Exported Document. Please refer to the <a href="https://community.devexpress.com/blogs/aspnet/archive/2015/11/10/asp-net-grid-view-data-range-filter-adaptivity-and-more-coming-soon-in-v15-2.aspx">ASP.NET Grid View - Data Range Filter, Adaptivity and More (Coming soon in v15.2)</a> blog post and the <a href="http://demos.devexpress.com/ASPxGridViewDemos/Exporting/ExportWithFormatConditions.aspx">Export with Format Conditions</a> demo for more information.<br>If you have version v15.2+ available, consider using the built-in functionality instead of the approach detailed below.<br><br>If you need to apply custom appearance in the Exported Document only or define fine tuned complex appearance (for instance, based on some runtime calculated values, custom business rules, etc.), use the <a href="http://documentation.devexpress.com/#AspNet/DevExpressWebASPxGridViewExportASPxGridViewExporter_RenderBricktopic">ASPxGridViewExporter.RenderBrick</a> event in the <strong>WYSIWYG</strong> export mode.<br><br><strong>See Also:</strong><br><a href="https://www.devexpress.com/Support/Center/p/T262239">T262239: ASPxGridView - How to export a colored grid when the Data Aware export mode is used</a></p>

<br/>


