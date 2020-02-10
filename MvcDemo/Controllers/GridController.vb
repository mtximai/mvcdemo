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

Public Class GridController
	Inherits BaseController

	Private db As New ProtonEntities


	<HttpGet>
	Function Listar() As ActionResult
		Dim Result As ActionResult

		Dim gridTeste = New Grid("grdTeste")

		'.SetMultiBoxOnly(True)
		'.OnCellSelect("grdCellSelect(rowid, iCol, cellcontent, e)")
		'.OnBeforeSelectRow("grdBeforeSelectRow(rowid, e)")

		'.SetShrinkToFit(True)


		With gridTeste

			.SetUrl(Url.Action("Listar", "Grid"))
			.SetRequestType(Enums.RequestType.Post)
			.SetLoadText("Carregando... Aguarde!")
			.SetHeight(200)
			.SetAutoWidth(True)
			.SetLoadOnce(True)
			.SetRowNum(1000)
			.SetMultiSelect(True)

			'.OnBeforeRequest("grdBeforeRequest()")
			.OnLoadBeforeSend("grdLoadBeforeSend()")

			.OnGridComplete("grdGridComplete()")
			.OnSelectRow("grdSelectRow(rowid, status)")
			.OnSelectAll("grdSelectAll(aRowids, status)")

			.AddColumn(New Column("sel").
						SetLabel("Seleção").
						SetEditType(Enums.EditType.Checkbox).
						SetFormatter(Enums.Formatters.Checkbox).
						SetWidth(10).
						SetSearch(False).
						SetSortable(True)
					   )

			.AddColumn(New Column("codigo").
					   SetLabel("Código").
					   SetSearch(False).
					   SetAlign(Enums.Align.Center).
					   SetFormatter(Enums.Formatters.Integer).
					   SetWidth(10).
					   SetSortType(Enums.SortType.Integer).
					   SetSortable(True))

			.AddColumn(New Column("descricao").
					   SetLabel("Descrição").
					   SetSearch(False).
					   SetAlign(Enums.Align.Left).
					   SetWidth(27).
					   SetSortable(True))

		End With

		ViewBag.gridTeste = gridTeste

		Result = View()

		Return Result

	End Function


	<HttpPost>
	Function Listar(Optional ByVal xx As String = "") As ActionResult

		'Dim result As ActionResult

		Dim lst As New List(Of Produto)

		lst.Add(New Produto() With {.sel = False, .codigo = 100, .descricao = "Teclado"})
		lst.Add(New Produto() With {.sel = True, .codigo = 200, .descricao = "Mouse"})
		lst.Add(New Produto() With {.sel = True, .codigo = 300, .descricao = "Monitor LCD 23 polegadas"})
		lst.Add(New Produto() With {.sel = True, .codigo = 400, .descricao = "CPU I7 16GB RAM"})
		lst.Add(New Produto() With {.sel = True, .codigo = 500, .descricao = "Roteador WI-FI"})
		lst.Add(New Produto() With {.sel = False, .codigo = 31, .descricao = "Modem US Robotics"})


		'.ToString().PadLeft(4)
		Dim x = New With {
			.records = lst.Count,
			.rows = (From linha In lst
				 Select New With {
					.id = linha.codigo,
					.cell = {linha.sel, linha.codigo, linha.descricao}
				 }).ToArray()
		}

		Return Json(x)

	End Function

	' 19/04/17
	<HttpGet>
	Function ProcessarGet(ByVal pTipo As String, ByVal pTexto As String) As String

		Dim qtSel As Integer

		'Return Json("Retorno do /Grid/ProcessarGet(): Selecionados: " + qtSel.ToString + "   pTipo: " + pTipo)

		Return "resposta"

	End Function

	<HttpPost>
	Function ProcessarPost(ByVal pSel() As Integer, ByVal pTipo As String) As JsonResult

		Dim qtSel As Integer

		If pSel IsNot Nothing Then
			qtSel = pSel.Count
		End If

		Return Json("Retorno do /Grid/ProcessarPost(): Selecionados: " + qtSel.ToString + "   pTipo: " + pTipo)

	End Function

	Public Class Produto
		Property sel As Boolean
		Property codigo As Integer
		Property descricao As String
	End Class


End Class
