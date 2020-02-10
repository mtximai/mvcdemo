@*
	09/05/16 - Definição da grid no arq. Razor
	GridView - How to use Bootstrap Glyphicons as Command Buttons
	https://www.devexpress.com/Support/Center/Example/Details/T252203

*@

@*@Imports DevExpress.Web.Mvc.UI*@

@Html.DevExpress().GridView(
	Sub(settings)
			settings.Name = "gv2"
			settings.KeyFieldName = "Id"
			settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "Grid2Partial"}
			settings.SettingsEditing.Mode = GridViewEditingMode.Inline
			settings.SettingsEditing.AddNewRowRouteValues = New With {.Controller = "Home", .Action = "EditingAddNew"}
			settings.SettingsEditing.UpdateRowRouteValues = New With {.Controller = "Home", .Action = "EditingUpdate"}
			settings.SettingsEditing.DeleteRowRouteValues = New With {.Controller = "Home", .Action = "EditingDelete"}
			settings.ControlStyle.CssClass = "GridViewRootClassName"

			settings.Columns.Add(
				Sub(column)
						column.Caption = "#"
						column.SetDataItemTemplateContent(Sub(c)
																  ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-plus' onclick='{0}.AddNewRow();'></span>", settings.Name))
																  ViewContext.Writer.Write(" ")
																  ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-pencil' onclick='{0}.StartEditRow({1});'></span>", settings.Name, c.VisibleIndex))
																  ViewContext.Writer.Write(" ")
																  ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-remove' onclick='{0}.DeleteRow({1});'></span>", settings.Name, c.VisibleIndex))
														  End Sub)

						column.SetEditItemTemplateContent(Sub(c)
																  ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-ok' onclick='{0}.UpdateEdit();'></span>", settings.Name))
																  ViewContext.Writer.Write(" ")
																  ViewContext.Writer.Write(String.Format("<span class='glyphicon glyphicon-repeat' onclick='{0}.CancelEdit();'></span>", settings.Name))
														  End Sub)
				End Sub)

			settings.Columns.Add("Nome")
			settings.Columns.Add("Sigla")
			settings.Columns.Add("Status")

			settings.CellEditorInitialize = _
				Sub(s, e)
						Dim editor As ASPxEdit = DirectCast(e.Editor, ASPxEdit)
						editor.ValidationSettings.Display = Display.Dynamic
				End Sub
	End Sub
).Bind(Model).GetHtml()