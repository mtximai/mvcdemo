@*
	@Imports DevExpress.Web.Mvc.UI
*@

<script type="text/javascript">
	// *****************************
	// *  EVENTOS O COLUMN CHOOSER
	// *****************************
	$(document).ready(function () {
		$("#btVisibilidadeColunas").click(
            function () {
            	f_visibilidade();
            }
        );
	});

	function grid_CustomizationWindowCloseUp(s, e) {
		UpdateButtonText();
	}

	function f_visibilidade() {
		TesteGrid.ShowCustomizationWindow();
		//UpdateButtonText();
	}

	/*
	function UpdateButtonText() {
		var text = TesteGrid.IsCustomizationWindowVisible() ? "Ocultar" : "Exibir";
		text += " Customizar colunas";

		$("#btShowCustomizationWindow").val(text);
	}
	*/


	// ***********************
	// *  EVENTOS DA GRID
	// ***********************
	function SelectionChanged(s, e) {
		s.GetSelectedFieldValues("Nome", f_SelectedCallback);
		$("#count").html(TesteGrid.GetSelectedRowCount());
	}

	function f_SelectedCallback(values) {
		idListBox.BeginUpdate();

		try {
			idListBox.ClearItems();

			for (var i = 0; i < values.length; i++) {
				idListBox.AddItem(values[i]);
			}
		} finally {
			idListBox.EndUpdate();
		}
	}

	function OnGridFocusedRowChanged(s, e) {
		s.GetRowValues(s.GetFocusedRowIndex(), 'Id;Nome', f_OnGetRowValues);
	}

	function f_OnGetRowValues(values) {
		idMemo.SetText(values[0] + " - " + values[1]);
	}


	// 
	function f_click() {
		console.log("click no botão grid");
	}


</script>


<h4>** Teste com DevExpress / GridView **</h4>

<div id="x1" class="">
	<div class="form-group">
		@Using (Html.BeginForm("ExportTo", "Home"))
			@<input type="button" id="btVisibilidadeColunas" value="Visibilidade de Colunas" style="width: 200px;"/>
		
			@<input type="submit" name="Exportar" value="Exportar XLS" />

			@Html.Partial("TesteGridPartial", Model)
		End Using
	</div>


	<div class="form-group">
		Qt.selecionada:&nbsp;<strong id="count">0</strong>
	</div>
	
	<div class="form-horizontal">
		<div class="col-md-4">
			@Html.DevExpress().Memo(
				Sub(settings)
						settings.Name = "idMemo"
						settings.Properties.EnableClientSideAPI = True
						settings.ControlStyle.CssClass = "memo"
						settings.ReadOnly = True
						settings.Width = 350
						settings.Height = 150
				End Sub
			).GetHtml()
		</div>

		<div class="col-md-offset-5">
			@Html.DevExpress().ListBox(
				Sub(settings)
						settings.Name = "idListBox"
						settings.Width = 350
						settings.Height = 150
						settings.Properties.EnableClientSideAPI = True
				End Sub
			).GetHtml()
		</div>
	</div>
</div>
