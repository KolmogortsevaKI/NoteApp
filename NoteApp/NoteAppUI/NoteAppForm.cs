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
		/// <summary>
		/// Список текущих заметок.
		/// </summary>
		private List<Note> currentNotes;

		///<summary> 
		///Привязка категорий к значениям.Добавление категории All.
		///</summary>
		public NoteAppForm()
		{
			InitializeComponent();	
			CategoryBox.Items.Add("All"); 
			var listCategory = System.Enum.GetValues(typeof(CategoryNote));
			foreach (var category in listCategory)
			{
			  CategoryBox.Items.Add(category);
			}
		}

		/// <summary>
		/// Добавление заметки.
		/// </summary>
		private void AddCommon()
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
		/// Редактирование заметки.
		/// </summary>
		private void EditCommon()
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
		/// Удаление заметки.
		/// </summary>
		private void DeleteCommon()
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
					newProject.CurrentNote = -1;
					SaveProject();
					NoteBox.SelectedIndex = -1;
					CurrentCategory();
					CleanNote();
				}
			}
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
			if (currentNotes.Count-1 >= newProject.CurrentNote)
			{
				NoteBox.SelectedIndex = newProject.CurrentNote;
			}
			else
			{
				NoteBox.SelectedIndex = -1;
				newProject.CurrentNote = -1;
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
				TitleLabel.Text = newProject.Notes[currentIndexNote].Title;
				CurrentCategoryNote.Text = newProject.Notes[currentIndexNote].Category.ToString();
				CreateDate.Value = newProject.Notes[currentIndexNote].DateCreate;
				ChangedDate.Value = newProject.Notes[currentIndexNote].DateChange;
				TextBox.Text = newProject.Notes[currentIndexNote].Text;
				newProject.CurrentNote = newProject.Notes.IndexOf(currentNotes[NoteBox.SelectedIndex]);
				SaveProject();
			}
		}

		/// <summary>
		/// Отчистка на дисплее о данных заметки.
		/// </summary>
		private void CleanNote()
		{
			CurrentCategoryNote.Text = "";
			CreateDate.Text = "";
			ChangedDate.Text = "";
			TitleLabel.Text = "Заметка";
			TextBox.Text = "";
		}

		/// <summary>	
		/// Выгрузка проекта со списком.		
		/// </summary>
		private void NoteApp_Load(object sender, EventArgs e)
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			newProject = ProjectManager.LoadFromFile(path);
			CategoryBox.SelectedIndex = 0;
			UpdateNoteBox(newProject.Notes);
		}

		/// <summary>
		/// Сохранение.
		/// </summary>
		private void SaveProject()
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			ProjectManager.SaveToFile(newProject, path);
		}

		/// <summary>
		/// Получение заметок по выбранной категории.
		/// </summary>
		private void CategoryBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			NoteBox.SelectedIndex = -1;
			CleanNote();
			CurrentCategory();
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
		/// Сохранение перед закрытием приложения.
		/// </summary>
		private void NoteApp_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveProject();
		}

		/// <summary>
		///Выход.
		/// </summary>
		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		/// <summary>
		/// Окно about.
		/// </summary>
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutForm noteForm = new AboutForm();
			noteForm.ShowDialog();
		}

		/// <summary>
		/// Удаление при нажатии Delete.
		/// </summary>
		private void NoteAppForm_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Delete)
			{
				DeleteCommon(); 
			}
		} 
	}
}


