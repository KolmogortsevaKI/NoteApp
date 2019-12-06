namespace NoteAppUI
{
	partial class NoteApp
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteApp));
			this.Panel2 = new System.Windows.Forms.Panel();
			this.ChangedDate = new System.Windows.Forms.DateTimePicker();
			this.CreateDate = new System.Windows.Forms.DateTimePicker();
			this.CurrentCategoryNote = new System.Windows.Forms.Label();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.TitleBox = new System.Windows.Forms.TextBox();
			this.CategoryLabel = new System.Windows.Forms.Label();
			this.CreatedLabel = new System.Windows.Forms.Label();
			this.ChangedLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.CategoryBox = new System.Windows.Forms.ComboBox();
			this.ShowLabel = new System.Windows.Forms.Label();
			this.NoteBox = new System.Windows.Forms.ListBox();
			this.AddPicture = new System.Windows.Forms.PictureBox();
			this.DeletePicture = new System.Windows.Forms.PictureBox();
			this.EditPicture = new System.Windows.Forms.PictureBox();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.removeNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.Panel2.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddPicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePicture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPicture)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel2
			// 
			this.Panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel2.Controls.Add(this.ChangedDate);
			this.Panel2.Controls.Add(this.CreateDate);
			this.Panel2.Controls.Add(this.CurrentCategoryNote);
			this.Panel2.Controls.Add(this.TextBox);
			this.Panel2.Controls.Add(this.TitleBox);
			this.Panel2.Controls.Add(this.CategoryLabel);
			this.Panel2.Controls.Add(this.CreatedLabel);
			this.Panel2.Controls.Add(this.ChangedLabel);
			this.Panel2.Location = new System.Drawing.Point(256, 3);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(466, 408);
			this.Panel2.TabIndex = 1;
			// 
			// ChangedDate
			// 
			this.ChangedDate.Enabled = false;
			this.ChangedDate.Location = new System.Drawing.Point(287, 55);
			this.ChangedDate.Name = "ChangedDate";
			this.ChangedDate.Size = new System.Drawing.Size(127, 20);
			this.ChangedDate.TabIndex = 21;
			// 
			// CreateDate
			// 
			this.CreateDate.Enabled = false;
			this.CreateDate.Location = new System.Drawing.Point(73, 55);
			this.CreateDate.Name = "CreateDate";
			this.CreateDate.Size = new System.Drawing.Size(127, 20);
			this.CreateDate.TabIndex = 20;
			// 
			// CurrentCategoryNote
			// 
			this.CurrentCategoryNote.AutoSize = true;
			this.CurrentCategoryNote.Location = new System.Drawing.Point(70, 39);
			this.CurrentCategoryNote.Name = "CurrentCategoryNote";
			this.CurrentCategoryNote.Size = new System.Drawing.Size(86, 13);
			this.CurrentCategoryNote.TabIndex = 19;
			this.CurrentCategoryNote.Text = "Current Category";
			// 
			// TextBox
			// 
			this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox.Location = new System.Drawing.Point(4, 81);
			this.TextBox.Multiline = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(459, 324);
			this.TextBox.TabIndex = 16;
			// 
			// TitleBox
			// 
			this.TitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TitleBox.Enabled = false;
			this.TitleBox.Location = new System.Drawing.Point(16, 12);
			this.TitleBox.Name = "TitleBox";
			this.TitleBox.Size = new System.Drawing.Size(418, 20);
			this.TitleBox.TabIndex = 18;
			// 
			// CategoryLabel
			// 
			this.CategoryLabel.AutoSize = true;
			this.CategoryLabel.Location = new System.Drawing.Point(13, 39);
			this.CategoryLabel.Name = "CategoryLabel";
			this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
			this.CategoryLabel.TabIndex = 7;
			this.CategoryLabel.Text = "Category:";
			// 
			// CreatedLabel
			// 
			this.CreatedLabel.AutoSize = true;
			this.CreatedLabel.Location = new System.Drawing.Point(13, 58);
			this.CreatedLabel.Name = "CreatedLabel";
			this.CreatedLabel.Size = new System.Drawing.Size(44, 13);
			this.CreatedLabel.TabIndex = 9;
			this.CreatedLabel.Text = "Created";
			// 
			// ChangedLabel
			// 
			this.ChangedLabel.AutoSize = true;
			this.ChangedLabel.Location = new System.Drawing.Point(231, 58);
			this.ChangedLabel.Name = "ChangedLabel";
			this.ChangedLabel.Size = new System.Drawing.Size(50, 13);
			this.ChangedLabel.TabIndex = 10;
			this.ChangedLabel.Text = "Changed";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
			this.tableLayoutPanel1.Controls.Add(this.Panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Panel1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 34);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(725, 414);
			this.tableLayoutPanel1.TabIndex = 21;
			// 
			// Panel1
			// 
			this.Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel1.Controls.Add(this.CategoryBox);
			this.Panel1.Controls.Add(this.ShowLabel);
			this.Panel1.Controls.Add(this.NoteBox);
			this.Panel1.Controls.Add(this.AddPicture);
			this.Panel1.Controls.Add(this.DeletePicture);
			this.Panel1.Controls.Add(this.EditPicture);
			this.Panel1.Location = new System.Drawing.Point(3, 3);
			this.Panel1.MinimumSize = new System.Drawing.Size(241, 408);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(247, 408);
			this.Panel1.TabIndex = 0;
			// 
			// CategoryBox
			// 
			this.CategoryBox.FormattingEnabled = true;
			this.CategoryBox.Items.AddRange(new object[] {
            "All",
            "Job",
            "Home",
            "Health",
            "People",
            "Documents",
            "Finance",
            "Different"});
			this.CategoryBox.Location = new System.Drawing.Point(99, 12);
			this.CategoryBox.Name = "CategoryBox";
			this.CategoryBox.Size = new System.Drawing.Size(130, 21);
			this.CategoryBox.TabIndex = 16;
			this.CategoryBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBox_SelectedIndexChanged);
			// 
			// ShowLabel
			// 
			this.ShowLabel.AutoSize = true;
			this.ShowLabel.Location = new System.Drawing.Point(1, 15);
			this.ShowLabel.Name = "ShowLabel";
			this.ShowLabel.Size = new System.Drawing.Size(79, 13);
			this.ShowLabel.TabIndex = 3;
			this.ShowLabel.Text = "Show Category";
			// 
			// NoteBox
			// 
			this.NoteBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NoteBox.FormattingEnabled = true;
			this.NoteBox.Location = new System.Drawing.Point(4, 39);
			this.NoteBox.Name = "NoteBox";
			this.NoteBox.Size = new System.Drawing.Size(239, 329);
			this.NoteBox.TabIndex = 6;
			this.NoteBox.SelectedIndexChanged += new System.EventHandler(this.NoteBox_SelectedIndexChanged);
			// 
			// AddPicture
			// 
			this.AddPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.AddPicture.Image = ((System.Drawing.Image)(resources.GetObject("AddPicture.Image")));
			this.AddPicture.Location = new System.Drawing.Point(18, 378);
			this.AddPicture.Name = "AddPicture";
			this.AddPicture.Size = new System.Drawing.Size(26, 27);
			this.AddPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.AddPicture.TabIndex = 13;
			this.AddPicture.TabStop = false;
			this.AddPicture.Click += new System.EventHandler(this.AddBox_Click);
			// 
			// DeletePicture
			// 
			this.DeletePicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.DeletePicture.Image = ((System.Drawing.Image)(resources.GetObject("DeletePicture.Image")));
			this.DeletePicture.Location = new System.Drawing.Point(99, 378);
			this.DeletePicture.Name = "DeletePicture";
			this.DeletePicture.Size = new System.Drawing.Size(26, 27);
			this.DeletePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.DeletePicture.TabIndex = 15;
			this.DeletePicture.TabStop = false;
			this.DeletePicture.Click += new System.EventHandler(this.DeletePicture_Click);
			// 
			// EditPicture
			// 
			this.EditPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.EditPicture.Image = ((System.Drawing.Image)(resources.GetObject("EditPicture.Image")));
			this.EditPicture.Location = new System.Drawing.Point(58, 378);
			this.EditPicture.Name = "EditPicture";
			this.EditPicture.Size = new System.Drawing.Size(26, 27);
			this.EditPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.EditPicture.TabIndex = 14;
			this.EditPicture.TabStop = false;
			this.EditPicture.Click += new System.EventHandler(this.EditBox_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// removeNoteToolStripMenuItem
			// 
			this.removeNoteToolStripMenuItem.Name = "removeNoteToolStripMenuItem";
			this.removeNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.removeNoteToolStripMenuItem.Text = "Remove Note";
			this.removeNoteToolStripMenuItem.Click += new System.EventHandler(this.removeNoteToolStripMenuItem_Click);
			// 
			// editNoteToolStripMenuItem
			// 
			this.editNoteToolStripMenuItem.Name = "editNoteToolStripMenuItem";
			this.editNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.editNoteToolStripMenuItem.Text = "Edit Note";
			this.editNoteToolStripMenuItem.Click += new System.EventHandler(this.editNoteToolStripMenuItem_Click);
			// 
			// addNoteToolStripMenuItem
			// 
			this.addNoteToolStripMenuItem.Name = "addNoteToolStripMenuItem";
			this.addNoteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.addNoteToolStripMenuItem.Text = "Add Note";
			this.addNoteToolStripMenuItem.Click += new System.EventHandler(this.addNoteToolStripMenuItem_Click);
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNoteToolStripMenuItem,
            this.editNoteToolStripMenuItem,
            this.removeNoteToolStripMenuItem});
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(719, 24);
			this.menuStrip1.TabIndex = 20;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// NoteApp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 460);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(735, 498);
			this.Name = "NoteApp";
			this.Text = "NoteApp";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NoteApp_FormClosing);
			this.Load += new System.EventHandler(this.NoteApp_Load);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.AddPicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeletePicture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.EditPicture)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel Panel2;
		private System.Windows.Forms.TextBox TextBox;
		private System.Windows.Forms.TextBox TitleBox;
		private System.Windows.Forms.Label CategoryLabel;
		private System.Windows.Forms.Label CreatedLabel;
		private System.Windows.Forms.Label ChangedLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel Panel1;
		private System.Windows.Forms.Label ShowLabel;
		private System.Windows.Forms.ListBox NoteBox;
		private System.Windows.Forms.PictureBox AddPicture;
		private System.Windows.Forms.PictureBox DeletePicture;
		private System.Windows.Forms.PictureBox EditPicture;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem removeNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addNoteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ComboBox CategoryBox;
		private System.Windows.Forms.Label CurrentCategoryNote;
		private System.Windows.Forms.DateTimePicker ChangedDate;
		private System.Windows.Forms.DateTimePicker CreateDate;
	}
}

