<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128619738/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T110842)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Breadcrumb Editor - Create a folder navigation bar (File Explorer)

This example demonstrates how to use the [WinForms Breadcrumb Editor](https://docs.devexpress.com/WindowsForms/16973/controls-and-libraries/editors-and-simple-controls/breadcrumb-edit-control) to create a folder navigation bar inspired by Microsoft Windows File Explorer.

![WinForms Breadcrumb Editor - Create a folder navigation bar](https://raw.githubusercontent.com/DevExpress-Examples/how-to-create-a-file-explorer-via-breadcrumb-edit-control-t110842/14.1.3%2B/media/winforms-breadcrumbedit-file-explorer.png)

Two root nodes ('Root' and 'Computer') are created at design time. Their [BreadCrumbNode.Persistent](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BreadCrumbNode.Persistent) and [BreadCrumbNode.PopulateOnDemand](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.BreadCrumbNode.PopulateOnDemand) properties are set to **true**. The **Root** node stores shortcuts to most important directories (Desktop, Windows, Program Files). The **Computer** node allows users to quickly navigate through local disks via related shortcuts.

```csharp
void InitBreadCrumbRootNode(BreadCrumbNode node) {
    node.ChildNodes.Add(new BreadCrumbNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)));
    node.ChildNodes.Add(new BreadCrumbNode("Windows", Environment.GetFolderPath(Environment.SpecialFolder.Windows)));
    node.ChildNodes.Add(new BreadCrumbNode("Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)));
}
void InitBreadCrumbComputerNode(BreadCrumbNode node) {
    foreach (DriveInfo driveInfo in GetFixedDrives()) {
        node.ChildNodes.Add(new BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory));
    }
}
```

The following events are handled to dynamically generate the Nodes tree according to the folder structure:

* [ValidatePath](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit.ValidatePath)
* [NewNodeAdding](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit.NewNodeAdding)
* [QueryChildNodes](https://docs.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemBreadCrumbEdit.QueryChildNodes)


## Files to Review

* [Form1.cs](./CS/FileNavigator/Form1.cs)


## Documentation

* [Breadcrumb Edit Control](https://docs.devexpress.com/WindowsForms/16973/controls-and-libraries/editors-and-simple-controls/breadcrumb-edit-control)
* [Create Breadcrumb Nodes at Design Time](https://docs.devexpress.com/WindowsForms/114784/controls-and-libraries/editors-and-simple-controls/breadcrumb-edit-control/how-to-create-breadcrumb-nodes-at-design-time)
* [Create Breadcrumb Nodes at Runtime](https://docs.devexpress.com/WindowsForms/114783/controls-and-libraries/editors-and-simple-controls/breadcrumb-edit-control/how-to-create-breadcrumb-nodes-at-runtime)


## See Also

* [WinForms File and Folder Browsers](https://docs.devexpress.com/WindowsForms/403445/controls-and-libraries/messages-notifications-and-dialogs/file-and-folder-browsers)
* [Custom Browsers (FileExplorerAssistant Component)](https://docs.devexpress.com/WindowsForms/403431/controls-and-libraries/messages-notifications-and-dialogs/custom-folder-browsers)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-file-explorer-breadcrumb-folder-nav&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-file-explorer-breadcrumb-folder-nav&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
