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
		private List<Note> currentNotes;
		/// <summary>
		/// 
		/// </summary>
		public NoteApp()
		{
			InitializeComponent();
			/// <summary>
			/// Привязка enum к значениям.
			/// </summary>
			CategoryBox.DataSource = System.Enum.GetValues(typeof(CategoryNote));

		}

		/// <summary>
		/// Добавление заметки.
		/// </summary>
		public void AddCommon()
		{
			AddEdit noteForm = new AddEdit();
			DialogResult result = noteForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				Note newNote = noteForm.CurrentNote;
				newProject.Notes.Add(newNote);
				CurrentCategory();
				var index = NoteBox.Items.Count;
				NoteBox.SelectedIndex = index - 1;

			}
		}
		/// <summary>
		/// Добавление новой заметки.
		/// </summary>
		private void AddBox_Click(object sender, EventArgs e)
		{
			AddCommon();
		}
		/// <summary>
		///Добавление заметки через меню.
		/// </summary>
		private void addNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddCommon();
		}
		/// <summary>
		/// Редактирование заметки.
		/// </summary>
		public void EditCommon()
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				var currentIndexNote = newProject.Notes.IndexOf(currentNotes[index]);
				Note selectedNote = newProject.Notes[currentIndexNote];
				AddEdit noteForm = new AddEdit();
				noteForm.CurrentNote = selectedNote;

				DialogResult result = noteForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					Note newNote = noteForm.CurrentNote;
					newProject.Notes.RemoveAt(currentIndexNote);
					newProject.Notes.Insert(currentIndexNote, newNote);
					CurrentCategory();
					if (NoteBox.Items.Count > 0)
					{
						NoteBox.SelectedIndex = 0;
					}
				}
			}
		}
		/// <summary>
		/// Редактирование заметки.
		/// </summary>
		private void EditBox_Click(object sender, EventArgs e)
		{
			EditCommon();
		}
		/// <summary>
		///Редактирование заметки через меню.
		/// </summary>
		private void editNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditCommon();
		}
		/// <summary>
		/// Удаление заметки.
		/// </summary>
		public void DeleteCommon()
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{
				var currentIndexNote = newProject.Notes.IndexOf(currentNotes[index]);
				DialogResult result = MessageBox.Show("Do you really want to remove this note: " + NoteBox.Items[index].ToString() + "?",
					"Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (result == DialogResult.Yes)
				{
					newProject.Notes.RemoveAt(currentIndexNote);
					CurrentCategory();
					if (NoteBox.Items.Count > 0)
					{
						NoteBox.SelectedIndex = 0;
					}
				}
			}
		}
		/// <summary>
		///Удаление заметки.
		/// </summary>
		private void DeletePicture_Click(object sender, EventArgs e)
		{
			DeleteCommon();
		}
		/// <summary>
		///Удаление заметки через меню.
		/// </summary>
		private void removeNoteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DeleteCommon();
		}
		/// <summary>
		/// Получение заметок, по выбранной категории.
		/// </summary>
		private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentCategory();
		}	
		private void CurrentCategory()
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
		/// Сохранение перед закрытием приложения.
		/// </summary>
		private void NoteApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProjectManager.SaveToFile(newProject);
		}
		/// <summary>
		///Выход.
		/// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
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
			currentNotes = notes;
		}
		/// <summary>
		/// Отображение, выборанной заметки.
		/// </summary>
		private void NoteBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{				
				var currentIndexNote = newProject.Notes.IndexOf(currentNotes[index]);
				TitleBox.Text = newProject.Notes[currentIndexNote].Title;
				CurrentCategoryNote.Text = newProject.Notes[currentIndexNote].Category.ToString();
				//CreateDate.Value = newProject.Notes[currentIndexNote].DateCreate;
				ChangedDate.Value = newProject.Notes[currentIndexNote].DateChange;
				TextBox.Text = newProject.Notes[currentIndexNote].Text;
			}
		}
		/// <summary>
		/// Окно about.
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			About noteForm = new About();
			DialogResult result = noteForm.ShowDialog();
		}
	}



}


