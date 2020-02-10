'03/02/16 

Imports System.Web.Mvc
Imports System.IO
Imports System.Data.SqlClient

Namespace Controllers
	Public Class K19Controller
		Inherits Controller

		Function Index() As ActionResult
			Return View()
		End Function

		Function Enviar() As ActionResult
			Debug.WriteLine("Chamada ao UploadFile() / GET")
			Return View("Enviar")
		End Function

		'ESTRUTURA DA TABELA PARA UPLOAD:
		'===============================
		'CREATE TABLE [dbo].[FileStore](
		'	[ID] [int] IDENTITY(1,1) NOT NULL,
		'	[FileContent] [image] NOT NULL,
		'	[MimeType] [nvarchar](50) NOT NULL,
		'	[FileName] [nvarchar](50) NOT NULL
		') ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

		<HttpPost>
		<ValidateAntiForgeryToken>
		<AllowAnonymous>
		Function Enviar(objArq As Arquivo, Anexo As HttpPostedFileBase) As ActionResult
			Dim sPath, sCon, sQuery, mimeType, sFileName As String
			Dim oCon As SqlConnection
			Dim oCmd As SqlCommand
			Dim fileStream As Stream
			Dim fileLength As Integer
			Dim fileData As Byte()

			Debug.WriteLine("Chamada ao UploadFile() / POST")

			If Not Anexo Is Nothing Then
				sPath = AppDomain.CurrentDomain.BaseDirectory + "uploads/"
				sFileName = Anexo.FileName

				'Anexo.SaveAs(Path.Combine(sPath, sFileName))

				'** Dados do arquivo **
				mimeType = Anexo.ContentType
				fileStream = Anexo.InputStream
				fileLength = Anexo.ContentLength
				fileData = New Byte(fileLength) {}

				fileStream.Read(fileData, 0, fileLength)


				'Conexão com o Banco:
				sCon = "Server=.\SQLExpress;Database=Teste;Trusted_Connection=True;"

				oCon = New SqlConnection(sCon)

				sQuery = "INSERT INTO FileStore (FileContent, MimeType, FileName) VALUES (@FileContent, @MimeType, @FileName)"
				oCmd = New SqlCommand(sQuery, oCon)

				oCmd.Parameters.AddWithValue("@FileContent", fileData)
				oCmd.Parameters.AddWithValue("@MimeType", mimeType)
				oCmd.Parameters.AddWithValue("@FileName", sFileName)

				oCon.Open()
				oCmd.ExecuteNonQuery()

			End If

			Return View("Enviar")
		End Function

		' 08/04/16
		Function Enviar_v2() As ActionResult
			Debug.WriteLine("Chamada ao UploadFile() / GET")

			Dim rs = New Editora
			rs.Nome = "Pato Donald"
			rs.Email = "pd@disney.com"""

			ViewBag.editora = rs

			Return View("Enviar_v2", rs)
		End Function


		' 08/04/16
		' <ValidateAntiForgeryToken>
		'Function Enviar_v2(Nome As String, Anexo As HttpPostedFileBase) As ActionResult


		<HttpPost>
		<AllowAnonymous>
		Function Enviar_v2(objEdi As Editora, Anexo As HttpPostedFileBase) As ActionResult
			Return View("Enviar_v2")
		End Function


		' 05.02.16 - Retora o último upload
		Function Baixar() As FileContentResult
			Dim sCon, sQuery, mimeType, sFileName As String
			Dim oCon As SqlConnection
			Dim oCmd As SqlCommand
			Dim rdr As SqlDataReader
			Dim fileContent As Byte()

			Debug.WriteLine("Chamada ao ObterArquivo() / GET")

			'Conexão com o Banco:
			sCon = "Server=.\SQLExpress;Database=Teste;Trusted_Connection=True;"
			oCon = New SqlConnection(sCon)

			'Retorna a primeira linha da tabela:
			sQuery = "SELECT TOP 1 FileContent, MimeType, FileName FROM FileStore order by id desc"
			oCmd = New SqlCommand(sQuery, oCon)

			oCon.Open()
			rdr = oCmd.ExecuteReader()

			mimeType = ""
			sFileName = ""
			fileContent = Nothing

			If (rdr.HasRows) Then
				rdr.Read()
				fileContent = rdr("FileContent")
				mimeType = rdr("MimeType").ToString()
				sFileName = rdr("FileName").ToString()
			End If

			Return File(fileContent, mimeType, sFileName)
		End Function

		Function Baixar_v2() As ActionResult
			Return View("Baixar_v2")
		End Function


		' Para teste com jQuery FileDownload - 12/04/16
		'Function BaixarArquivo2(ByVal id As Integer) As FileResult
		Function BaixarArquivo2(ByVal id As String) As FileResult
			Dim nome = "the35s.pdf"
			Dim path = "c:\temp\"

			Return File(path & nome, System.Net.Mime.MediaTypeNames.Application.Octet, nome)
		End Function


	End Class
End Namespace