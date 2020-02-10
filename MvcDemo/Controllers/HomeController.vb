Imports DevExpress.Web.Mvc

Imports Microsoft.Reporting.WebForms
Imports DevExpress.Web
Imports System.Data.Entity

Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports TCMSP.Entidades.Portal
Imports TCMSP.Utilidades.Conversores
Imports TCMSP.Utilidades.Diversos.Util
Imports TCMSP.Contratos.DataSources
Imports MvcDemo.Controllers
Imports MvcJqGrid

Public Class HomeController
	Inherits BaseController

	Private db As New ProtonEntities

	Function Index() As ActionResult
		Return View()
	End Function

	Function About() As ActionResult
		ViewData("Message") = "Your application description page."
		Return View()
	End Function

	Function Contact() As ActionResult
		ViewData("Message") = "Your contact page."
		Return View()
	End Function

	Public Enum HeaderViewRenderMode
		Full
		Title
	End Enum


	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	':: carrosselTeste - 05/12/16
	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	<HttpGet>
	Function carrosselTeste() As ActionResult

		portalTeste()

		Return View()

	End Function


	Function portalTeste() As ActionResult

		'Dim idPortal = "PortalTCM-d"
		'Dim idSistema = "ATOMO"
		''Dim idMenu = "CORPORATIVO, LICITACOES, PANORAMA, SIGMA, ABACO"
		'Dim idMenu = "LICITACOES"

		''Dim idSistema = "SIMPROC"
		''Dim IDmENU = "SIMPROC"


		'Dim gPortalChannelFactory As ChannelFactory(Of TCMSP.Contratos.Portal.IPortalServico)
		'Dim gPortalService As TCMSP.Contratos.Portal.IPortalServico

		'Dim Binding = New WSHttpBinding()

		'Binding.ReaderQuotas.MaxArrayLength = 2147483647
		'Binding.MaxReceivedMessageSize = 2147483647

		'gPortalChannelFactory = New ChannelFactory(Of TCMSP.Contratos.Portal.IPortalServico)(Binding, New EndpointAddress("http://iis-3:12000/PortalServico.svc/http"))


		'gPortalService = gPortalChannelFactory.CreateChannel()

		'Dim gPortalClientSimproc As TCMSP.Entidades.Portal.PortalClient

		'Dim buffer = gPortalService.GetAcesso(idPortal, idSistema, idMenu, "PortalTCM", "tcmsp")

		'gPortalClientSimproc = CType(Conversor.ByteToObject(buffer), PortalClient)

		'Dim clientBase = Conversor.ObjectToByte(gPortalClientSimproc.GetBase)

		''--

		'Dim gTcmDataSourcesChannelFactory As ChannelFactory(Of IDataSourcesServico)
		'Dim gTcmDataSourcesServico As IDataSourcesServico

		'Dim Clients As New List(Of Byte())({Conversor.ObjectToByte(gPortalClientSimproc.GetBase)})


		'gTcmDataSourcesChannelFactory = New ChannelFactory(Of IDataSourcesServico)(Binding, New EndpointAddress("http://127.0.0.1:12100/DataSourcesServico.svc"))

		'gTcmDataSourcesServico = gTcmDataSourcesChannelFactory.CreateChannel

		'gTcmDataSourcesServico.SetarClientesPortal(Clients, "DATASOURCES")

		'TCMSP.Utilidades.Diversos.Util.ChamarServico(Sub()
		'												 Dim x = gTcmDataSourcesServico.ProcessoSEI_Ler("8989.2016/0000188-2")
		'											 End Sub)


		'-- PubNet - 15/12/16 ---------------------------------------------------------------

		'Dim client As New br.com.imprensaoficial.servicos.NegociosPublicos
		'Dim auth As New br.com.imprensaoficial.servicos.AuthHeader

		'auth.UserName = "TCMSP_OPE"
		'auth.Password = "80MtC$$20.1"

		'client.AuthHeaderValue = auth

		'Dim x = client.licitacoesPublicadas(Date.Today.ToString("yyyy-MM-dd"), "11")

		'x.Tables(0).Rows(0)(1),String)	"ERRO: ACESSO NEGADO AO RECURSO."


		'------------------------------------------------------------------------------------

		'Dim ws As New WSCorreios.AtendeClienteClient
		'Dim resp = ws.consultaCEP("05438300")

		'Dim client As New Service1_ServiceReference.Service1Client
		'Dim z = client.GetData(1000)

		Dim x As New SR1.Service1Client
		Dim y As New WR1.SharePointWS

		Dim Servidor_SharePoint = "sharepoint"
		Dim Porta_SharePoint = "80"
		Dim Site_SharePoint = "/sites/ProdutoFiscalizacao/"
		Dim Lista_SharePoint = "ProdutoFiscalizacao"

		Dim urlSite = String.Format("http://{0}:{1}{2}", Servidor_SharePoint, Porta_SharePoint, Site_SharePoint)

		Dim z As New System.Net.NetworkCredential("dmzsharepoint", "tcm2016", "tcm")

		x.ClientCredentials.Windows.ClientCredential = z

		y.Credentials = z

		Dim zz = y.Listar(urlSite, Servidor_SharePoint, Porta_SharePoint, Site_SharePoint, "tc", "1", False)

        Return Nothing

	End Function



	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	':: ckeTeste - 23/11/16
	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	<HttpGet>
	Function mapTeste() As ActionResult

		Return View()

	End Function


	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	':: ckeTeste - 04/11/16
	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	<HttpGet>
	Function ckeTeste() As ActionResult

		'Dim y = db.Log.FirstOrDefault

		Logger.Debug("xxx Resultado do Logon do Usuario {0}: {1} ")
		Logger.Error("xxx kjlsajflksjflkasjflka")


		Dim x = db.EmailModelo.Find({1})
		Dim vm = New EmailModelo With {.id = x.id, .descricao = x.descricao, .corpo = x.corpo}


		Return View("ckeTeste", vm)

	End Function

	<HttpPost>
	Function ckeTeste(ByVal vm As ModeloCkeditor) As ActionResult

		Dim md = db.EmailModelo.Find(vm.id)

		md.descricao = vm.descricao
		md.corpo = vm.corpo

		db.Entry(md).State = EntityState.Modified
		db.SaveChanges()

		Return View("ckeTeste", md)

	End Function


	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
	':: Editor HTML - 08/09/16
	':: Fonte: https://demos.devexpress.com/MVCxHTMLEditorDemos/Overview
	'::
	<HttpGet>
	Function HtmlEditor() As ActionResult

		Return View("HtmlEditor", Me.ObterModelo)

	End Function

	Public Function HtmlEditorPartial(Corpo As String) As ActionResult

		Dim mc = New ModeloComunicado
		mc.Corpo = Corpo

		If HtmlEditorExtension.GetActiveView("corpo") = ASPxHtmlEditor.HtmlEditorView.Preview Then

			Corpo = "jkljlkj"
			mc.Corpo = "kçlkçskçfkasçk"

		End If

		Return PartialView("_HtmlEditorPartial", mc)

	End Function

	<HttpPost>
	Public Function HtmlEditorPartialImageSelectorUpload() As ActionResult
		HtmlEditorExtension.SaveUploadedImage("HtmlEditor", HomeControllerHtmlEditorSettings.ImageSelectorSettings)
		Return Nothing
	End Function

	<HttpPost>
	Public Function HtmlEditorPartialImageUpload() As ActionResult
		HtmlEditorExtension.SaveUploadedFile("HtmlEditor",
											 HomeControllerHtmlEditorSettings.ImageUploadValidationSettings,
											 HomeControllerHtmlEditorSettings.ImageUploadDirectory)
		Return Nothing
	End Function

	<HttpPost()>
	Public Function HtmlEditar(ByVal mc As ModeloComunicado) As ActionResult

		'Public Function HtmlEditar(<Bind(Include:="CdModelo, Titulo, Corpo")> ByVal mc As ModeloComunicado) As ActionResult

		Dim html = HtmlEditorExtension.GetHtml("Corpo")

		Return View("HtmlEditor")

	End Function


	Private Function ObterModelo() As ModeloComunicado

		Dim mc = New ModeloComunicado

		mc.CdModelo = "M1"
		mc.Titulo = "Título do comunicado"
		mc.Corpo = "<p>Texto inicial para <strong>edição</strong>.<p>"

		Return mc

	End Function


	'::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

	'** 07/03/16: Teste com Grid o DevExpress
	<HttpGet>
	Function TesteGrid() As ActionResult

		Dim rs = db.vwOrgao

		Return View(rs.ToList)

	End Function

	Public Function TesteGridPartial() As ActionResult

		Return PartialView("TesteGridPartial", db.vwOrgao.ToList)

	End Function


	Public Function ExportTo(ByVal OutputFormat As String) As ActionResult
		Dim model = db.vwOrgao.ToList
		Dim s = GridViewHelper.ExportGridViewSettings

		OutputFormat = "XLS"

		Select Case OutputFormat.ToUpper()
			Case "CSV"
				Return GridViewExtension.ExportToCsv(s, model)
			Case "PDF"
				Return GridViewExtension.ExportToPdf(s, model)
			Case "RTF"
				Return GridViewExtension.ExportToRtf(s, model)
			Case "XLS"
				Return GridViewExtension.ExportToXls(s, model)
			Case "XLSX"
				Return GridViewExtension.ExportToXlsx(s, model)
			Case Else
				Return RedirectToAction("Index")
		End Select
	End Function

    Public Class Produto
        Property sel As Boolean
		Property codigo As Integer
        Property descricao As String
    End Class

    Function Grid2() As ActionResult
        Dim rs = db.vwOrgao
        Return View(rs.ToList)
    End Function

	Public Function Grid2Partial() As ActionResult
		Return PartialView("Grid2Partial", db.vwOrgao.ToList)
	End Function


	<HttpPost>
	Public Function EditingAddNew() As ActionResult
		Return PartialView("Grid2Partial", db.vwOrgao.ToList)
	End Function

	<HttpPost>
	Public Function EditingUpdate() As ActionResult
		Return PartialView("Grid2Partial", db.vwOrgao.ToList)
	End Function

	<HttpPost>
	Public Function EditingDelete() As ActionResult
		Return PartialView("Grid2Partial", db.vwOrgao.ToList)
	End Function

	'Private Function f_GerarReportSettings() As ReportDesignerSettings
	'	'Dim s = New DocumentViewerSettings()
	'	Dim s = New ReportDesignerSettings()

	'	s.Name = "XtraReport1"
	'	's.Report = ViewData("Report")
	'	's.CallbackRouteValues = New With {.controller = "Home", .Action = "DocViewerPartial"}
	'	's.ExportRouteValues = New With {.controller = "Home", .Action = "ExportDocViewerPartial"}

	'	Return s
	'End Function

	Function TesteReportDesigner() As ActionResult
		ViewBag.report = New XtraReport1()
		Return View()
	End Function

	Function TesteReport() As ActionResult
		ViewBag.report = New XtraReport1()
		Return View()
	End Function

	'Exemplo com RDLC
	Function TesteReport_rdlc() As ActionResult
		Dim ds = New ReportDataSource("dsOrgao", db.vwOrgao)
		Dim rv = New ReportViewer

		rv.ProcessingMode = ProcessingMode.Local
		rv.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + "Reports\Report1.rdlc"
		rv.LocalReport.DataSources.Add(ds)
		rv.SizeToReportContent = True
		rv.ShowPrintButton = True

		ViewBag.RV = rv

		Return View()
	End Function

