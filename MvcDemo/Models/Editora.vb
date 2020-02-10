Imports System.ComponentModel.DataAnnotations

Public Class Editora
	Public Property EditoraId As Integer

	'<Required(AllowEmptyStrings:=False, ErrorMessage:="O campo '{0}' é obrigatório")>
	'<Display(Name:="Nome", Description:="Informe seu Nome")>
	'<StringLength(10, MinimumLength:=5)>
	Public Property Nome As String

	Public Property Email As String

	'Para suporte ao Upload de arquivo:
	Public Anexo As HttpPostedFileBase

	'<Display(Name:="Anexos")>
	'<StringLength(50, ErrorMessage:="O tamanho do nome do anexo dee ser inferior a 30 caracteres")>
	'<Required(AllowEmptyStrings:=False, ErrorMessage:="O campo '{0}' é obrigatório")>
	Property FileName As String

End Class
