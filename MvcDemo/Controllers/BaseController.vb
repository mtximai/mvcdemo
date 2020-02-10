'24/01/17

'Imports log4net
'Imports Microsoft.AspNet.Identity
'Imports Rotativa.MVC
'Imports Rotativa.Core.Options
Imports System.Net

Namespace Controllers
    Public MustInherit Class BaseController
        Inherits Controller

		Protected Overrides Sub OnActionExecuting(filterContext As ActionExecutingContext)

			Dim loggedUser = "Usuário Anônimo"

			If Not filterContext.HttpContext.User Is Nothing And filterContext.HttpContext.User.Identity.IsAuthenticated Then

				loggedUser = filterContext.HttpContext.User.Identity.Name

			End If

			Dim usuaroLogado = filterContext.HttpContext.User.Identity.IsAuthenticated


			Dim version = filterContext.Controller.GetType().Assembly.GetName().Version

			Dim versao = String.Format("V. {0}.{1}.{2} {3}{4}", version.Major, version.Minor, version.Build, If(version.Revision > 0, "RC", String.Empty), If(version.Revision > 0, version.Revision, String.Empty))


			Log(filterContext)

		End Sub

		Protected Overrides Sub OnException(filterContext As ExceptionContext)

			If Logger.IsErrorEnabled Then Logger.Error(String.Format("OnException - Controller:{0}", filterContext.Controller), filterContext.Exception)

			MyBase.OnException(filterContext)

		End Sub


		Private Sub Log(ByVal filterContext As ActionExecutingContext)

			Try

				Dim parametersValues As New StringBuilder

				For i = 0 To filterContext.ActionParameters.Keys.Count - 1

					Dim parameter = String.Empty

					If (filterContext.ActionParameters.Values(i) IsNot Nothing) Then

						parameter = filterContext.ActionParameters.Values(i).ToString

					End If

					parametersValues.AppendFormat("Parameter: {0} - value: {1};", filterContext.ActionParameters.Keys(i).ToString, parameter)

				Next

				Logger.InfoFormat("OnActionExecuting --> UserHost: {4}, ComputerName: {5}, Controller: {0}, Action: {1}, ActionParameters:{2}", filterContext.Controller, filterContext.ActionDescriptor.ActionName, parametersValues, Request.LogonUserIdentity.Actor, Request.UserHostName, GetComputerName(Request.UserHostName))

			Catch ex As Exception

				Logger.ErrorFormat("Erro ao logar  Controller: {0}, Action: {1} ", filterContext.Controller, filterContext.ActionDescriptor.ActionName)

			End Try

		End Sub

		Private Function GetComputerName(ip As String) As String

			Dim result = String.Empty

			Try
				Dim ipAdd = IPAddress.Parse(ip)

				Dim GetIPHost = Dns.GetHostEntry(ipAdd)

				Dim compName = GetIPHost.HostName.Split({"."}, StringSplitOptions.RemoveEmptyEntries).ToList

				result = compName.First

			Catch ex As Exception
				result = "Não localizado"
			End Try

			Return result

		End Function


	End Class

End Namespace