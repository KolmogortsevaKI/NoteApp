using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	public partial class AddEdit : Form
	{
		/// <summary>
		/// Заполнение полей.
		/// </summary>
		/// <param name="newNote1"></param>
		public AddEdit(Note newNote1)
		{
			InitializeComponent();
			AddTitleBox.Text = newNote1.Title;
			CreatedBox.Text = newNote1.DateCreate.ToString();
			ChangedBox.Text = newNote1.DateChange.ToString();
			var values = System.Enum.GetValues(typeof(CategoryNote));
			var categoryIndex = 0;
			for (int i = 0; i < values.Length; i++)
			{
				if ((CategoryNote)values.GetValue(i) == newNote1.Category)
				{
					categoryIndex = i;
					break;
				}
			}
			CategoryBox.DataSource = values;
			CategoryBox.SelectedIndex = categoryIndex;
		}

		private void OK_Click(object sender, EventArgs e)
		{
			//Project newProject = new Project();
			//ProjectManager.SaveToFile(newProject);
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
