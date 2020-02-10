' 06/01/17 - Testes com rotativa para geração de PDF

Imports System.Web.Mvc
Imports Rotativa.MVC
Imports Rotativa.Core.Options


Namespace Controllers

	Public Class RotativaController
		Inherits Controller

		' GET: Rotativa
		Function Index() As ActionResult

			Return View()

		End Function

		Function pdf() As ActionResult

			Return New ViewAsPdf With {
				.ViewName = "Index",
				.FileName = "NomeDoArquivoPDF.pdf"
			}

		End Function

		Function Formulario1() As ActionResult

			Return New ViewAsPdf With {
				.ViewName = "Formulario1", .RotativaOptions = PdfCOptions()
			}

		End Function

		' 10/01/17
		Function Formulario2() As ActionResult

			Dim header = Server.MapPath("~/Content/_header.html")

			Dim opt = New Rotativa.Core.DriverOptions() With {
										.PageSize = Size.A4,
										.PageOrientation = Orientation.Portrait,
										.PageMargins = New Margins With {.Bottom = 10, .Left = 15, .Right = 15, .Top = 10}
									}

			'opt.CustomSwitches = String.Format("--print-media-type  --footer-left ""TCMSP"" --footer-center "" Documento gerado dia {0} "" --footer-right ""Página [page]/[toPage]"" --footer-line --footer-font-size ""9"" --footer-spacing ""4"" --footer-font-name ""calibri light"" ", Now.ToString("dd/MM/yyyy HH:mm:ss"))

			opt.CustomSwitches = String.Format("--print-media-type  --header-html  ""{0}"" --header-spacing ""0"" ", header)

			Return New ViewAsPdf With {
				.ViewName = "Formulario2", .RotativaOptions = opt
			}

		End Function


		' 09/01/17
		Private Function PdfCOptions() As Rotativa.Core.DriverOptions

			Dim header = Server.MapPath("~/Content/_header.html")

			Dim opt = New Rotativa.Core.DriverOptions() With {
										.PageSize = Size.A4,
										.PageOrientation = Orientation.Landscape,
										.PageMargins = New Margins With {.Bottom = 10, .Left = 15, .Right = 15, .Top = 10}
									}

			'opt.CustomSwitches = String.Format("--print-media-type  --footer-left ""TCMSP"" --footer-center "" Documento gerado dia {0} "" --footer-right ""Página [page]/[toPage]"" --footer-line --footer-font-size ""9"" --footer-spacing ""4"" --footer-font-name ""calibri light"" ", Now.ToString("dd/MM/yyyy HH:mm:ss"))

			opt.CustomSwitches = String.Format("--print-media-type  --header-html  ""{0}"" ", header)


			Return opt

		End Function

	End Class

End Namespace