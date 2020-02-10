@Imports DevExpress.Web.Mvc.UI

@code

	' Faz adição de columas apenas uma vez:
	Dim s = GridViewHelper.ExportGridViewSettings

	If (Not GridViewHelper.bInit) Then

		'Cria uma Header na coluna que funciona como um link (09/05/16)
		'Obs.: o script não pode ficar na PartialView!
		'Link: https://www.devexpress.com/Support/Center/Question/Details/Q347808
		s.CommandColumn.SetHeaderTemplateContent(
			Sub(c)
					Html.DevExpress.HyperLink(
					Sub(hs)
							hs.Name = "link_" + s.Name
							hs.Properties.Text = "Novo Botão"
							hs.NavigateUrl = "javascript:void(0);"
							'hs.Properties.ClientSideEvents.Click = String.Format("function(s, e) {{{0}.AddNewRow();}}", s.Name)
							hs.Properties.ClientSideEvents.Click = "function(s, e) {f_click(s,e);}"
					End Sub
					).Render()
			End Sub
		)

		s.Columns.Add(
			Sub(c)
					c.FieldName = "Unbound"
					c.Caption = "Meu Botão"
					c.UnboundType = DevExpress.Data.UnboundColumnType.String
					c.EditFormSettings.Visible = DevExpress.Utils.DefaultBoolean.False
					c.Width = Unit.Percentage(10)
					c.SetDataItemTemplateContent(
						Sub(cs)
								ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-plus' onclick='{0}.AddNewRow();'></span>", s.Name))
						End Sub
					  )
			End Sub
		)


		s.Columns.Add(
			Sub(col)
					col.SetDataItemTemplateContent(
						Sub(c)
								ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-folder-open' data-id='{0}' onclick='OnImageClick(this);'></span>", c.KeyValue))
						End Sub
					)
			End Sub
		)

	End If
End Code


@Html.DevExpress().GridView(s).Bind(Model).GetHtml()