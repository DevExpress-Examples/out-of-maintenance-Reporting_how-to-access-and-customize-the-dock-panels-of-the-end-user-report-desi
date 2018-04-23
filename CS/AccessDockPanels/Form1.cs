#region #Usings
using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraReports.UserDesigner;
// ...
#endregion #Usings

namespace AccessDockPanels {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

#region #Code
private void button1_Click(object sender, EventArgs e) {
    // Create an End-User Designer form.
    XRDesignForm designForm = new XRDesignForm();

    // Open a new blank report in it.
    designForm.OpenReport(new XtraReport1());

    // Access the Group and Sort panel.
    GroupAndSortDockPanel groupSort =
(GroupAndSortDockPanel)designForm.DesignDockManager[DesignDockPanelType.GroupAndSort];
    groupSort.Visibility = DockVisibility.AutoHide;

    // Access the Script Errors panel.
    ErrorListDockPanel errorList =
(ErrorListDockPanel)designForm.DesignDockManager[DesignDockPanelType.ErrorList];
    errorList.Visibility = DockVisibility.AutoHide;

    // Access the Field List.
    FieldListDockPanel fieldList =
(FieldListDockPanel)designForm.DesignDockManager[DesignDockPanelType.FieldList];
    fieldList.ShowNodeToolTips = false;
    fieldList.ShowParametersNode = false;

    // Access the Report Explorer.
    ReportExplorerDockPanel reportExplorer =
(ReportExplorerDockPanel)designForm.DesignDockManager[DesignDockPanelType.ReportExplorer];
    reportExplorer.CollapseAll();

    // Access the Property Grid.
    PropertyGridDockPanel propertyGrid =
(PropertyGridDockPanel)designForm.DesignDockManager[DesignDockPanelType.PropertyGrid];
    propertyGrid.ShowCategories = false;
    propertyGrid.ShowDescription = false;

    // Show the End-User Designer form.
    designForm.ShowDialog();
}
#endregion #Code

    }
}


