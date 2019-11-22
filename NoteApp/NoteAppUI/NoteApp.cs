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

	/// <summary>
	/// Главная форма .
	/// </summary>
	public partial class NoteApp : Form
	{
		Project newProject = new Project();

		/// <summary>
		/// Конструктор.
		/// </summary>
		public NoteApp()
		{
			InitializeComponent();
			/// <summary>
			/// Привязка enum к значениям.
			/// </summary>
			CategoryBox.DataSource = System.Enum.GetValues(typeof(CategoryNote));

		}

		private List<Note> currentNotes;
		/// <summary>
		/// Получение заметок, по выбранной категории.
		/// </summary>
		private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
		{

			var selected = (CategoryNote)CategoryBox.SelectedItem;
			List<Note> findCategory = new List<Note>();
			if (selected != CategoryNote.All)
			{
				foreach (var note in newProject.Notes)
				{
					if (note.Category == selected)
					{
						findCategory.Add(note);
					}
				}
			  UpdateNoteBox(findCategory);
			}
			else
			{
				UpdateNoteBox(newProject.Notes);	
			}

		}

		/// <summary>
		/// Добавление новой заметки.
		/// </summary>

		private void AddBox_Click(object sender, EventArgs e)
		{

			AddEdit noteForm = new AddEdit();
			DialogResult result = noteForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				Note newNote = noteForm.CurrentNote;
				newProject.Notes.Add(newNote);
				UpdateNoteBox(newProject.Notes);
			}
		}
		/// <summary>
		/// Изменение текущей заметки.
		/// </summary>
		private void EditBox_Click(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				Note selectedNote = newProject.Notes[index];
				AddEdit noteForm = new AddEdit();
				noteForm.CurrentNote = selectedNote;
				DialogResult result = noteForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					Note newNote = noteForm.CurrentNote;
					newProject.Notes.RemoveAt(index);
					newProject.Notes.Insert(index, newNote);
					UpdateNoteBox(newProject.Notes);
				}
			}
		}

		/// <summary>
		///Выход.
		/// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}
		/// <summary>
		/// Сохранение перед закрытием приложения.
		/// </summary>
		private void NoteApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectManager.SaveToFile(newProject);
		}

		/// <summary>	
		/// Выгрузка проекта со списком.		
		/// </summary>
		private void NoteApp_Load(object sender, EventArgs e)
		{
			newProject = ProjectManager.LoadFromFile();
			UpdateNoteBox(newProject.Notes);
		}

		/// <summary>
		/// Обновление списка.
		/// </summary>
		private void UpdateNoteBox(List<Note> notes)
		{
			NoteBox.Items.Clear();
			foreach (var note in notes)
			{
				NoteBox.Items.Add(note.Title);
			}
		}


		/// <summary>
		/// Отображение, выборанной заметки.
		/// </summary>
		/// 
		
		private void NoteBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				TitleBox.Text = newProject.Notes[index].Title;
				CurrentCategoryNote.Text = newProject.Notes[index].Category.ToString();
				CreateDate.Value = newProject.Notes[index].DateCreate;
				ChangedDate.Value = newProject.Notes[index].DateChange;
				TextBox.Text = newProject.Notes[index].Text;
			}
		}
		/// <summary>
		///Удаление заметки.
		/// </summary>
		private void DeletePicture_Click(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >=0)
			{
				DialogResult result  = MessageBox.Show("Do you really want to remove this note: " + NoteBox.Items[index].ToString() + "?",
					"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					NoteBox.Items.RemoveAt(index);
					newProject.Notes.RemoveAt(index);
				}
			}
		}

		/// <summary>
		///Добавление заметки через меню.
		/// </summary>
		private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddEdit noteForm = new AddEdit();
			DialogResult result = noteForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				Note newNote = noteForm.CurrentNote;
				newProject.Notes.Add(newNote);
				UpdateNoteBox(newProject.Notes);
			}

		}

		/// <summary>
		///Редактирование заметки через меню.
		/// </summary>
		private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				Note selectedNote = newProject.Notes[index];
				AddEdit noteForm = new AddEdit();
				noteForm.CurrentNote = selectedNote;
				DialogResult result = noteForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					Note newNote = noteForm.CurrentNote;
					newProject.Notes.RemoveAt(index);
					newProject.Notes.Insert(index, newNote);
					UpdateNoteBox(newProject.Notes);
				}
			}
		}

		/// <summary>
		///Удаление заметки через меню.
		/// </summary>
		private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				DialogResult result = MessageBox.Show("Do you really want to remove this note: " + NoteBox.Items[index].ToString() + "?",
					"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					NoteBox.Items.RemoveAt(index);
					newProject.Notes.RemoveAt(index);
				}
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About noteForm = new About();
			DialogResult result = noteForm.ShowDialog();
		}
	}



}


