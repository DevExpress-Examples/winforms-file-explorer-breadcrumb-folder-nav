namespace FileNavigator {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode1 = new DevExpress.XtraEditors.BreadCrumbNode();
            DevExpress.XtraEditors.BreadCrumbNode breadCrumbNode2 = new DevExpress.XtraEditors.BreadCrumbNode();
            this.breadCrumbEdit1 = new DevExpress.XtraEditors.BreadCrumbEdit();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // breadCrumbEdit1
            // 
            this.breadCrumbEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.breadCrumbEdit1.Location = new System.Drawing.Point(24, 21);
            this.breadCrumbEdit1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.breadCrumbEdit1.Name = "breadCrumbEdit1";
            this.breadCrumbEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.breadCrumbEdit1.Properties.ImageIndex = 1;
            this.breadCrumbEdit1.Properties.Images = this.svgImageCollection1;
            breadCrumbNode1.Caption = "Root";
            breadCrumbNode1.Persistent = true;
            breadCrumbNode1.PopulateOnDemand = true;
            breadCrumbNode1.ShowCaption = false;
            breadCrumbNode1.Value = "Root";
            breadCrumbNode2.Caption = "Computer";
            breadCrumbNode2.Persistent = true;
            breadCrumbNode2.PopulateOnDemand = true;
            breadCrumbNode2.Value = "Computer";
            this.breadCrumbEdit1.Properties.Nodes.AddRange(new DevExpress.XtraEditors.BreadCrumbNode[] {
            breadCrumbNode1,
            breadCrumbNode2});
            this.breadCrumbEdit1.Properties.RootImageIndex = 1;
            this.breadCrumbEdit1.Properties.PathChanged += new DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(this.breadCrumbEdit1_Properties_PathChanged);
            this.breadCrumbEdit1.Properties.QueryChildNodes += new DevExpress.XtraEditors.BreadCrumbQueryChildNodesEventHandler(this.breadCrumbEdit1_Properties_QueryChildNodes);
            this.breadCrumbEdit1.Properties.ValidatePath += new DevExpress.XtraEditors.BreadCrumbValidatePathEventHandler(this.breadCrumbEdit1_Properties_ValidatePath);
            this.breadCrumbEdit1.Properties.NewNodeAdding += new DevExpress.XtraEditors.BreadCrumbNewNodeAddingEventHandler(this.breadCrumbEdit1_Properties_NewNodeAdding);
            this.breadCrumbEdit1.Size = new System.Drawing.Size(1016, 40);
            this.breadCrumbEdit1.TabIndex = 0;
            this.breadCrumbEdit1.PathChanged += new DevExpress.XtraEditors.BreadCrumbPathChangedEventHandler(this.breadCrumbEdit1_PathChanged);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path Text";
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("imageload", "image://svgimages/dashboards/imageload.svg");
            this.svgImageCollection1.Add("open", "image://svgimages/actions/open.svg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.breadCrumbEdit1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.breadCrumbEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.BreadCrumbEdit breadCrumbEdit1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}

