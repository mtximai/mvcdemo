' Origem: Ouvidoria
' Data..: 01/12/16

Imports log4net
Imports log4net.Repository.Hierarchy
Imports log4net.Appender
Imports System.Data.Entity.Core

Public Module Log4NetConfig

	Public ReadOnly Logger As ILog = LogManager.GetLogger(GetType(Log4NetConfig))

	Public Sub ConfigureLog4Net()
		Config.XmlConfigurator.Configure()
		ConfigureLog4NetCustomADO()
	End Sub

	Private Sub ConfigureLog4NetCustomADO()

		Dim hierarchy As Hierarchy = TryCast(LogManager.GetRepository(), Hierarchy)

		If hierarchy IsNot Nothing AndAlso hierarchy.Configured Then

			For Each appender As IAppender In hierarchy.GetAppenders()

				If TypeOf appender Is AdoNetAppender Then

					Dim adoNetAppender = DirectCast(appender, AdoNetAppender)

					Dim connectionString = ConfigurationManager.ConnectionStrings("ProtonEntities").ToString

					Dim entityConnectionString As New EntityClient.EntityConnectionStringBuilder(connectionString)

					adoNetAppender.ConnectionString = entityConnectionString.ProviderConnectionString

					'Refresh AdoNetAppenders Settings
					adoNetAppender.ActivateOptions()

				End If

			Next

		End If

	End Sub

	'TODO: Pensar em usar no futuro
	Private Sub ChangeLogLevel()
		DirectCast(Logger.Logger, Repository.Hierarchy.Logger).Level = Core.Level.Alert

		' #region SetDynamicallyLogLevel


		'Logger.Debug ( userObj, logger, " -- Debug msg -- " );
		'Logger.Info ( userObj, logger, " -- Info msg -- " );
		'Logger.Warn ( userObj, logger, " -- Warn msg -- " );
		'Logger.Error ( userObj, logger, " -- Error msg -- " );
		'Logger.Fatal ( userObj, logger, " -- Fatal msg -- " );
		'#endregion SetDynamicallyLogLevel

	End Sub
End Module
