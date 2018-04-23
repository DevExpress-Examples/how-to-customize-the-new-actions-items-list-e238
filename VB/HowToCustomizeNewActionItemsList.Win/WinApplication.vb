Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Win

Partial Public Class HowToCustomizeNewActionItemsListWindowsFormsApplication
	Inherits WinApplication
	Public Sub New()
		InitializeComponent()
	End Sub

	Private Sub HowToCustomizeNewActionItemsListWindowsFormsApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
        If System.Diagnostics.Debugger.IsAttached Then
            e.Updater.Update()
            e.Handled = True
        Else
            Throw New InvalidOperationException("The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application." & Constants.vbCrLf & _
                "The automatical update is disabled, because the application was started without debugging." & Constants.vbCrLf & _
                "You should start the application under Visual Studio, or modify the source code of the " & _
                "'DatabaseVersionMismatch' event handler to enable automatic database update, " & _
                "or manually create a database with the help of the 'DBUpdater' tool.")
        End If
	End Sub
End Class
