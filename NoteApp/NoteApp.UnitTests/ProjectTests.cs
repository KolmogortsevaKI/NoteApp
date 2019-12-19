using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NoteApp;

namespace NoteApp.UnitTests
{
	[TestFixture]
	class ProjectTests
	{
		[Test(Description = "")]
		public void TestNoteGet_CorrectValue()
		{
			//Setup
			var expected = new List<Note>();
			var note = new Note();
			note.Title = "Заголовок";
			note.Category = CategoryNote.Home;
			expected.Add(note);
			//Testing
			var project = new Project();
			project.Notes.Add(note);
			var actual = project.Notes;
			//Assert
			Assert.AreEqual(expected[0].Title, actual[0].Title);
			Assert.AreEqual(expected[0].Text, actual[0].Text);
			Assert.AreEqual(expected[0].DateCreate, actual[0].DateCreate);
			Assert.AreEqual(expected[0].DateChange, actual[0].DateChange);
			Assert.AreEqual(expected[0].Category, actual[0].Category);
		}
	}
}
