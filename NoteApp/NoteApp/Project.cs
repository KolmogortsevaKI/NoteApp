using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp
{
	/// <summary>
	/// List для хранения всех заметок проекта.
	/// </summary>
	public class Project
	{
		/// <summary>
		/// Список заметок.
		/// </summary>
		private List<Note> _notes = new List<Note>();
		/// <summary>
		/// Текущая заметка.
		/// </summary>
		private int _currentNote = -1;
		/// <summary>
		/// Свойство списка всех заметок.
		/// </summary>
		public List<Note> Notes
		{
			get 
			{ 
			  return _notes; 
			}
			set 
			{
			 _notes = value; 
			}
		}
		/// <summary>
		/// Конструктор Project.
		/// </summary>
		public Project()
		{
			Notes = new List<Note>();
		}
		/// <summary>
		/// Функиця для сортировки списка заметок по дате изменения.
		/// </summary>
		public List<Note> SortNotes(List<Note> noteList = null)
		{
			var sortingList = noteList ?? Notes;

			sortingList.Sort(delegate (Note x, Note y)
			{
				if (x.DateChange == null && y.DateChange == null) return 0;
				else if (x.DateChange == null) return 1;
				else if (y.DateChange == null) return -1;
				else return y.DateChange.CompareTo(x.DateChange);
			});
			return sortingList;
		}
		/// <summary>
		/// Свойство текущей заметки.
		/// </summary>
		public int CurrentNote
		{
			get
			{
				return _currentNote;
			}
			set
			{
				_currentNote = value;
			}
		}
	}
}
