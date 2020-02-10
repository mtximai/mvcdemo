@*
	09/05/16
*@

<style type="text/css">
	.GridViewRootClassName .glyphicon {
		cursor: pointer;
	}
</style>

<h4>DevExpress / GridView (definições da grid no Grid2.html)</h4>
<h5>How to use Bootstrap Glyphicons as Command Buttons</h5>
<hr/>

<div id="x1" class="">
	<div class="form-group">
		@Using (Html.BeginForm("ExportTo", "Home"))
			@Html.Partial("Grid2Partial", Model)
		End Using
	</div>
</div>