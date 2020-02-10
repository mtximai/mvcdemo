@Imports DevExpress.Web.Mvc.UI

<!DOCTYPE html>
<html>
	<head>
		<meta charset="utf-8" />
		<meta name="viewport" content="width=device-width, initial-scale=1.0">
		<title>@ViewBag.Title - MvcDemo</title>
		
		@Styles.Render("~/Content/css")
		@Scripts.Render("~/bundles/modernizr")

		@Scripts.Render("~/bundles/jquery")
		@Scripts.Render("~/bundles/jqueryval")
		@Scripts.Render("~/Scripts/jquery.mask.min.js")
		@Scripts.Render("~/Scripts/globalize.js")
		@Scripts.Render("~/Scripts/globalize.cultures.js")
		@Scripts.Render("~/Scripts/knockout-3.0.0.js")

		@Scripts.Render("~/ScriptsLocais/Scripts")

		
			@Html.DevExpress().GetStyleSheets(
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.GridView, .Theme = "Aqua"},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.CardView},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.PivotGrid},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.Editors},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.Chart},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.Report},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.Scheduler},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.TreeList},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.RichEdit},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
			New StyleSheet With {.ExtensionSuite = ExtensionSuite.SpellChecker})



		@*@Html.DevExpress().GetScripts(
			New Script With {.ExtensionSuite = ExtensionSuite.GridView},
			New Script With {.ExtensionSuite = ExtensionSuite.CardView},
			New Script With {.ExtensionSuite = ExtensionSuite.PivotGrid},
			New Script With {.ExtensionSuite = ExtensionSuite.HtmlEditor},
			New Script With {.ExtensionSuite = ExtensionSuite.Editors},
			New Script With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout},
			New Script With {.ExtensionSuite = ExtensionSuite.Chart},
			New Script With {.ExtensionSuite = ExtensionSuite.Report},
			New Script With {.ExtensionSuite = ExtensionSuite.Scheduler},
			New Script With {.ExtensionSuite = ExtensionSuite.TreeList},
			New Script With {.ExtensionSuite = ExtensionSuite.RichEdit},
			New Script With {.ExtensionSuite = ExtensionSuite.Spreadsheet},
			New Script With {.ExtensionSuite = ExtensionSuite.SpellChecker})*@

		@Scripts.Render("~/bundles/bootstrap")

		@RenderSection("scripts", required:=False)
		
	</head>

	<body>
		<div class="container body-content">
			<div class="container-fluid">
				<div class="navbar navbar-inverse navbar-fixed-top">
					<div class="container">
						<div class="navbar-collapse collapse">

							<ul class="nav navbar-nav">
								<li>@Html.ActionLink("Home", "Index", "Home")</li>

								<li class="dropdown">
									<a class="dropdown-toggle text-center" data-toggle="dropdown" href="#">
										Exemplos
										<span class="caret"></span>
									</a>
									<ul class="dropdown-menu">
										<li>
											<a href='@Url.Action("HtmlEditor", "Home", New With {.area = ""})' tipo="linkAcesso">
												<img src="~/Content/Images/Icone_Manter.png" alt="Informes" width="16" height="16" />
												HtmlEditor
											</a>

										</li>

										<li>
											<a href='@Url.Action("ckeTeste", "Home", New With {.area = ""})' tipo="linkAcesso">
												<img src="~/Content/Images/Icone_Publicar.png" alt="Informes" width="16" height="16" />
												CkEditor
											</a>
										</li>

										<li>
											<a href='@Url.Action("mapTeste", "Home", New With {.area = ""})' tipo="linkAcesso">
												<img src="~/Content/Images/Icone_Usuarios.png" alt="Pesquisar" width="16" height="16" />
												Image Map
											</a>
										</li>

										<li>
											<a href='@Url.Action("carrosselTeste", "Home", New With {.area = ""})' tipo="linkAcesso">
												<img src="~/Content/Images/Icone_Usuarios.png" alt="Pesquisar" width="16" height="16" />
												Carrossel
											</a>
										</li>

									</ul>
								</li>

								
								<li>@Html.ActionLink("Grid", "TesteGrid", "Home", Nothing, New With {.title = "My Tooltip"})</li>
								<li>@Html.ActionLink("Grid2", "Grid2", "Home")</li>

								<li>@Html.ActionLink("ReportDesigner", "TesteReportDesigner", "Home")</li>
								<li>@Html.ActionLink("Report", "TesteReport", "Home")</li>
								<li>@Html.ActionLink("RDLC", "TesteReport_rdlc", "Home")</li>

								<li>@Html.ActionLink("Enviar", "Enviar", "K19")</li>
								<li>@Html.ActionLink("Baixar", "Baixar", "K19")</li>

								<li>@Html.ActionLink("Enviar_v2", "Enviar_v2", "K19")</li>

								<li>@Html.ActionLink("Baixar_v2", "Baixar_v2", "K19")</li>
							</ul>

						</div>
					</div>
				</div>
			</div>

			<div class="col-md-12" style="margin-bottom:20px">
				@Html.DevExpress().Panel(
				   Sub(settings)
						   settings.Name = "MainPane"
						   settings.ControlStyle.CssClass = "mainContentPane"
						   settings.SetContent(RenderBody().ToHtmlString())
				   End Sub
				).GetHtml()
			</div>

			<div class="navbar navbar-default navbar-fixed-bottom" role="navigation" style="padding-top: 7px; background: #E8E8E8; min-height: 30px">
				<div class="row">
					<div class="col-sm-5 text-left" style="padding-left:20px">
						<span class="visible-md visible-lg">&copy; @DateTime.Now.Year - MvcDemo - Tribunal de Contas do Município de São Paulo</span>
						<span class="visible-sm visible-xs">&copy; @DateTime.Now.Year - MvcDemo</span>
					</div>
				</div>
			</div>
		</div>
	</body>
</html>
