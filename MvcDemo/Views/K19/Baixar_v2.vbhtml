@* Teste dom jQuery fileDownload - 12/04/16 *@


@Code
	ViewData("Title") = "Obter arquivo"
End Code

<h2>Baixar arquivo com jQuery fileDownload</h2>


<div class="form-horizontal" role="form" id="f1">
	<div class="form-group">
	 	<div class="col-md-offset-2 col-md-6">
	 		<input type="button" value="Baixar arquivo com jQuery fileDownload" onclick="return f_baixarArquivo()" class="btn btn-warning" />

			@Html.ActionLink("Exemplo de download", "BaixarArquivo2", New With {.id = 10})		 
		</div>
	</div>
</div>


<script type="text/javascript">
	function f_baixarArquivo() {
		console.log("f_baixarArquivo: iniciando...");

		$.fileDownload('@(Url.Action("BaixarArquivo2", "K19"))?id=10', {

		});

		response.setHeader("Set-Cookie", "fileDownload=true; path=/");
		response.setHeader("Cache-Control", "no-cache, no-store, must-revalidate");
		console.log("f_baixarArquivo: saindo...");
	}

</script>