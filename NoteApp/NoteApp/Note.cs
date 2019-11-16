using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NoteApp
{
	/// <summary>
	/// Класс Заметка.
	/// </summary>
	public class Note
	{
		private string _title = "Безымянный";
		private string _text;
		private DateTime _created = DateTime.Now;
		private DateTime _changed;
		private CategoryNote _category;


		/// <summary>
		/// Методы set и get для поля _title.
		/// </summary>
		public string Title
		{
			get
			{
				return _title;
			}

			set
			{
				if (value.Length > 50)
				{
					throw new ApplicationException("Название слишком длинное");
				}
				else { _title = value; _changed = DateTime.Now; }
			}
		}

		/// <summary>
		/// Методы set и get для поля _text.
		/// </summary>
		public string Text
		{
			get
			{
				return _text;
			}

			set
			{
				_text = value;
				_changed = DateTime.Now;
			}

		}


		/// <summary>
		/// Методы set и get для поля _category.
		/// </summary>
		public CategoryNote Category
		{
			get { return _category; }
			set
			{
				_category = value;
				_changed = DateTime.Now;
			}
		}

		/// <summary>
		/// Методы set и get для поля _created(время создания).
		/// </summary>
		public DateTime DateCreate
		{
			get { return _created; }
		}

		/// <summary>
		/// Методы set и get для поля _changed (время изменения).
		/// </summary>
		public DateTime DateChange
		{
			get { return _changed; }
		}

	}
}
