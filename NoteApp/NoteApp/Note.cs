using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace NoteApp
{
	/// <summary>
	/// Класс заметки.
	/// </summary>
	public class Note
	{
		private string _title;
		private string _text;
		private DateTime _created;
		private DateTime _changed;
		private CategoryNote _category;
		/// <summary>
		/// Конструктор.
		/// </summary>
		public Note()
		{
			_created = DateTime.Now;
		}

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
				if (value.Length < 50)
				{
					_title = value;
					_changed = DateTime.Now;
				}
				else
				{
					throw new ArgumentException("value.Length > 50");
				}
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
			get 
			{ 
			  return _category; 
			}
			set
			{
			  _category = value;
			  _changed = DateTime.Now;
			}
		}
		/// <summary>
		/// Методы set и get для поля _created(время создания).
		/// </summary>
		[JsonProperty]
		public DateTime DateCreate
		{
			get 
		    {
			  return _created; 
		    }
			private set
			{
				_created = value;
			}
		}
		/// <summary>
		/// Методы set и get для поля _changed (время изменения).
		/// </summary>
		[JsonProperty]
		public DateTime DateChange
		{
			get 
			{
				return _changed; 
			}
			private set
			{
			  _changed = value;
			}
			
		}
	}
}