End Class

' gerado pelo wizard do DevX (08/09/16)

Public Class HomeControllerHtmlEditorSettings

	Public Const ImageUploadDirectory As String = "~/Content/Images/"

	Public Const ImageSelectorThumbnailDirectory As String = "~/Content/Thumb/"

	Public Shared ImageUploadValidationSettings As New DevExpress.Web.UploadControlValidationSettings() With {.AllowedFileExtensions = New String() {".jpg", ".jpeg", ".jpe", ".gif", ".png"}, .MaxFileSize = 4000000}

	Private Shared _imageSelectorSettings As DevExpress.Web.Mvc.MVCxHtmlEditorImageSelectorSettings

	Public Shared ReadOnly Property ImageSelectorSettings() As DevExpress.Web.Mvc.MVCxHtmlEditorImageSelectorSettings
		Get
			If _imageSelectorSettings Is Nothing Then
				_imageSelectorSettings = New DevExpress.Web.Mvc.MVCxHtmlEditorImageSelectorSettings(Nothing)
				_imageSelectorSettings.Enabled = True
				_imageSelectorSettings.UploadCallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "HtmlEditorPartialImageSelectorUpload"}
				_imageSelectorSettings.CommonSettings.RootFolder = ImageUploadDirectory
				_imageSelectorSettings.CommonSettings.ThumbnailFolder = ImageSelectorThumbnailDirectory
				_imageSelectorSettings.CommonSettings.AllowedFileExtensions = New String() {".png", ".jpg", ".jpeg", ".jpe", ".gif"}
				_imageSelectorSettings.UploadSettings.Enabled = True
			End If
			Return _imageSelectorSettings
		End Get
	End Property
