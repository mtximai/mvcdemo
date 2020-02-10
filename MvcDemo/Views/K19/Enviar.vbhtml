@*
	===================================
	05.02.16 - Faz upload de um arquivo
	===================================
*@

@Code
    ViewData("Title") = "Upload de arquivo"
End Code

<h4>Enviar um arquivo (1 MB máximo) e salva em uma tabela no SQLServer</h4>
<hr />

@ModelType Arquivo

@Using (Html.BeginForm("Enviar", "K19", FormMethod.Post, New With {.id = "frmUpload", .enctype = "multipart/form-data"}))
	@Html.AntiForgeryToken()

	@<div class="form-horizontal" role="form" id="f1">
	 	<div class="form-group">
	 		@Html.LabelFor(Function(model) model.FileName, htmlAttributes:=New With {.class = "control-label col-md-2"})

			<div class="col-md-4">
				@Html.TextBoxFor(Function(model) model.Anexo, New With {.type = "file", .class = "form-control input-sm", .rows = "5", .style = "resize:none; align:left", .id="id_anexo"})
				@Html.ValidationMessageFor(Function(model) model.FileName, "", New With {.class = "text-danger"})
			</div>
		</div>

	 	<div class="form-group">
	 		@Html.LabelFor(Function(model) model.Obs, htmlAttributes:=New With {.class = "control-label col-md-2"})

	 		<div class="col-md-7">
	 			@Html.EditorFor(Function(model) model.Obs, New With {.htmlAttributes = New With {.class = "form-control input-sm"}})
	 			@Html.ValidationMessageFor(Function(model) model.Obs, "", New With {.class = "text-danger"})
			 </div>
		 </div>

	 	<div class="form-group">
	 		<div class="col-md-offset-2 col-md-6">
	 			<input type="submit" value="Encaminhar" onclick="return f_check();" class="btn btn-warning" />
	 			<input type="reset" value="Cancelar" id="btnCancelar" class="btn btn-default" />
	 		</div>
	 	</div>

		<script>
			// Valida o tamanho do máximo do arquivo:
			function f_check() {
				var size = parseFloat($("#id_anexo")[0].files[0].size / 1024).toFixed(2);

				if (size > 1000) {
					alert(size + " KB. (1 MB maximo)");
					return false;
				}
				return true;
			}
		</script>
	</div>
End Using