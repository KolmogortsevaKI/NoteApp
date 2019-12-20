using System;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	/// <summary>
	/// Форма для работы с текущей заметкой.
	/// </summary>
	public partial class AddEditForm : Form
	{
		/// <summary>
		///Для задания имени по умолчанию.
		/// </summary>
		private static int _defaultNameCount = 0;
		private static string _defaultName = "Безымянный №";
		/// <summary>
		///Текущая заметка.
		/// </summary>
		private Note _currentNote = new Note();
		/// <summary>
		///Геттеры и сеттеры для текущей заметки.
		/// </summary>
		public Note CurrentNote
		{
			get
			{
				_currentNote.Text = TextBox.Text;
				if (AddTitleBox.Text == "")
				{
					string noteName = _defaultName + _defaultNameCount;
					_defaultNameCount++;
					AddTitleBox.Text = noteName;
				}				
				_currentNote.Title = AddTitleBox.Text;
				_currentNote.Category = (CategoryNote)CategoryBox.SelectedItem;
				return _currentNote;
			}
			set
			{
				if (value != null)
				{
					AddTitleBox.Text = value.Title;
					CreatedDateNote.Value = value.DateCreate;
					ChangedDateNote.Value = value.DateChange;
					TextBox.Text = value.Text;
					CategoryBox.SelectedItem = value.Category;
				}
			}
		}
		/// <summary>
		/// Конструктор.
		/// </summary>		
		public AddEditForm()
		{
			InitializeComponent();
			/// <summary>
			/// Заполнение списка категориями.
			/// </summary>
			var values = System.Enum.GetValues(typeof(CategoryNote));	
			CategoryBox.DataSource = values;
			CategoryBox.SelectedIndex = 0;
		}
		/// <summary>
		/// Кнопка ОК.
		/// </summary>
		private void OK_Click(object sender, EventArgs e)
		{			
			DialogResult = DialogResult.OK;
			Close();
		}
		/// <summary>
		/// Кнопка Cancel.
		/// </summary>
		private void Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}	
	}
}
