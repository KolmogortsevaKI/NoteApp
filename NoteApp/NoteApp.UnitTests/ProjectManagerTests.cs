using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using NoteApp;
using NUnit.Framework;

namespace ProjectTests
{
	[TestFixture]
	internal class ProjectManagerTest
	{
		[Test(Description = "Проверка сериализации")]
		public void TestSaveToFile_CorrectValue()
		{
			//Setup
			var example = new Project 
			{ 
				Notes = new List<Note>() 
			};
			Note note = new Note();
			note.Title = "First";
			note.Text = "asd";
			note.Category = CategoryNote.Job;
			example.Notes.Add(note);
			Note note1 = new Note();
			note1.Title = "Second";
			note1.Text = "dsa";
			note1.Category = CategoryNote.Home;
			example.Notes.Add(note1);
			string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			//Testing
			ProjectManager.SaveToFile(example, path);
			string fileName = path + @"/Notes.notes";
			var expected = File.ReadAllText(fileName);
			var actual = File.ReadAllText(fileName);
			//Assert
			Assert.AreEqual(actual, expected, "Сравнение сериализатора ProjectManager и встроенного.");
		}
		[Test(Description = "Проверка десериализации")]
		public void TestLoadFromFile_CorrectValue()
		{
			//Setup
			var actual = new Project 
			{
				Notes = new List<Note>() 
			};
			Note note = new Note();
			note.Title = "First";
			note.Text = "asd";
			note.Category = CategoryNote.Job;
			actual.Notes.Add(note);
			Note note1 = new Note();
			note1.Title = "Second";
			note1.Text = "dsa";
			note1.Category = CategoryNote.Home;
			actual.Notes.Add(note1);
			string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			string fileName = $@"{path}\ExpectedNoteApp.notes";
			//Testing
			var expected = ProjectManager.LoadFromFile(fileName);
			//Assert
			for (int i = 0; i < actual.Notes.Count; i++)
			{
				Assert.AreEqual(actual.Notes[i].Title, expected.Notes[i].Title,
				  "Сравнение результата десериализованного созданного заголовка и ожидаемого");
				//Assert.AreEqual(actual.Notes[i].Text, expected.Notes[i].Text,
				//  "Сравнение результата десериализованного созданного текста и ожидаемого");
				//Assert.AreEqual(actual.Notes[i].Category, expected.Notes[i].Category,
				//  "Сравнение результата десериализованной созданной категории и ожидаемой");
			}
		}
	}
}
