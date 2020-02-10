@Imports DevExpress.Web.Mvc.UI

<h4>** DevExpress / Report Designer **</h4>

@code
	Dim s = New DevExpress.Web.Mvc.ReportDesignerSettings()
	s.Name = "XtraReport1"

	Dim grid = Html.DevExpress().ReportDesigner(s)
End Code

@grid.Bind(ViewBag.report).GetHtml()


