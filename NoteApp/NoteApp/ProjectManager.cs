using System;
using System.IO;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

	namespace NoteApp
	{
	/// <summary>
	/// Класс Сериализации, с помощью которого выполняется загрузка/выгрузка информации в формате JSON.
	/// </summary>
	public static class ProjectManager
	{
		public static void SaveToFile(Project project, string path)
		{
			//Создаём экземпляр сериализатораj,
			JsonSerializer serializer = new JsonSerializer { Formatting = Formatting.Indented };
			//Открываем поток для записи в файл с указанием пути
			using (StreamWriter sw = new StreamWriter(path + "/Notes.notes"))
			using (JsonWriter writer = new JsonTextWriter(sw))
			{
				//Вызываем сериализацию и передаем объект, который хотим сериализовать
				serializer.Serialize(writer, project);
			}
		}

		public static Project LoadFromFile(string path)
		{
			//Создаём переменную, в которую поместим результат десериализации
			Project project = null;
			//Создаём экземпляр сериализатора
			JsonSerializer serializer = new JsonSerializer { Formatting = Formatting.Indented };
			try
			{
				using (StreamReader sr = new StreamReader(path + @"/Notes.notes"))
				using (JsonReader reader = new JsonTextReader(sr))
				{
					//Вызываем десериализацию и явно преобразуем результат в целевой тип данных
					project = (Project)serializer.Deserialize<Project>(reader);
				}
				return project;
			}
			catch
			{
				return new Project();
			}
		}
	}
}