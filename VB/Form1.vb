Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository

Namespace FileNavigator
	Public Partial Class Form1
		Inherits XtraForm
		Public Shared ReadOnly MaxEntitiesCount As Integer = 80
		Public Sub New()
			InitializeComponent()
			Initialize()
		End Sub

		Private Sub myItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			Throw New NotImplementedException()
		End Sub

		Private Sub Properties_QueryPopUp(ByVal sender As Object, ByVal e As CancelEventArgs)
			Throw New NotImplementedException()
		End Sub


        'Set the Breadcrumb Editor's initial path
		Private Sub Initialize()
			breadCrumbEdit1.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
			For Each driveInfo As DriveInfo In GetFixedDrives()
				breadCrumbEdit1.Properties.History.Add(New BreadCrumbHistoryItem(driveInfo.RootDirectory.ToString()))
			Next driveInfo
		End Sub

		Private Sub breadCrumbEdit1_Properties_NewNodeAdding(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventArgs) Handles breadCrumbEdit1.Properties.NewNodeAdding
			e.Node.PopulateOnDemand = True
		End Sub

        'Check whether or not the target path exists
		Private Sub breadCrumbEdit1_Properties_ValidatePath(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.BreadCrumbValidatePathEventArgs) Handles breadCrumbEdit1.Properties.ValidatePath
			If (Not Directory.Exists(e.Path)) Then
				e.ValidationResult = DevExpress.XtraEditors.BreadCrumbValidatePathResult.Cancel
				Return
			End If
			e.ValidationResult = DevExpress.XtraEditors.BreadCrumbValidatePathResult.CreateNodes
		End Sub

		Private Sub breadCrumbEdit1_Properties_QueryChildNodes(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventArgs) Handles breadCrumbEdit1.Properties.QueryChildNodes
            'Add custom shortcuts to the 'Root' node
			If String.Equals(e.Node.Caption, "Root", StringComparison.Ordinal) Then
				InitBreadCrumbRootNode(e.Node)
				Return
			End If
            'Add local discs shortcuts to the 'Root' node
			If String.Equals(e.Node.Caption, "Computer", StringComparison.Ordinal) Then
				InitBreadCrumbComputerNode(e.Node)
				Return
			End If
            'Populate dynamic nodes
			Dim dir As String = e.Node.Path
			If (Not Directory.Exists(dir)) Then
				Return
			End If
			Dim subDirs As String() = GetSubFolders(dir)
			Dim i As Integer = 0
			Do While i < subDirs.Length
				e.Node.ChildNodes.Add(CreateNode(subDirs(i)))
				i += 1
			Loop
		End Sub

		Private Sub InitBreadCrumbRootNode(ByVal node As BreadCrumbNode)
			node.ChildNodes.Add(New BreadCrumbNode("Desktop", Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
			node.ChildNodes.Add(New BreadCrumbNode("Windows", Environment.GetFolderPath(Environment.SpecialFolder.Windows)))
			node.ChildNodes.Add(New BreadCrumbNode("Program Files", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)))
		End Sub
		Private Sub InitBreadCrumbComputerNode(ByVal node As BreadCrumbNode)
			For Each driveInfo As DriveInfo In GetFixedDrives()
				node.ChildNodes.Add(New BreadCrumbNode(driveInfo.Name, driveInfo.RootDirectory))
			Next driveInfo
		End Sub

		Protected Function CreateNode(ByVal path As String) As BreadCrumbNode
			Dim folderName As String = New DirectoryInfo(path).Name
			Return New BreadCrumbNode(folderName, folderName, True)
		End Function

        'Get the local drives list
        Public Shared Iterator Function GetFixedDrives() As IEnumerable(Of DriveInfo)
            For Each driveInfo As DriveInfo In DriveInfo.GetDrives()
                If driveInfo.DriveType <> DriveType.Fixed Then
                    Continue For
                End If
                Yield driveInfo
            Next driveInfo
        End Function

        'Get all subfolders contained within the target directory
        Public Shared Function GetSubFolders(ByVal rootDir As String) As String()
            Dim subDirs As String() = GetSubDirs(rootDir)
            If subDirs Is Nothing Then
                Return New String() {}
            End If
            If subDirs.Length <= MaxEntitiesCount Then
                Return subDirs
            End If
            Dim res As String() = New String(MaxEntitiesCount - 1) {}
            Array.Copy(subDirs, res, res.Length)
            Return res
        End Function

        'Get the names of the subdirectories
        Public Shared Function GetSubDirs(ByVal dir As String) As String()
            Dim subDirs As String() = Nothing
            Try
                subDirs = Directory.GetDirectories(dir, "*", SearchOption.TopDirectoryOnly)
            Catch
            End Try
            Return subDirs
        End Function

        Private Sub breadCrumbEdit1_PathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs) Handles breadCrumbEdit1.PathChanged
            label2.Text = breadCrumbEdit1.Path
        End Sub

        Private Sub breadCrumbEdit1_Properties_PathChanged(ByVal sender As Object, ByVal e As BreadCrumbPathChangedEventArgs) Handles breadCrumbEdit1.Properties.PathChanged

        End Sub
    End Class
End Namespace
