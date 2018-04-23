Imports Microsoft.VisualBasic
Imports System
Namespace FileNavigator
	Public Partial Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (Not components Is Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim breadCrumbNode1 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
			Dim breadCrumbNode2 As DevExpress.XtraEditors.BreadCrumbNode = New DevExpress.XtraEditors.BreadCrumbNode()
			Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.breadCrumbEdit1 = New DevExpress.XtraEditors.BreadCrumbEdit()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.sharedImageCollection1 = New DevExpress.Utils.SharedImageCollection(Me.components)
			CType(Me.breadCrumbEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sharedImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.sharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' breadCrumbEdit1
			' 
			Me.breadCrumbEdit1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.breadCrumbEdit1.Location = New System.Drawing.Point(12, 11)
			Me.breadCrumbEdit1.Name = "breadCrumbEdit1"
			Me.breadCrumbEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.breadCrumbEdit1.Properties.ImageIndex = 1
			Me.breadCrumbEdit1.Properties.Images = Me.sharedImageCollection1
			breadCrumbNode1.Caption = "Root"
			breadCrumbNode1.Persistent = True
			breadCrumbNode1.PopulateOnDemand = True
			breadCrumbNode1.ShowCaption = False
			breadCrumbNode1.Value = "Root"
			breadCrumbNode2.Caption = "Computer"
			breadCrumbNode2.Persistent = True
			breadCrumbNode2.PopulateOnDemand = True
			breadCrumbNode2.Value = "Computer"
			Me.breadCrumbEdit1.Properties.Nodes.AddRange(New DevExpress.XtraEditors.BreadCrumbNode() { breadCrumbNode1, breadCrumbNode2})
			Me.breadCrumbEdit1.Properties.RootImageIndex = 1
			Me.breadCrumbEdit1.Properties.SelectedNode = breadCrumbNode2
'			Me.breadCrumbEdit1.Properties.PathChanged += New DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(Me.breadCrumbEdit1_Properties_PathChanged);
'			Me.breadCrumbEdit1.Properties.QueryChildNodes += New DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(Me.breadCrumbEdit1_Properties_QueryChildNodes);
'			Me.breadCrumbEdit1.Properties.ValidatePath += New DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(Me.breadCrumbEdit1_Properties_ValidatePath);
'			Me.breadCrumbEdit1.Properties.NewNodeAdding += New DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(Me.breadCrumbEdit1_Properties_NewNodeAdding);
			Me.breadCrumbEdit1.Size = New System.Drawing.Size(508, 22)
			Me.breadCrumbEdit1.TabIndex = 0
'			Me.breadCrumbEdit1.PathChanged += New DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(Me.breadCrumbEdit1_PathChanged);
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(9, 46)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(73, 13)
			Me.label1.TabIndex = 1
			Me.label1.Text = "Current path:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(88, 46)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(54, 13)
			Me.label2.TabIndex = 2
			Me.label2.Text = "Path Text"
			' 
			' sharedImageCollection1
			' 
			' 
			' 
			' 
			Me.sharedImageCollection1.ImageSource.ImageStream = (CType(resources.GetObject("sharedImageCollection1.ImageSource.ImageStream"), DevExpress.Utils.ImageCollectionStreamer))
			Me.sharedImageCollection1.ImageSource.Images.SetKeyName(0, "loadfrom_16x16.png")
			Me.sharedImageCollection1.ImageSource.Images.SetKeyName(1, "open_16x16.png")
			Me.sharedImageCollection1.ParentControl = Me
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(532, 108)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.breadCrumbEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.breadCrumbEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sharedImageCollection1.ImageSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.sharedImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents breadCrumbEdit1 As DevExpress.XtraEditors.BreadCrumbEdit
		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private sharedImageCollection1 As DevExpress.Utils.SharedImageCollection
	End Class
End Namespace

