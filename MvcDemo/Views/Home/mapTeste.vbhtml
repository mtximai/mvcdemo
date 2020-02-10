@Code
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h3>Teste com Image Map</h3>


<div>
	<img src="~/Content/Images/aplicativos.png" alt="Aplicativos" usemap="#aplicativos">

	<map name="Aplicativos" id="Aplicativos">
		<area alt="Calc"    title="Libre Office Calc"    href="" shape="rect" coords="91,57,5,5" onclick="alert('Libre Office Calc');" />
		<area alt="Writer" title="Libre Office Writer" href="" shape="rect" coords="175,71,108,2" onclick="alert('Libre Office Writer');" />
		<area alt="Visio" title="Microsoft Visio 2010" href="" shape="rect" coords="280,71,195,3" onclick="alert('Microsoft Visio 2010');" />
	</map>

</div>
