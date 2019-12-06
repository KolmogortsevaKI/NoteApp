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
	/// Класс Заметка.
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

		[JsonConstructor]
		public Note(string title, string text, DateTime created, DateTime changed, CategoryNote category)
		{
			Title = title;
			Text = text;
			DateCreate = created;
			DateChange = changed;
			Category = category;
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
				if (value.Length > 50)
				{
					throw new ArgumentException("Length is too long");
				}
			  
				if(value!=null)
				{
					try
					{
						string pattern = @"^[^\s]";
						Regex regex = new Regex(pattern);
						Match match = regex.Match(value);

					}
					catch (ArgumentException exception)
					{
						throw new ArgumentException("Title couldn't start from space");	
					}

					_title = value; 
					_changed = DateTime.Now; 
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
