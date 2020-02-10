@Imports DevExpress.Web.Mvc.UI

<h4>** DevExpress / Report **</h4>

@code
	Dim s = New DevExpress.Web.Mvc.WebDocumentViewerSettings()
	s.Name = "XtraReport1"

	Dim grid = Html.DevExpress().WebDocumentViewer(s)
End Code

@grid.Bind(ViewBag.report).GetHtml()


