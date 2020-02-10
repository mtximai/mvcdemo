@* TESTE MVC - 04.02.16 *@

@Code
	'Layout = "~/Views/Shared/_Layout.vbhtml"
End Code


@* Strongly Typed Models *@
@ModelType Editora

@Code
	ViewData("Title") = "Teste com Razor"
	ViewBag.Titulo = "Teste com Razor"
End Code

@HELPER LabelCustomizado(p As String)
	@<label class="xxx"><mark>@p</mark></label>
End Helper

@Section Scripts
	@Scripts.Render("/bundles/jqueryval")
	@Scripts.Render("/Scripts/jquery.mask.min.js")
	@Scripts.Render("/ScriptsLocais/Scripts")
End Section

@Scripts.Render("/Scripts/bootbox.min.js")


@Using (Html.BeginForm(Nothing, Nothing, FormMethod.Post, New With {.id = "f2"}))
	@Html.AntiForgeryToken()
	
	@<script type="text/javascript">
		console.log("entrada");
		bootbox.alert("Hello world!");
	</script>
	
	@<input type="button" value="BootBox - Confirm" onclick="return f_bootBox();" />
	
End Using


<script type="text/javascript">

	function f_bootBox() {
		// dialogoConfirmar(titulo, mensagem, callbackConfirmar, callbackCancelar)

		dialogoConfirmar("Meu Título", "Minha mensagem", function () { alert("callbackConfirmar"); }, function() { alert("callbackCancelar");});



	}




</script>


