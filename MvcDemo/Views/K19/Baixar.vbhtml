@Code
	ViewData("Title") = "Obter arquivo"
End Code

<h2>CadConta</h2>

@ModelType Arquivo


@Using (Html.BeginForm("ObterArquivo", "K19", FormMethod.Post, New With {.id = "frmUpload", .enctype = "multipart/form-data"}))
	@Html.AntiForgeryToken()

	@<div class="form-horizontal" role="form" id="f1">
	 	<div class="form-group">
	 		<div class="col-md-offset-2 col-md-6">
	 			<input type="submit" value="Baixar arquivo" onclick="return confirmarSubmit()" class="btn btn-warning" />
	 			<input type="reset" value="Cancelar" id="btnCancelar" class="btn btn-default" />
	 		</div>
	 	</div>
	</div>
End Using