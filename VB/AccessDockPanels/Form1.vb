Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace AccessDockPanels
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create an End-User Designer form.
			Dim designForm As New XRDesignForm()

			' Open a new blank report in it.
			designForm.OpenReport(New XtraReport1())

			' Customize the Group and Sort panel.
			Dim groupSort As GroupAndSortDockPanel = _ 
		CType(designForm.DesignDockManager(DesignDockPanelType.GroupAndSort), GroupAndSortDockPanel)
			groupSort.Visibility = DockVisibility.AutoHide

			' Customize the Script Errors panel.
			Dim errorList As ErrorListDockPanel = _ 
		CType(designForm.DesignDockManager(DesignDockPanelType.ErrorList), ErrorListDockPanel)
			errorList.Visibility = DockVisibility.AutoHide

			' Customize the Field List panel.
			Dim fieldList As FieldListDockPanel = _ 
		CType(designForm.DesignDockManager(DesignDockPanelType.FieldList), FieldListDockPanel)
			fieldList.ShowNodeToolTips = False
			fieldList.ShowParametersNode = False

			' Customize the Report Explorer panel.
			Dim reportExplorer As ReportExplorerDockPanel = _ 
		CType(designForm.DesignDockManager(DesignDockPanelType.ReportExplorer), ReportExplorerDockPanel)
			reportExplorer.CollapseAll()

			' Customize the Property Grid panel.
			Dim propertyGrid As PropertyGridDockPanel = _ 
		CType(designForm.DesignDockManager(DesignDockPanelType.PropertyGrid), PropertyGridDockPanel)
			propertyGrid.ShowCategories = False
			propertyGrid.ShowDescription = False

			' Show the End-User Designer form.
			designForm.ShowDialog()
		End Sub

	End Class
End Namespace
