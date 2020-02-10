Imports System.Web.Optimization
'Imports MvcDemo.CustomLocalizer

Public Class MvcApplication
	Inherits System.Web.HttpApplication

	Protected Sub Application_Start()
		AreaRegistration.RegisterAllAreas()
		FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters)
		RouteConfig.RegisterRoutes(RouteTable.Routes)
		BundleConfig.RegisterBundles(BundleTable.Bundles)

		ModelBinders.Binders.DefaultBinder = New DevExpress.Web.Mvc.DevExpressEditorsBinder()
		AddHandler DevExpress.Web.ASPxWebControl.CallbackError, AddressOf Application_Error

		'MyGridLocalizer.Activate()

		ConfigureLog4Net()

	End Sub

	Protected Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
		Dim exception As Exception = System.Web.HttpContext.Current.Server.GetLastError()
		'TODO: Handle Exception
	End Sub

End Class
