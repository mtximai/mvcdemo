﻿@Code
    Layout = nothing
End Code

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Teste com Rotativa - 06/01/17</title>
</head>

<body>
	<div id="container">
		<div id="cabecalho">
			<div id="nome">
				<h1>RECIBO DE DISPENSAÇÃO</h1>
			</div>
			<div id="unidade">
				<h2>Meu Sistema</h2>
				<h3>Hospital São Paulo</h3>
				<h4>Farmácia</h4>
			</div>
		</div>
		<div id="corpo">
			<div class="linha">
				<p>
					Dispensado:<br />
					<span>10/10/2012</span>
				</p>
				<p>
					Cartão do SUS:<br />
					<span>123.1232.123.123</span>
				</p>
				<p>
					Usuario:<br />
					<span class="bold">João da Silva Gonçalves</span>
				</p>
			</div>
			<div class="linha">
				<p>
					Prescritor:<br />
					<span>Jonas São João</span>
				</p>
				<p>
					Nº Registro:<br />
					<span>12323132</span>
				</p>
				<p>
					Origem da Receita:<br />
					<span>10/10/012</span>
				</p>
			</div>
			<div class="linha">
				<p>Produtos Dispensados:</p>
				<table>
					<thead>
						<tr>
							<th>Produto</th>
							<th>Atendido?</th>
							<th>Und</th>
							<th class="aling-right">Dispensado</th>
							<th class="aling-right">Unitário R$</th>
							<th class="aling-right">Total R$</th>
						</tr>
					</thead>

					<tbody>

						<tr class="odd">
							<td class="bold" width="45%">Anador</td>
							<td>Sim</td>
							<td class="fonte10">FRS</td>
							<td class="aling-right">10</td>
							<td class="aling-right" width="100px;">1,2345</td>
							<td class="aling-right" style="min-width: 100px">12,23</td>
						</tr>
						<tr class="odd">
							<td colspan="6" class="italico">Possologia: 1 dose, 3 vez por dia, durante 5 dias</td>
						</tr>

						<tr class="">
							<td class="bold" width="45%">Dipirona</td>
							<td>Sim</td>
							<td class="fonte10">FRS</td>
							<td class="aling-right">10</td>
							<td class="aling-right" width="100px;">1,2345</td>
							<td class="aling-right" style="min-width: 100px">12,23</td>
						</tr>
						<tr class="">
							<td colspan="6" class="italico">Possologia: 1 dose, 3 vez por dia, durante 5 dias</td>
						</tr>

					</tbody>
					<tfoot>
						<tr>
							<td colspan="5" class="bold">Total</td>
							<td class="aling-right">R$ 12,23</td>
						</tr>
					</tfoot>
				</table>
			</div>
			<div class="linha">
				<p>
					Observação:<br />
					<span>Paciente com fortes dores de cabeça</span>
				</p>
			</div>
		</div>
		<div id="rodape">
			<p>Usuário: <span>Cleyton Ferrari</span> Emitido: <span>26/10/2012</span> CleytonFerrari.com</p>
		</div>
	</div>

</body>

</html>
