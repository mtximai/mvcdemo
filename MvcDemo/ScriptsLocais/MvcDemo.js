//Aplica máscara do JQuery:
$(function () {

});


function dialogoConfirmar(titulo, mensagem, callbackConfirmar, callbackCancelar) {

	bootbox.dialog({
		message: mensagem,
		title: titulo,
		buttons: {
			confirmar: {
				label: "Confirmar",
				className: "btn-primary",
				callback: callbackConfirmar
			},
			cancelar: {
				label: "Cancelar",
				className: "btn-warning",
				callback: callbackCancelar
			}
		}
	});

};
