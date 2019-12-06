using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NoteApp.UnitTests
{
	/// <summary>
	/// 
	/// </summary>
	[TestFixture]
    public class NoteTest
    {		
		/// <summary>
		/// 
		/// </summary>
		/// <param name="expected"></param>
		/// <returns></returns>
		[TestCase("Текст", ExpectedResult = "Текст", TestName = "Позитивный тест геттера Title")]
		public string TestTitleGet_CorrectValue(string expected)
		{
			//Setup
			var note = new Note();
			note.Title = expected;
			
			//Arrange
			string actual = note.Title;

			//Assert
			return actual;
		}


		/// <summary>
		/// 
		/// </summary>
		/// <param name="wrongTitle"></param>
		/// <param name="message"></param>
		[TestCase("Title-Title-Title-Title-Title-Title-Title-Title-Title-Title", "Должно возникать исключение, если заголовок длиннее 50 символов",
			TestName = "Присвоение неправильного заголовка больше 50 символов")]
		public void TestTitleSet_ArgumentException(string wrongTitle, string message)
		{
			//Setup
			var note = new Note();
			Assert.Throws<ApplicationException>(
			() => { note.Title = wrongTitle; }, message);
		}
    }
}
