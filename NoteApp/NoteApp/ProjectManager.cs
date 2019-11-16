using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace NoteApp
{
	/// <summary>
	/// Класс, который реализует сохранение данных в файл и загрузку данных из файла.
	/// </summary>
	public static class ProjectManager
	{
		/// <summary>
		/// Содержит имя файла для сохранения и загрузки.
		/// </summary>
		private const string _name = @"\NoteApp.notes";

		/// <summary>
		/// Содержит путь к папке с Мои документы.
		/// </summary>
		private static readonly string _path =
		Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

		/// <summary>
		/// Содержит полный путь к файлу.
		/// </summary>
		private static readonly string _file = _path + _name;


		/// <summary>
		///Метод сохраняет данные в файл.
		/// </summary>
		public static void SaveToFile(Project data)
		{
			var serializer = new JsonSerializer { Formatting = Formatting.Indented };
			using (var sw = new StreamWriter(_file))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				serializer.Serialize(writer, data);
			}
		}

		/// <summary>
		///Метод, который загружает данные из файла.
		/// </summary>
		public static Project LoadFromFile()
		{
			Project project = null;
			var serializer = new JsonSerializer { Formatting = Formatting.Indented };
			using (var sr = new StreamReader(_file))
			using (JsonReader reader = new JsonTextReader(sr))
			{
				project = serializer.Deserialize<Project>(reader);
			}

			return project;
		}

	}
}
