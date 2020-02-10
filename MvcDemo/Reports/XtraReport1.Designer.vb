<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class XtraReport1
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim EfConnectionParameters1 As DevExpress.DataAccess.EntityFramework.EFConnectionParameters = New DevExpress.DataAccess.EntityFramework.EFConnectionParameters()
		Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
		Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
		Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
		Me.EfDataSource1 = New DevExpress.DataAccess.EntityFramework.EFDataSource(Me.components)
		Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
		Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
		Me.PageFooterBand1 = New DevExpress.XtraReports.UI.PageFooterBand()
		Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
		Me.XrPageInfo2 = New DevExpress.XtraReports.UI.XRPageInfo()
		Me.ReportHeaderBand1 = New DevExpress.XtraReports.UI.ReportHeaderBand()
		Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
		Me.Title = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.FieldCaption = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.PageInfo = New DevExpress.XtraReports.UI.XRControlStyle()
		Me.DataField = New DevExpress.XtraReports.UI.XRControlStyle()
		CType(Me.EfDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
		'
		'Detail
		'
		Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.XrLabel2, Me.XrLabel3, Me.XrLabel4, Me.XrLabel5, Me.XrLabel6, Me.XrLabel7, Me.XrLabel8, Me.XrLine1})
		Me.Detail.HeightF = 46.70833!
		Me.Detail.Name = "Detail"
		Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'TopMargin
		'
		Me.TopMargin.HeightF = 50.0!
		Me.TopMargin.Name = "TopMargin"
		Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'BottomMargin
		'
		Me.BottomMargin.HeightF = 23.08334!
		Me.BottomMargin.Name = "BottomMargin"
		Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
		Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
		'
		'EfDataSource1
		'
		EfConnectionParameters1.ConnectionString = ""
		EfConnectionParameters1.ConnectionStringName = "ProtonEntities"
		EfConnectionParameters1.Source = GetType(MvcDemo.ProtonEntities)
		Me.EfDataSource1.ConnectionParameters = EfConnectionParameters1
		Me.EfDataSource1.Name = "EfDataSource1"
		'
		'XrLabel1
		'
		Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(6.00001!, 9.000015!)
		Me.XrLabel1.Name = "XrLabel1"
		Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel1.SizeF = New System.Drawing.SizeF(59.91667!, 18.0!)
		Me.XrLabel1.StyleName = "FieldCaption"
		Me.XrLabel1.Text = "Id"
		'
		'XrLabel2
		'
		Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(65.91668!, 9.000015!)
		Me.XrLabel2.Name = "XrLabel2"
		Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel2.SizeF = New System.Drawing.SizeF(162.0!, 18.0!)
		Me.XrLabel2.StyleName = "FieldCaption"
		Me.XrLabel2.Text = "Nome"
		'
		'XrLabel3
		'
		Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(539.25!, 9.000015!)
		Me.XrLabel3.Name = "XrLabel3"
		Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel3.SizeF = New System.Drawing.SizeF(51.25006!, 18.0!)
		Me.XrLabel3.StyleName = "FieldCaption"
		Me.XrLabel3.Text = "Sigla"
		'
		'XrLabel4
		'
		Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(590.5001!, 9.000015!)
		Me.XrLabel4.Name = "XrLabel4"
		Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel4.SizeF = New System.Drawing.SizeF(49.49994!, 18.0!)
		Me.XrLabel4.StyleName = "FieldCaption"
		Me.XrLabel4.Text = "Status"
		'
		'XrLabel5
		'
		Me.XrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vwOrgao.Id")})
		Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(5.999994!, 27.00001!)
		Me.XrLabel5.Name = "XrLabel5"
		Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel5.SizeF = New System.Drawing.SizeF(59.9167!, 18.0!)
		Me.XrLabel5.StyleName = "DataField"
		Me.XrLabel5.Text = "XrLabel5"
		'
		'XrLabel6
		'
		Me.XrLabel6.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vwOrgao.Nome")})
		Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(65.91669!, 27.00001!)
		Me.XrLabel6.Name = "XrLabel6"
		Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel6.SizeF = New System.Drawing.SizeF(457.5!, 18.0!)
		Me.XrLabel6.StyleName = "DataField"
		Me.XrLabel6.Text = "XrLabel6"
		'
		'XrLabel7
		'
		Me.XrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vwOrgao.Sigla")})
		Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(539.2501!, 27.00001!)
		Me.XrLabel7.Name = "XrLabel7"
		Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel7.SizeF = New System.Drawing.SizeF(51.25003!, 18.0!)
		Me.XrLabel7.StyleName = "DataField"
		Me.XrLabel7.Text = "XrLabel7"
		'
		'XrLabel8
		'
		Me.XrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "vwOrgao.Status")})
		Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(590.5001!, 27.00001!)
		Me.XrLabel8.Name = "XrLabel8"
		Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
		Me.XrLabel8.SizeF = New System.Drawing.SizeF(49.49988!, 18.0!)
		Me.XrLabel8.StyleName = "DataField"
		Me.XrLabel8.Text = "XrLabel8"
		'
		'XrLine1
		'
		Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 3.0!)
		Me.XrLine1.Name = "XrLine1"
		Me.XrLine1.SizeF = New System.Drawing.SizeF(638.0!, 2.0!)
		'
		'PageFooterBand1
		'
		Me.PageFooterBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrPageInfo2})
		Me.PageFooterBand1.HeightF = 29.0!
		Me.PageFooterBand1.Name = "PageFooterBand1"
		'
		'XrPageInfo1
		'
		Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
		Me.XrPageInfo1.Name = "XrPageInfo1"
		Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime
		Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
		Me.XrPageInfo1.StyleName = "PageInfo"
		'
		'XrPageInfo2
		'
		Me.XrPageInfo2.Format = "Page {0} of {1}"
		Me.XrPageInfo2.LocationFloat = New DevExpress.Utils.PointFloat(331.0!, 6.0!)
		Me.XrPageInfo2.Name = "XrPageInfo2"
		Me.XrPageInfo2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrPageInfo2.SizeF = New System.Drawing.SizeF(313.0!, 23.0!)
		Me.XrPageInfo2.StyleName = "PageInfo"
		Me.XrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
		'
		'ReportHeaderBand1
		'
		Me.ReportHeaderBand1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel9})
		Me.ReportHeaderBand1.HeightF = 51.0!
		Me.ReportHeaderBand1.Name = "ReportHeaderBand1"
		'
		'XrLabel9
		'
		Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(6.0!, 6.0!)
		Me.XrLabel9.Name = "XrLabel9"
		Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		Me.XrLabel9.SizeF = New System.Drawing.SizeF(638.0!, 33.0!)
		Me.XrLabel9.StyleName = "Title"
		Me.XrLabel9.Text = "Teste DevExpress 1 - alterado"
		'
		'Title
		'
		Me.Title.BackColor = System.Drawing.Color.Transparent
		Me.Title.BorderColor = System.Drawing.Color.Black
		Me.Title.Borders = DevExpress.XtraPrinting.BorderSide.None
		Me.Title.BorderWidth = 1.0!
		Me.Title.Font = New System.Drawing.Font("Times New Roman", 20.0!, System.Drawing.FontStyle.Bold)
		Me.Title.ForeColor = System.Drawing.Color.Maroon
		Me.Title.Name = "Title"
		'
		'FieldCaption
		'
		Me.FieldCaption.BackColor = System.Drawing.Color.Transparent
		Me.FieldCaption.BorderColor = System.Drawing.Color.Black
		Me.FieldCaption.Borders = DevExpress.XtraPrinting.BorderSide.None
		Me.FieldCaption.BorderWidth = 1.0!
		Me.FieldCaption.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
		Me.FieldCaption.ForeColor = System.Drawing.Color.Maroon
		Me.FieldCaption.Name = "FieldCaption"
		'
		'PageInfo
		'
		Me.PageInfo.BackColor = System.Drawing.Color.Transparent
		Me.PageInfo.BorderColor = System.Drawing.Color.Black
		Me.PageInfo.Borders = DevExpress.XtraPrinting.BorderSide.None
		Me.PageInfo.BorderWidth = 1.0!
		Me.PageInfo.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
		Me.PageInfo.ForeColor = System.Drawing.Color.Black
		Me.PageInfo.Name = "PageInfo"
		'
		'DataField
		'
		Me.DataField.BackColor = System.Drawing.Color.Transparent
		Me.DataField.BorderColor = System.Drawing.Color.Black
		Me.DataField.Borders = DevExpress.XtraPrinting.BorderSide.None
		Me.DataField.BorderWidth = 1.0!
		Me.DataField.Font = New System.Drawing.Font("Times New Roman", 10.0!)
		Me.DataField.ForeColor = System.Drawing.Color.Black
		Me.DataField.Name = "DataField"
		Me.DataField.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
		'
		'XtraReport1
		'
		Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.PageFooterBand1, Me.ReportHeaderBand1})
		Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.EfDataSource1})
		Me.DataMember = "vwOrgao"
		Me.DataSource = Me.EfDataSource1
		Me.Margins = New System.Drawing.Printing.Margins(100, 100, 50, 23)
		Me.ScriptLanguage = DevExpress.XtraReports.ScriptLanguage.VisualBasic
		Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.Title, Me.FieldCaption, Me.PageInfo, Me.DataField})
		Me.Version = "15.2"
		CType(Me.EfDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents EfDataSource1 As DevExpress.DataAccess.EntityFramework.EFDataSource
	Friend WithEvents PageFooterBand1 As DevExpress.XtraReports.UI.PageFooterBand
	Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
	Friend WithEvents XrPageInfo2 As DevExpress.XtraReports.UI.XRPageInfo
	Friend WithEvents ReportHeaderBand1 As DevExpress.XtraReports.UI.ReportHeaderBand
	Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents Title As DevExpress.XtraReports.UI.XRControlStyle
	Friend WithEvents FieldCaption As DevExpress.XtraReports.UI.XRControlStyle
	Friend WithEvents PageInfo As DevExpress.XtraReports.UI.XRControlStyle
	Friend WithEvents DataField As DevExpress.XtraReports.UI.XRControlStyle
End Class
