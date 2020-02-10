//Aplica máscara do JQuery:

var gSelRowIds;

$(function () {

    $("#grdTeste").bind("jqGridBeforeSelectRow", function (e, rowid, orgClickEvent) {

        console.log("jqGridBeforeSelectRow: id = " + rowid);

        // if we want to return true, we should test e.result additionally
        //return e.result === undefined ? true : e.result;

        //var iCol = $("#grdTeste").jgrid.getCellIndex($(e.target).closest("td")[0]);

        var iCel = orgClickEvent.target.cellIndex;

        console.log("jqGridBeforeSelectRow: voce clicou na coluna " + iCel);


        if (iCel) {
            return false;
        }
        else {
            return true;
        }
    });


    $("#grdTeste").bind("jqGridBeforeRequest", function () {
        console.log("jqGridBeforeRequest");

        var v = jQuery('#grdTeste').jqGrid('getGridParam', 'selarrrow');

    });

});


function fTeste() {
    console.log("fTeste ...");
			
    // funciona: dispara o evento onSelectRow
    //$("#grdTeste").setSelection('200');

    // com true: dispara o evento onSelectRow:
    $("#grdTeste").jqGrid('setSelection', '200', true);

}


function grdGridComplete() {
    console.log("grdGridComplete...");

    var i, count;

    // Restaura a seleçãod as linhas:
    if (gSelRowIds) {

        count = gSelRowIds.length;

        for (i = 0; i < count; i++) {
            $("#grdTeste").jqGrid('setSelection', gSelRowIds[i], false);
        }

    }

    atualizarLegendaSel();

}

function grdBeforeRequest() {

    console.log("grdBeforeRequest() ...");

}

		
function grdLoadBeforeSend() {

    console.log("grdLoadBeforeSend() ...");

    //gSel = $("#grdTeste").jqGrid('getGridParam', 'selarrrow');

}


function grdSelectRow(rowid, status) {

    console.log("grdSelectRow(): " + rowid + " - " + status);

    atualizarLegendaSel();

    return false;

}


function grdSelectAll(aRowids, status) {

    console.log("grdSelectAll(): " + aRowids + " - " + status);

    atualizarLegendaSel();

    return false;

}


function grdCellSelect(rowid, iCol, cellcontent, e) {

    return false;
}


// 30/03/17
function atualizarLegendaSel() {

    // Salva linhas seleciondas para posterior restore:
    gSelRowIds = jQuery('#grdTeste').jqGrid('getGridParam', 'selarrrow');

    var mRecCount = jQuery('#grdTeste').jqGrid('getGridParam', 'reccount');

    $("#spnSel").html(gSelRowIds.length + " / " + mRecCount);

}



function fProcessar(obj) {
	var pUrl, pType, mDataToSend, pContentType;

	pUrl = $(obj).find("span").attr("url");
	pType = $(obj).find("span").attr("tipo");

	//pContentType = 'application/json; charset=utf-8';

    var gridRows = $("#grdTeste").jqGrid('getRowData');
    var sel = $("#grdTeste").jqGrid('getGridParam', 'selarrrow');


    mDataToSend = JSON.stringify({ pSel: sel, pTipo: "P" });

	// Para enviar via GET ou POST => NÃO UTILIZE Json.stringfy()
    mDataToSend = { pTipo: "P", pTexto: "minha mensagem", pSel: [10,20] };


	/*
	-	contentType	: When sending data to the server, use this content type.
			tipo: boolean / string
				false => As of jQuery 1.6 you can pass false to tell jQuery to not set any content type header.

	-	dataType	: The type of data that you're expecting back from the server.

			tipo: string
			default: Intelligent Guess (xml, json, script, or html)
			domínio: json|text|html|xml|script	

	-	data		: 
	*/

    $.ajax({
        url: pUrl,
        type: pType,
        data: mDataToSend,
		contentType: pContentType,
        dataType: 'text',

        success: function (result) {
            console.log('Ajax sucesso: ' + result);

            $("#spnMsg").html(result);
        },
        complete: function () {
            console.log('Ajax complete.');
        },
        error: function () {
            console.log("Ajax Erro: " + pUrl)
        }

    });
		    
    return true;

}