End Class



'*********************************
'*  Classe de apoio para a Grid
'*
'*********************************
Public NotInheritable Class GridViewHelper
	Private Shared g_settings As GridViewSettings

	' Se true indica que os Settings já foram inicializados
	Private Shared b_init = False

	Private Sub New()
	End Sub

	Public Shared ReadOnly Property ExportGridViewSettings() As GridViewSettings
		Get
			If (g_settings Is Nothing) Then
				g_settings = CreateExportGridViewSettings()
				b_init = True
			End If

			Return g_settings
		End Get
	End Property

	Public Shared ReadOnly Property bInit() As Boolean
		Get
			Return b_init
		End Get
	End Property

	Private Shared Function CreateExportGridViewSettings() As GridViewSettings
		Dim settings = New GridViewSettings()

		settings.Name = "TesteGrid"
		settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "TesteGridPartial"}
		settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
		settings.SettingsPager.PageSize = 5
		settings.ControlStyle.Paddings.Padding = System.Web.UI.WebControls.Unit.Pixel(0)
		settings.ControlStyle.Border.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1)
		settings.ControlStyle.BorderBottom.BorderWidth = System.Web.UI.WebControls.Unit.Pixel(1)

		'** Group Panel:
		settings.Settings.ShowGroupPanel = True
		settings.SettingsText.GroupPanel = "Agrupe arrastando a coluna aqui."

		settings.SettingsText.Title = "Titulo da Grid"

		settings.SettingsText.CommandCancel = "Cancelar"
		settings.Theme = "Aqua"

		settings.SettingsBehavior.HeaderFilterMaxRowCount = 10
		settings.Settings.ShowHeaderFilterButton = True


		'** Column Chooser:
		settings.SettingsBehavior.EnableCustomizationWindow = True
		settings.SettingsText.CustomizationWindowCaption = "Customizar colunas"
		settings.SettingsPopup.CustomizationWindow.VerticalOffset = 100

		'** Filter Builder:
		settings.Settings.ShowFilterBar = GridViewStatusBarMode.Visible
		settings.SettingsText.FilterControlPopupCaption = "Filtro"
		settings.SettingsText.FilterBarClear = "Limpar"
		settings.SettingsText.FilterBarCreateFilter = "Criar filtro"


		settings.SettingsText.HeaderFilterCancelButton = "Cancelar"
		settings.Styles.TitlePanel.HorizontalAlign = System.Web.UI.WebControls.HorizontalAlign.Center

		'** Habilita Checkbox:
		settings.CommandColumn.Visible = True
		settings.CommandColumn.ShowSelectCheckbox = True
		settings.ClientSideEvents.SelectionChanged = "SelectionChanged"
		settings.CommandColumn.Width = 20
		settings.CommandColumn.Caption = "Sel"
		settings.CommandColumn.HeaderStyle.HorizontalAlign = HorizontalAlign.Center

		'** Click na linha:
		settings.SettingsBehavior.AllowFocusedRow = True
		settings.ClientSideEvents.FocusedRowChanged = "OnGridFocusedRowChanged"


		'** DEFINIÇÃO DAS COLUNAS
		settings.KeyFieldName = "Id"

		settings.Columns.Add(
			Sub(c)
				c.FieldName = "Id"
				c.Caption = "Código"
				c.ToolTip = "Arraste a coluna para alterar o layout"
				c.CellStyle.HorizontalAlign = HorizontalAlign.Center
				c.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
				c.Width = 50
			End Sub
		)

		settings.Columns.Add(
			Sub(c)
				c.FieldName = "Nome"
				c.ToolTip = "Arraste a coluna para alterar o layout"
				c.Width = 500
			End Sub
		)

		settings.Columns.Add("Sigla").Visible = False

		settings.Columns.Add(
			Sub(c)
				c.FieldName = "Status"
				c.ToolTip = "Arraste a coluna para alterar o layout"
				c.CellStyle.HorizontalAlign = HorizontalAlign.Center
				c.HeaderStyle.HorizontalAlign = HorizontalAlign.Center
				c.Width = 50
			End Sub
		)

		'settings.CommandColumn.CustomButtons.Add(New GridViewCommandColumnCustomButton() With {.ID = "btnGetKey", .Text = "Details"})
		'settings.ClientSideEvents.CustomButtonClick = "function(s, e) {{ alert('evento click'); }}"

		'settings.CommandColumn.Visible = True
		'settings.CommandColumn.ShowNewButton = True
		'settings.CommandColumn.ShowEditButton = True

		Return settings
	End Function
End Class