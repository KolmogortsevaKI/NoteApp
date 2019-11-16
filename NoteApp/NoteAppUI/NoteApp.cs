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
	public partial class NoteApp : Form
	{
		private Note Note1 = new Note();
		Project newProject = new Project();

		public NoteApp()
		{
			InitializeComponent();
			/// <summary>
			/// Привязка enum к значениям.
			/// </summary>
			CategoryBox.DataSource = System.Enum.GetValues(typeof(CategoryNote));

			/// <summary>
			/// Выгрузка проекта со списком.
			/// </summary>
			newProject = ProjectManager.LoadFromFile();

			foreach (var note in newProject.Notes)
			{
				NoteBox.Items.Add(note.Title);
			}

		}

		/// <summary>
		/// Получение заметки, которую выбрал пользователь.
		/// </summary>
		private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var selected = (CategoryNote)CategoryBox.SelectedItem;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

			Note newNote1 = new Note();
			AddEdit Add = new AddEdit(newNote1);
			Add.Show();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (NoteBox.SelectedIndex != -1)
			{
				int index = NoteBox.SelectedIndex;
				Note SelectedNote = newProject.Notes[index];
				AddEdit Add = new AddEdit(SelectedNote);
				Add.Show();
			}
		}


	}
}


