Imports System.ComponentModel.DataAnnotations

Public Class Arquivo
	'<Required(AllowEmptyStrings:=False, ErrorMessage:="O campo '{0}' é obrigatório")>
	<Display(Name:="Nome do arquivo")>
	<StringLength(50, ErrorMessage:="O tamanho do nome do anexo deve ser inferior a 30 caracteres")>
	Property FileName As String

	'Para suporte ao Upload de arquivo:
	Public Anexo As HttpPostedFileBase

	Property Obs As String
End Class
