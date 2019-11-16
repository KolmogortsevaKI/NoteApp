﻿namespace NoteAppUI
{
	partial class AddEdit
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.Cancel = new System.Windows.Forms.Button();
			this.OK = new System.Windows.Forms.Button();
			this.ChangedBox = new System.Windows.Forms.TextBox();
			this.Changed = new System.Windows.Forms.Label();
			this.CategoryBox = new System.Windows.Forms.ListBox();
			this.AddTitleBox = new System.Windows.Forms.TextBox();
			this.CreatedBox = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Created = new System.Windows.Forms.Label();
			this.Category = new System.Windows.Forms.Label();
			this.Title = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.Cancel);
			this.panel1.Controls.Add(this.OK);
			this.panel1.Controls.Add(this.ChangedBox);
			this.panel1.Controls.Add(this.Changed);
			this.panel1.Controls.Add(this.CategoryBox);
			this.panel1.Controls.Add(this.AddTitleBox);
			this.panel1.Controls.Add(this.CreatedBox);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.Created);
			this.panel1.Controls.Add(this.Category);
			this.panel1.Controls.Add(this.Title);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(614, 411);
			this.panel1.TabIndex = 0;
			// 
			// Cancel
			// 
			this.Cancel.Location = new System.Drawing.Point(514, 379);
			this.Cancel.Name = "Cancel";
			this.Cancel.Size = new System.Drawing.Size(75, 23);
			this.Cancel.TabIndex = 21;
			this.Cancel.Text = "Cancel";
			this.Cancel.UseVisualStyleBackColor = true;
			// 
			// OK
			// 
			this.OK.Location = new System.Drawing.Point(424, 379);
			this.OK.Name = "OK";
			this.OK.Size = new System.Drawing.Size(75, 23);
			this.OK.TabIndex = 20;
			this.OK.Text = "OK";
			this.OK.UseVisualStyleBackColor = true;
			// 
			// ChangedBox
			// 
			this.ChangedBox.Location = new System.Drawing.Point(254, 72);
			this.ChangedBox.Name = "ChangedBox";
			this.ChangedBox.Size = new System.Drawing.Size(100, 20);
			this.ChangedBox.TabIndex = 19;
			// 
			// Changed
			// 
			this.Changed.AutoSize = true;
			this.Changed.Location = new System.Drawing.Point(204, 75);
			this.Changed.Name = "Changed";
			this.Changed.Size = new System.Drawing.Size(50, 13);
			this.Changed.TabIndex = 18;
			this.Changed.Text = "Changed";
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
			this.CategoryBox.Location = new System.Drawing.Point(77, 44);
			this.CategoryBox.Name = "CategoryBox";
			this.CategoryBox.Size = new System.Drawing.Size(100, 43);
			this.CategoryBox.TabIndex = 17;
			// 
			// AddTitleBox
			// 
			this.AddTitleBox.Location = new System.Drawing.Point(77, 20);
			this.AddTitleBox.Name = "AddTitleBox";
			this.AddTitleBox.Size = new System.Drawing.Size(512, 20);
			this.AddTitleBox.TabIndex = 16;
			// 
			// CreatedBox
			// 
			this.CreatedBox.Location = new System.Drawing.Point(254, 44);
			this.CreatedBox.Name = "CreatedBox";
			this.CreatedBox.Size = new System.Drawing.Size(100, 20);
			this.CreatedBox.TabIndex = 15;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(25, 97);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(564, 276);
			this.textBox1.TabIndex = 14;
			// 
			// Created
			// 
			this.Created.AutoSize = true;
			this.Created.Location = new System.Drawing.Point(204, 47);
			this.Created.Name = "Created";
			this.Created.Size = new System.Drawing.Size(44, 13);
			this.Created.TabIndex = 13;
			this.Created.Text = "Created";
			// 
			// Category
			// 
			this.Category.AutoSize = true;
			this.Category.Location = new System.Drawing.Point(16, 45);
			this.Category.Name = "Category";
			this.Category.Size = new System.Drawing.Size(49, 13);
			this.Category.TabIndex = 12;
			this.Category.Text = "Category";
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Location = new System.Drawing.Point(16, 23);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(27, 13);
			this.Title.TabIndex = 11;
			this.Title.Text = "Title";
			// 
			// AddEdit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 428);
			this.Controls.Add(this.panel1);
			this.Name = "AddEdit";
			this.Text = "`";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button Cancel;
		private System.Windows.Forms.Button OK;
		private System.Windows.Forms.TextBox ChangedBox;
		private System.Windows.Forms.Label Changed;
		private System.Windows.Forms.ListBox CategoryBox;
		private System.Windows.Forms.TextBox AddTitleBox;
		private System.Windows.Forms.TextBox CreatedBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label Created;
		private System.Windows.Forms.Label Category;
		private System.Windows.Forms.Label Title;
	}
}