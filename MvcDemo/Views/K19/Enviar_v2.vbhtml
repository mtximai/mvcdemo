@*
	===================================
	05.02.16 - Faz upload de um arquivo
	===================================
*@

@Code
    ViewData("Title") = "Upload de arquivo"
End Code

<h5>Upload de arquivo via AJAX</h5>
<h4>Enviar um arquivo (1 MB máximo) e salva em uma tabela no SQLServer</h4>
<hr />

@*
	@ModelType Editora
*@

@ModelType Editora


@Using (Html.BeginForm("Enviar_v2", "K19", FormMethod.Post, New With {.id = "frmUpload", .enctype = "multipart/form-data"}))
	@* 	@Html.AntiForgeryToken() *@
	
	
	@<div class="form-horizontal" role="form" id="f1">
	 	<div class="form-group">
	 		@Html.Label("Arquivo", "", htmlAttributes:=New With {.class = "control-label col-md-2"})

			<div class="col-md-4">
				@Html.TextBox("Anexo", "", New With {.type = "file", .class = "form-control input-sm", .rows = "5", .style = "resize:none; align:left", .id = "Anexo"})
			</div>

			<div class="col-md-2">
				@Html.TextBoxFor(Function(m) m.Email, New With {.class = "form-control input-sm", .rows = "5", .style = "resize:none; align:left"})
			</div>

			<div class="col-md-2">
				@Html.TextBox("Nome", "", New With {.class = "form-control input-sm", .rows = "5", .style = "resize:none; align:left"})
			</div>

												@*


												*@

		</div>

	 	<div class="form-group">
	 		<div class="col-md-offset-2 col-md-6">
	 			<input type="submit" value="Enviar via Submit"  class="btn btn-warning" />
	 			<input type="reset" value="Cancelar" id="btnCancelar" class="btn btn-default" />
	 		</div>
	 	</div>
	
	</div>
End Using
	
<button onclick="f_enviarAjax();" class="btn">Enviar via Ajax</button>

<script type="text/javascript">

	//$(function () {
	//	var token = $('input[name="__RequestVerificationToken"]').val();

	//	$.ajaxPrefilter(function (options, originalOptions) {
	//		if (options.type.toUpperCase() == "POST") {
	//			options.data = $.param($.extend(originalOptions.data, { __RequestVerificationToken: token }));
	//		}
	//	});

	//	alert("inicializando jscript...");
	//});



	function f_enviarAjax() {
		var formData = new FormData();

		var file = document.getElementById("Anexo").files[0];
		formData.append("Anexo", file);

		formData.append("Nome",$("#Nome").val());
		formData.append("Email", $("#Email").val());

		$.ajax({
			url: '@(Url.Action("Enviar_v2", "K19"))',

			// Tipo do conteúdo do Request:
			contentType: false,
			processData: false,

			// The type of request. It can be "GET" or "POST" or others.
			type: "POST",

			// The data that is to be sent to the server. It can be omitted if no data is
			// to be sent. In a "GET" request this data is appended to the url.
			data: formData,

			// The function to be called when the server returns some data. The data
			// variable holds the data that was returned.
			success: function (data) {
				console.log("Return do Ajax com sucesso!")
			},

			// Show an alert if an error occurs.
			error: function () {
				console.log("Return do Ajax -> Erro.")
			}
		});

	}


	// Valida o tamanho do máximo do arquivo:
	function f_check() {
		var size = parseFloat($("#Anexo")[0].files[0].size / 1024).toFixed(2);

		if (size > 1000) {
		   	alert(size + " KB. (1 MB maximo)");
		   	return false;
		}
		return true;
	}
</script>
	
