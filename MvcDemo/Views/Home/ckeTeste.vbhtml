@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

@ModelType EmailModelo

@Scripts.Render("~/Scripts/ckeditor/ckeditor.js")

@Scripts.Render("~/Scripts/ckeditor/adapters/jquery.js")


<form method='POST' id="formTeste" action='ckeTeste'>
	<br />

	@Html.HiddenFor(Function(m) m.id)
	@Html.HiddenFor(Function(m) m.descricao)

	<div class="form-group">
		@Html.LabelFor(Function(m) m.corpo, htmlAttributes:=New With {.class = "control-label col-md-2"})

		<div class="col-md-10">
			@Html.TextAreaFor(Function(m) m.corpo, 10, 2, New With {.class = "form-control editorHTML"})
			@Html.ValidationMessageFor(Function(m) m.corpo, "", New With {.class = "text-danger"})
		</div>

	</div>


	<script>
		// Replace the <textarea id="editor1"> with a CKEditor
		// instance, using default configuration.
		//CKEDITOR.replace('corpo');

		$(".editorHTML").ckeditor();
	</script>

	<br />

	<input type="submit" value="Enviar" class="btn btn-default"/>

</form>

