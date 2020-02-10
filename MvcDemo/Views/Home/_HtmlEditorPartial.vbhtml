@Imports MvcDemo

@ModelType ModeloComunicado


@Html.DevExpress().HtmlEditor(
	Sub(settings)
			settings.Name = "Corpo"
			settings.Html = Model.Corpo
		 
			settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "HtmlEditorPartial"}
		 
			settings.Width = 700
			settings.ToolbarMode = HtmlEditorToolbarMode.Menu

			settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.UploadCallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "HtmlEditorPartialImageUpload"}
			settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.UploadFolder = HomeControllerHtmlEditorSettings.ImageUploadDirectory
			settings.SettingsDialogs.InsertImageDialog.SettingsImageUpload.ValidationSettings.Assign(HomeControllerHtmlEditorSettings.ImageUploadValidationSettings)

			settings.SettingsDialogs.InsertImageDialog.SettingsImageSelector.Assign(HomeControllerHtmlEditorSettings.ImageSelectorSettings)
	 
			settings.ClientSideEvents.ActiveTabChanged = "f_ActiveTabChanged"
			settings.ClientSideEvents.CallbackError = "f_CallbackError"
		 
	 
			'settings.SettingsHtmlEditing.UpdateDeprecatedElements = True

			'settings.SettingsHtmlEditing.AllowScripts = True
			'settings.SettingsHtmlEditing.AllowIFrames = True
			'settings.SettingsHtmlEditing.AllowFormElements = True
			'settings.SettingsHtmlEditing.UpdateBoldItalic = True
			'settings.SettingsHtmlEditing.EnterMode = True
			'settings.SettingsHtmlEditing.AllowIdAttributes = True
			'settings.SettingsHtmlEditing.AllowStyleAttributes = True
			'settings.SettingsHtmlEditing.AllowedDocumentType = True
			'settings.SettingsHtmlEditing.AllowEditFullDocument = True
			'settings.Settings.AllowCustomColorsInColorPickers = True
					 
	End Sub
).GetHtml()