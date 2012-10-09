namespace V1Attachments
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.btnOk = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.menuMain = new System.Windows.Forms.ToolStrip();
			this.btnRecentItems = new System.Windows.Forms.ToolStripDropDownButton();
			this.btnConfig = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSearch = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.lblSelectedItem = new System.Windows.Forms.ToolStripLabel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtMessage = new System.Windows.Forms.TextBox();
			this.menuMessages = new System.Windows.Forms.ToolStrip();
			this.btnRecentMessages = new System.Windows.Forms.ToolStripDropDownButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.txtTitle = new System.Windows.Forms.ToolStripTextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.txtFilename = new System.Windows.Forms.TextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.iconList = new System.Windows.Forms.ImageList(this.components);
			this.btnOkNew = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.menuMain.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.menuMessages.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOk
			// 
			this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOk.Location = new System.Drawing.Point(217, 244);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(75, 23);
			this.btnOk.TabIndex = 4;
			this.btnOk.Text = "OK";
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(379, 244);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// menuMain
			// 
			this.menuMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecentItems,
            this.btnConfig,
            this.toolStripSeparator1,
            this.btnSearch,
            this.toolStripSeparator2,
            this.lblSelectedItem});
			this.menuMain.Location = new System.Drawing.Point(0, 0);
			this.menuMain.Name = "menuMain";
			this.menuMain.Padding = new System.Windows.Forms.Padding(0, 0, 1, 1);
			this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuMain.Size = new System.Drawing.Size(472, 25);
			this.menuMain.TabIndex = 3;
			this.menuMain.Text = "toolStrip1";
			// 
			// btnRecentItems
			// 
			this.btnRecentItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRecentItems.Image = ((System.Drawing.Image)(resources.GetObject("btnRecentItems.Image")));
			this.btnRecentItems.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRecentItems.Name = "btnRecentItems";
			this.btnRecentItems.Size = new System.Drawing.Size(84, 21);
			this.btnRecentItems.Text = "Recent Items";
			// 
			// btnConfig
			// 
			this.btnConfig.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnConfig.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
			this.btnConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnConfig.Name = "btnConfig";
			this.btnConfig.Size = new System.Drawing.Size(23, 21);
			this.btnConfig.Text = "Configuration";
			this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 24);
			// 
			// btnSearch
			// 
			this.btnSearch.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
			this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(23, 21);
			this.btnSearch.Text = "Search";
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 24);
			// 
			// lblSelectedItem
			// 
			this.lblSelectedItem.Image = ((System.Drawing.Image)(resources.GetObject("lblSelectedItem.Image")));
			this.lblSelectedItem.IsLink = true;
			this.lblSelectedItem.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.lblSelectedItem.LinkColor = System.Drawing.Color.Black;
			this.lblSelectedItem.Name = "lblSelectedItem";
			this.lblSelectedItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
			this.lblSelectedItem.Size = new System.Drawing.Size(94, 21);
			this.lblSelectedItem.Text = "toolStripLabel1";
			this.lblSelectedItem.Visible = false;
			this.lblSelectedItem.Click += new System.EventHandler(this.lblSelectedItem_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.txtMessage);
			this.groupBox2.Controls.Add(this.menuMessages);
			this.groupBox2.Location = new System.Drawing.Point(12, 82);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(448, 156);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Attachment Details";
			// 
			// txtMessage
			// 
			this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtMessage.Location = new System.Drawing.Point(6, 44);
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.Size = new System.Drawing.Size(436, 106);
			this.txtMessage.TabIndex = 3;
			this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
			// 
			// menuMessages
			// 
			this.menuMessages.GripMargin = new System.Windows.Forms.Padding(0);
			this.menuMessages.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.menuMessages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRecentMessages,
            this.toolStripLabel1,
            this.txtTitle});
			this.menuMessages.Location = new System.Drawing.Point(3, 16);
			this.menuMessages.Name = "menuMessages";
			this.menuMessages.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this.menuMessages.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuMessages.Size = new System.Drawing.Size(442, 25);
			this.menuMessages.TabIndex = 1;
			this.menuMessages.Text = "toolStrip1";
			// 
			// btnRecentMessages
			// 
			this.btnRecentMessages.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnRecentMessages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRecentMessages.Image = ((System.Drawing.Image)(resources.GetObject("btnRecentMessages.Image")));
			this.btnRecentMessages.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnRecentMessages.Name = "btnRecentMessages";
			this.btnRecentMessages.Size = new System.Drawing.Size(115, 21);
			this.btnRecentMessages.Text = "Recent Descriptions";
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(31, 21);
			this.toolStripLabel1.Text = "Title:";
			// 
			// txtTitle
			// 
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(150, 24);
			this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.btnBrowse);
			this.groupBox1.Controls.Add(this.txtFilename);
			this.groupBox1.Location = new System.Drawing.Point(12, 28);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(448, 48);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "File";
			// 
			// btnBrowse
			// 
			this.btnBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBrowse.Location = new System.Drawing.Point(367, 15);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 2;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// txtFilename
			// 
			this.txtFilename.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.txtFilename.Location = new System.Drawing.Point(6, 17);
			this.txtFilename.Name = "txtFilename";
			this.txtFilename.Size = new System.Drawing.Size(355, 20);
			this.txtFilename.TabIndex = 1;
			this.txtFilename.TextChanged += new System.EventHandler(this.txtFilename_TextChanged);
			// 
			// iconList
			// 
			this.iconList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconList.ImageStream")));
			this.iconList.TransparentColor = System.Drawing.Color.Transparent;
			this.iconList.Images.SetKeyName(0, "Theme");
			this.iconList.Images.SetKeyName(1, "Changeset");
			this.iconList.Images.SetKeyName(2, "Defect");
			this.iconList.Images.SetKeyName(3, "DefectTemplate");
			this.iconList.Images.SetKeyName(4, "Epic");
			this.iconList.Images.SetKeyName(5, "Goal");
			this.iconList.Images.SetKeyName(6, "Issue");
			this.iconList.Images.SetKeyName(7, "Iteration");
			this.iconList.Images.SetKeyName(8, "Member");
			this.iconList.Images.SetKeyName(9, "Note");
			this.iconList.Images.SetKeyName(10, "Project");
			this.iconList.Images.SetKeyName(11, "Request");
			this.iconList.Images.SetKeyName(12, "Retrospective");
			this.iconList.Images.SetKeyName(13, "Story");
			this.iconList.Images.SetKeyName(14, "StoryTemplate");
			this.iconList.Images.SetKeyName(15, "Task");
			this.iconList.Images.SetKeyName(16, "Team");
			this.iconList.Images.SetKeyName(17, "Test");
			// 
			// btnOkNew
			// 
			this.btnOkNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOkNew.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOkNew.Location = new System.Drawing.Point(298, 244);
			this.btnOkNew.Name = "btnOkNew";
			this.btnOkNew.Size = new System.Drawing.Size(75, 23);
			this.btnOkNew.TabIndex = 5;
			this.btnOkNew.Text = "OK && New";
			this.btnOkNew.UseVisualStyleBackColor = true;
			this.btnOkNew.Click += new System.EventHandler(this.btnOKNew_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 270);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(472, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(472, 292);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnOkNew);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.menuMain);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "MainForm";
			this.Text = "Send To VersionOne";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.menuMain.ResumeLayout(false);
			this.menuMain.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.menuMessages.ResumeLayout(false);
			this.menuMessages.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.ToolStrip menuMain;
		private System.Windows.Forms.ToolStripDropDownButton btnRecentItems;
		private System.Windows.Forms.ToolStripButton btnSearch;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox txtFilename;
		private System.Windows.Forms.ToolStrip menuMessages;
		private System.Windows.Forms.ToolStripDropDownButton btnRecentMessages;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.ToolStripButton btnConfig;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TextBox txtMessage;
		private System.Windows.Forms.ToolStripLabel lblSelectedItem;
		private System.Windows.Forms.ImageList iconList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripTextBox txtTitle;
		private System.Windows.Forms.Button btnOkNew;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}

