@*
	08/09/16
*@

@ModelType ModeloComunicado


<script>

	function f_ActiveTabChanged(s, e) {

		console.log(s);
		console.log(e);

		if (e.name === "Preview") {
			console.log("aba preview ativada...");
			s.syncronizedHtml = "jljlkjlkj";
		}

	}


	function f_CallbackError(s, e) {
		alert("deu erro no Callback !!!");
	}

</script>


<div class="form-group">
	
	@Using (Html.BeginForm("HtmlEditar", "Home", FormMethod.Post, New With {.id = "id_frm1"}))
		@Html.HiddenFor(Function(m) m.CdModelo)

		@<div class="form-group">

			@Html.LabelFor(Function(m) m.Titulo, New With {.class = "control-label col-md-2"})

			<div class="col-md-10">
				@Html.EditorFor(Function(m) m.Titulo)
			</div>
		</div>
	
		@<div class="form-group">

		 	<div class="col-md-10">
			   	@Html.Action("HtmlEditorPartial", Model)
			 </div>

		 </div>

		@<div class="form-group">
			<div class="col-md-offset-2 col-md-10">
				<input type="submit" value="Save" class="btn btn-default" />
			</div>
		</div>

	End Using

</div>