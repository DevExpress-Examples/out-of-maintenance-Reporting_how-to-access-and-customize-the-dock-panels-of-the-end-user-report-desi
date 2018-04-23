Imports Microsoft.VisualBasic
#Region "#Imports"
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraReports.UserDesigner
' ...
#End Region ' #Imports

Namespace AccessDockPanels
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#Code"
Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
    ' Create an End-User Designer form.
    Dim designForm As New XRDesignForm()

    ' Open a new blank report in it.
    designForm.OpenReport(New XtraReport1())

    ' Access the Group and Sort panel.
    Dim groupSort As GroupAndSortDockPanel = _ 
CType(designForm.DesignDockManager(DesignDockPanelType.GroupAndSort), GroupAndSortDockPanel)
    groupSort.Visibility = DockVisibility.AutoHide

    ' Access the Script Errors panel.
    Dim errorList As ErrorListDockPanel = _ 
CType(designForm.DesignDockManager(DesignDockPanelType.ErrorList), ErrorListDockPanel)
    errorList.Visibility = DockVisibility.AutoHide

    ' Access the Field List.
    Dim fieldList As FieldListDockPanel = _ 
CType(designForm.DesignDockManager(DesignDockPanelType.FieldList), FieldListDockPanel)
    fieldList.ShowNodeToolTips = False
    fieldList.ShowParametersNode = False

    ' Access the Report Explorer.
    Dim reportExplorer As ReportExplorerDockPanel = _ 
CType(designForm.DesignDockManager(DesignDockPanelType.ReportExplorer), ReportExplorerDockPanel)
    reportExplorer.CollapseAll()

    ' Access the Property Grid.
    Dim propertyGrid As PropertyGridDockPanel = _ 
CType(designForm.DesignDockManager(DesignDockPanelType.PropertyGrid), PropertyGridDockPanel)
    propertyGrid.ShowCategories = False
    propertyGrid.ShowDescription = False

    ' Show the End-User Designer form.
    designForm.ShowDialog()
End Sub
#End Region ' #Code
    End Class
End Namespace
