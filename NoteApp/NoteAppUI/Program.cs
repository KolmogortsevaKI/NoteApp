using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApp;

namespace NoteAppUI
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Note newNote1 = new Note();
			newNote1.Title = "First";
			newNote1.Category = CategoryNote.Finance;// (CategoryNote)Enum.GetValues(typeof(CategoryNote)).GetValue(3);
			newNote1.Text = "It works";
			Project newProject = new Project();
			newProject.Notes.Add(newNote1);
			Note newNote2 = new Note();
			newNote2.Category = CategoryNote.Health;
			newProject.Notes.Add(newNote2);
			ProjectManager.SaveToFile(newProject);

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new NoteApp());

		}
	}
}
