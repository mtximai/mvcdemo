Imports System
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity
Imports MvcDemo.CadConta
Imports MvcDemo.CtbLan
Imports MvcDemo.CadParametro

<MetadataType(GetType(CadContaMetadata))>
Partial Public Class CadConta

	Friend NotInheritable Class CadContaMetadata
		Private _id_conta As String

		<Required>
		<StringLength(6, ErrorMessage:="The {0} must be at least {2} characters long.", MinimumLength:=1)>
		<Display(Name:="Conta", Description:="Informe o telefone")>
		Public id_conta As String

		<Display(Name:="Descrição", Description:="Informe o telefone")>
		Public descr As String

		<Display(Name:="Tipo", Description:="Informe o telefone")>
		Public ind_tipo As String

		<Display(Name:="Natureza", Description:="Informe o telefone")>
		Public ind_natureza As String
	End Class
End Class

<MetadataType(GetType(CtbLanMetadata))>
Partial Public Class CtbLan

	Friend NotInheritable Class CtbLanMetadata

		<Display(Name:="Id.Lan", Description:="")>
		Public id_lan As Integer

		<DataType(DataType.Date)>
		<Display(Name:="Dt.Lan", Description:="")>
		<DisplayFormat(DataFormatString:="{0:dd/MM/yyyy}", ApplyFormatInEditMode:=True)>
		Public dt_lan As Date

		Public id_contadb As String

		Public id_contacr As String

		<Display(Name:="Historico", Description:="")>
		Public obs_historico As String

		Public id_acao As String

		Public qt_acao As Nullable(Of Integer)

		<DataType(DataType.Currency)>
		<Display(Name:="Vl.Lan", Description:="")>
		<DisplayFormat(DataFormatString:="{0:###,##0.00}", ApplyFormatInEditMode:=True)>
		Public vl_lan As Decimal

	End Class
End Class

<MetadataType(GetType(CadParametroMetadata))>
Partial Public Class CadParametro

	Friend NotInheritable Class CadParametroMetadata

		<Display(Name:="Parâmetro", Description:="")>
		Public id_Parametro As String

		<Display(Name:="Descrição", Description:="")>
		Public descr As String

		<Display(Name:="Valor (STR)", Description:="")>
		Public vl_str As String

		<Display(Name:="Valor (NUM)", Description:="")>
		Public vl_num As Nullable(Of Decimal)

	End Class

End Class