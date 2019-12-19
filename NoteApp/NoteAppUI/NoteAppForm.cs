using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{

	/// <summary>
	/// Главная форма .
	/// </summary>
	public partial class NoteAppForm : Form
	{
		Project newProject = new Project();
		private List<Note> currentNotes;
		public NoteAppForm()
		{
			InitializeComponent();			
			CategoryBox.Items.Add("All");
			var listCategory = System.Enum.GetValues(typeof(CategoryNote));
			foreach (var category in listCategory)
			{
				CategoryBox.Items.Add(category);
			}
			CategoryBox.SelectedIndex = 0;			

		}
		/// <summary>
		/// Добавление заметки.
		/// </summary>
		public void AddCommon()
		{
			AddEditForm noteForm = new AddEditForm();
			DialogResult result = noteForm.ShowDialog();
			if (result == DialogResult.OK)
			{
				Note newNote = noteForm.CurrentNote;
				newProject.Notes.Add(newNote);				
				var index = NoteBox.Items.Count;
				newProject.Notes = newProject.SortNotes(newProject.Notes);
				CurrentCategory();
				SaveProject();
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
				AddEditForm noteForm = new AddEditForm();
				noteForm.CurrentNote = selectedNote;

				DialogResult result = noteForm.ShowDialog();
				if (result == DialogResult.OK)
				{
					Note newNote = noteForm.CurrentNote;
					newProject.Notes.RemoveAt(currentIndexNote);
					newProject.Notes.Insert(currentIndexNote, newNote);
					newProject.Notes = newProject.SortNotes(newProject.Notes);
					SaveProject();
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
					newProject.Notes = newProject.SortNotes(newProject.Notes);
					CurrentCategory();
					SaveProject();
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
		/// Получение заметок по выбранной категории.
		/// </summary>
		private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			CurrentCategory();
		}	
		/// <summary>
		/// Поиск категории.
		/// </summary>
		private void CurrentCategory()
		{
						
			if (CategoryBox.SelectedItem.ToString() == "All")
			{
				UpdateNoteBox(newProject.Notes);
			}
			else
			{
				List<Note> findCategory = new List<Note>();
				var selected = (CategoryNote)CategoryBox.SelectedItem;
				foreach (var note in newProject.Notes)
				{
					if (note.Category == selected)
					{
						findCategory.Add(note);
					}
				}
				UpdateNoteBox(findCategory);
			}
						
		}
		/// <summary>
		/// Сохранение перед закрытием приложения.
		/// </summary>
		private void NoteApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveProject();
		}

		private void SaveProject()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ProjectManager.SaveToFile(newProject, path);
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
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			newProject = ProjectManager.LoadFromFile(path);
			UpdateNoteBox(newProject.Notes);
		}
		/// <summary>
		/// Обновление списка.
		/// </summary>
		private void UpdateNoteBox(List<Note> notes)
		{
			NoteBox.Items.Clear();
			currentNotes = notes;
			foreach (var note in notes)
			{
				NoteBox.Items.Add(note.Title);
			}
			
			if (NoteBox.Items.Count > 0)
			{
				NoteBox.SelectedIndex = 0;
			}
			
		}
		/// <summary>
		/// Отображение выбранной заметки.
		/// </summary>
		private void NoteBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			var index = NoteBox.SelectedIndex;
			if (index >= 0)
			{				
				var currentIndexNote = newProject.Notes.IndexOf(currentNotes[index]);
				TitleBox.Text = newProject.Notes[currentIndexNote].Title;
				CurrentCategoryNote.Text = newProject.Notes[currentIndexNote].Category.ToString();
				CreateDate.Value = newProject.Notes[currentIndexNote].DateCreate;
				ChangedDate.Value = newProject.Notes[currentIndexNote].DateChange;
				TextBox.Text = newProject.Notes[currentIndexNote].Text;
			}
		}
		/// <summary>
		/// Окно about.
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm noteForm = new AboutForm();
			DialogResult result = noteForm.ShowDialog();
		}
		/// <summary>
		/// Удаление при нажатии Delete.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void NoteAppForm_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				DeleteCommon(); 
			}
		} 

	}
}


