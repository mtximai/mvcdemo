'Imports PagedList
'Imports MvcDemo.Controllers

'Namespace Areas.Admin.Controllers

'	Public Class LogsController
'		Inherits BaseController


'		Private ReadOnly _loggingServices As ILoggingServices

'		Public Sub New(loggingServices As ILoggingServices)
'			_loggingServices = loggingServices
'		End Sub

'		' GET: Administrativa/Logs

'		<ValidateInput(False)>
'		Function Index(searchString As String, searchBeginDateString As String, searchEndDateString As String, tipoLogStr As String, sortOrder As String, page As Integer?,
'					  CurrentFiltersearchString As String, CurrentFiltersearchBeginDateString As String, CurrentFiltersearchEndDateString As String, CurrentFiltertipoLogStr As String, pageSize As Integer?, CurrentPageSize As Integer?) As ActionResult

'			Dim model = _loggingServices.Find(searchString, tipoLogStr, searchBeginDateString, searchEndDateString, sortOrder)

'			Dim logLevelList = _loggingServices.FindAllLogLevel(searchString, tipoLogStr, searchBeginDateString, searchEndDateString)

'			Dim tipoLogList = From item In logLevelList Select New With {.Text = item, .Value = item}

'			ViewBag.tipoLogStr = New SelectList(tipoLogList, "Value", "Text")


'			ViewBag.NameSortParm = If(sortOrder = "Name", "name_desc", "Name")
'			ViewBag.DateSortParm = If(String.IsNullOrEmpty(sortOrder), "date_asc", String.Empty)
'			ViewBag.sortOrder = sortOrder

'			If (CurrentFiltersearchString <> searchString OrElse
'				CurrentFiltersearchBeginDateString <> searchBeginDateString OrElse
'				CurrentFiltersearchEndDateString <> searchEndDateString OrElse
'				CurrentFiltertipoLogStr <> tipoLogStr OrElse
'				 CurrentPageSize <> pageSize
'				) Then
'				page = 1
'			End If

'			ViewBag.CurrentFiltersearchString = searchString
'			ViewBag.CurrentFiltersearchBeginDateString = searchBeginDateString
'			ViewBag.CurrentFiltersearchEndDateString = searchEndDateString
'			ViewBag.CurrentFiltertipoLogStr = tipoLogStr
'			ViewBag.CurrentPageSize = pageSize
'			Dim lisOfPageSize = From item In {10, 20, 50, 100, 200}
'							   Select New With {.Text = item, .Value = item}

'			ViewBag.pageSize = New SelectList(lisOfPageSize, "Value", "Text", 50)

'			pageSize = If(pageSize, 50)

'			Dim pageNumber = If(page, 1)

'			Return View(model.ToPagedList(pageNumber, pageSize))

'		End Function

'		Public Class MyFilter
'			Public Property searchString As String
'			Public Property searchBeginDateString As String
'			Public Property searchEndDateString As String
'			Public Property tipoLogStr As String
'		End Class
'	End Class
'End Namespace