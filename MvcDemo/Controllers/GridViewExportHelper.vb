'Imports System
'Imports System.Collections
'Imports System.Collections.Generic

'Public Enum GridViewExportFormat
'	None
'	Pdf
'	Xls
'	Xlsx
'	Rtf
'	Csv
'End Enum

'Public Delegate Function GridViewExportMethod(settings As GridViewSettings, dataObject As Object) As actionresult

'Public Class GridViewEGridViewExportDemoHelper
'	Shared ExcelDataAwareGridViewSettingsKey = "51172A18-2073-426B-A5CB-136347B3A79F"
'	Shared FormatConditionsExportGridViewSettingsKey = "14634B6F-E1DC-484A-9728-F9608615B628"

'	Shared _exportFormatsInfo As Dictionary(Of GridViewExportFormat, GridViewExportMethod)

'	Public Shared Property ExportFormatsInfo() As Dictionary(Of GridViewExportFormat, GridViewExportMethod)
'		Get
'			If (_exportFormatsInfo Is Nothing) Then ExportFormatsInfo = CreateExportFormatsInfo()
'			Return _exportFormatsInfo
'		End Get
'		Set(value As Dictionary(Of GridViewExportFormat, GridViewExportMethod))

'		End Set
'	End Property

'	Shared Property Context As IDictionary
'		Get
'			Return System.Web.HttpContext.Current.Items
'		End Get
'		Set(value As IDictionary)
'		End Set
'	End Property


'	Shared Function CreateExportFormatsInfo() As Dictionary(Of GridViewExportFormat, GridViewExportMethod)
'            return new Dictionary(Of GridViewExportFormat, GridViewExportMethod) with {
'                { .GridViewExportFormat.Pdf, .GridViewExtension.ExportToPdf },
'                {
'                    .GridViewExportFormat.Xls,
'                    function (settings, data)  .GridViewExtension.ExportToXls(settings, data, new XlsExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
'                },
'                { 
'                    .GridViewExportFormat.Xlsx,
'                    function (settings, data) .GridViewExtension.ExportToXlsx(settings, data, new XlsxExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
'                },
'                { .GridViewExportFormat.Rtf, .GridViewExtension.ExportToRtf },
'                {
'                    .GridViewExportFormat.Csv,
'                    function (settings, data) .GridViewExtension.ExportToCsv(settings, data, new CsvExportOptionsEx { ExportType = DevExpress.Export.ExportType.WYSIWYG })
'                }
'            }
'	End Function

'End Class
