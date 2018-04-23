Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraReports.UserDesigner
' ...

Namespace CustomizeDockPanels
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			' Create an End-User Designer Form.
			Dim designForm As New XRDesignFormEx()

			' Open a new blank report in it.
			designForm.DesignPanel.ExecCommand(ReportCommand.NewReport)

			' Customize the Group and Sort panel.
			Dim groupSort As GroupAndSortDockPanel = CType(designForm.DesignDockManager(DesignDockPanelType.GroupAndSort), GroupAndSortDockPanel)
			groupSort.Visibility = DockVisibility.AutoHide

			' Customize the Script Errors panel.
			Dim errorList As ErrorListDockPanel = CType(designForm.DesignDockManager(DesignDockPanelType.ErrorList), ErrorListDockPanel)
			errorList.Visibility = DockVisibility.AutoHide

			' Customize the Field List panel.
			Dim fieldList As FieldListDockPanel = CType(designForm.DesignDockManager(DesignDockPanelType.FieldList), FieldListDockPanel)
			fieldList.ShowNodeToolTips = False
			fieldList.ShowParametersNode = False

			' Customize the Report Explorer panel.
			Dim reportExplorer As ReportExplorerDockPanel = CType(designForm.DesignDockManager(DesignDockPanelType.ReportExplorer), ReportExplorerDockPanel)
			reportExplorer.CollapseAll()

			' Customize the Property Grid panel.
			Dim propertyGrid As PropertyGridDockPanel = CType(designForm.DesignDockManager(DesignDockPanelType.PropertyGrid), PropertyGridDockPanel)
			propertyGrid.ShowCategories = False
			propertyGrid.ShowDescription = False

			' Show the End-User Designer form.
			designForm.ShowDialog()
		End Sub
	End Class
End Namespace