﻿namespace NoteAppUI
{
	partial class AddEditForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.CategoryBox = new System.Windows.Forms.ComboBox();
			this.ChangedDateNote = new System.Windows.Forms.DateTimePicker();
			this.CreatedDateNote = new System.Windows.Forms.DateTimePicker();
			this.Cancel = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.Changed = new System.Windows.Forms.Label();
			this.AddTitleBox = new System.Windows.Forms.TextBox();
			this.TextBox = new System.Windows.Forms.TextBox();
			this.Created = new System.Windows.Forms.Label();
			this.Category = new System.Windows.Forms.Label();
			this.Title = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.CategoryBox);
			this.panel1.Controls.Add(this.ChangedDateNote);
			this.panel1.Controls.Add(this.CreatedDateNote);
			this.panel1.Controls.Add(this.Cancel);
			this.panel1.Controls.Add(this.OK);
			this.panel1.Controls.Add(this.Changed);
			this.panel1.Controls.Add(this.AddTitleBox);
			this.panel1.Controls.Add(this.TextBox);
			this.panel1.Controls.Add(this.Created);
			this.panel1.Controls.Add(this.Category);
			this.panel1.Controls.Add(this.Title);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(614, 411);
			this.panel1.TabIndex = 0;
			// 
			// CategoryBox
			// 
			this.CategoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.CategoryBox.Location = new System.Drawing.Point(71, 27);
			this.CategoryBox.Name = "CategoryBox";
			this.CategoryBox.Size = new System.Drawing.Size(121, 21);
			this.CategoryBox.TabIndex = 2;
			// 
			// ChangedDateNote
			// 
			this.ChangedDateNote.Enabled = false;
			this.ChangedDateNote.Location = new System.Drawing.Point(293, 53);
			this.ChangedDateNote.Name = "ChangedDateNote";
			this.ChangedDateNote.Size = new System.Drawing.Size(121, 20);
			this.ChangedDateNote.TabIndex = 23;
			// 
			// CreatedDateNote
			// 
			this.CreatedDateNote.Enabled = false;
			this.CreatedDateNote.Location = new System.Drawing.Point(71, 54);
			this.CreatedDateNote.Name = "CreatedDateNote";
			this.CreatedDateNote.Size = new System.Drawing.Size(121, 20);
			this.CreatedDateNote.TabIndex = 22;
			// 
			// Cancel
			// 
			this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.Cancel.Location = new System.Drawing.Point(536, 379);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
			// 
			// OK
			// 
			this.OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.OK.Location = new System.Drawing.Point(455, 379);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 4;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			this.OK.Click += new System.EventHandler(this.OK_Click);
			// 
			// Changed
			// 
			this.Changed.AutoSize = true;
			this.Changed.Location = new System.Drawing.Point(237, 57);
			this.Changed.Name = "Changed";
			this.Changed.Size = new System.Drawing.Size(53, 13);
			this.Changed.TabIndex = 18;
			this.Changed.Text = "Changed:";
			// 
			// AddTitleBox
			// 
			this.AddTitleBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddTitleBox.Location = new System.Drawing.Point(71, 3);
			this.AddTitleBox.Name = "AddTitleBox";
			this.AddTitleBox.Size = new System.Drawing.Size(540, 20);
			this.AddTitleBox.TabIndex = 1;
			this.AddTitleBox.TextChanged += new System.EventHandler(this.AddTitleBox_TextChanged);
			// 
			// TextBox
			// 
			this.TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TextBox.Location = new System.Drawing.Point(3, 83);
			this.TextBox.Multiline = true;
			this.TextBox.Name = "TextBox";
			this.TextBox.Size = new System.Drawing.Size(608, 290);
			this.TextBox.TabIndex = 3;
			// 
			// Created
			// 
			this.Created.AutoSize = true;
			this.Created.Location = new System.Drawing.Point(16, 58);
			this.Created.Name = "Created";
			this.Created.Size = new System.Drawing.Size(47, 13);
			this.Created.TabIndex = 13;
			this.Created.Text = "Created:";
			// 
			// Category
			// 
			this.Category.AutoSize = true;
			this.Category.Location = new System.Drawing.Point(16, 30);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(52, 13);
			this.Category.TabIndex = 12;
			this.Category.Text = "Category:";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(16, 6);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(30, 13);
			this.Title.TabIndex = 11;
			this.Title.Text = "Title:";
			// 
			// AddEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 428);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "AddEditForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Add/Edit Note";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.TextBox AddTitleBox;
		private System.Windows.Forms.TextBox TextBox;
		private System.Windows.Forms.Label Category;
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.ComboBox CategoryBox;
		private System.Windows.Forms.DateTimePicker ChangedDateNote;
		private System.Windows.Forms.DateTimePicker CreatedDateNote;
		private System.Windows.Forms.Label Changed;
		private System.Windows.Forms.Label Created;
	}
}