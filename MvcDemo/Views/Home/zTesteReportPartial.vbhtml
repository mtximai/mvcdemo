@Imports DevExpress.Web.Mvc.UI

@Model DevExpress.XtraReports.UI.XtraReport

@*
*@
@code
	'Dim grid = Html.DevExpress().DocumentViewer(ViewBag.GridSettings)
	Dim grid = Html.DevExpress().ReportDesigner(ViewBag.GridSettings)
End Code

@*
*@

@grid.Bind(ViewBag.report).GetHtml()



