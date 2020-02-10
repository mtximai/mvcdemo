@* 29/03/17 *@

@Scripts.Render("~/bundles/modernizr")

@Scripts.Render("~/bundles/jquery")
@Scripts.Render("~/bundles/jqueryval")
@Scripts.Render("~/Scripts/jquery.mask.min.js")
@Scripts.Render("~/Scripts/globalize.js")
@Scripts.Render("~/Scripts/globalize.cultures.js")
@Scripts.Render("~/Scripts/knockout-3.0.0.js")

@Scripts.Render("~/ScriptsLocais/Grid.js")

@*@Styles.Render("~/Content/css")*@


<link href="@Url.Content("~/Content/jquery.jqGrid/ui.jqgrid.css")" rel="stylesheet" type="text/css" />
<link href="@Url.Content("~/Content/themes/base/jquery.ui.theme.css")" rel="stylesheet" type="text/css" />

<br />

<div class="form-horizontal">

	<div class="form-group">
		<div class="col-lg-6">
			<div class="">
				@ViewBag.gridTeste
			</div>
		</div>
	</div>

	<div class="form-group">
		<label class="col-lg-1">Mensagem:</label>
		<p><span id="spnMsg">Aguarde...</span></p>
	</div>

	<div class="form-group">
		<label class="col-lg-1">Seleção:</label>
		<p><span id="spnSel">Aguarde...</span></p>
	</div>

	<div class="form-group">
		<div class="col-md-offset-2 col-md-10">

            <button onclick="return fProcessar(this);">Processar GET
				<span url='@Url.Action("ProcessarGet", "Grid")' tipo='GET'></span>
			</button>

			<button onclick="return fProcessar(this);">Processar POST
				<span url='@Url.Action("ProcessarPost", "Grid")' tipo='POST'></span>
			</button>

            <button onclick="return fTeste();" >Teste
				<span url="@Url.Action("Teste", "Grid")"></span>
			</button>
		</div>
	</div>

</div>
