namespace HelloWorld
{
	class UserInputHandler 
	{
		public string ChangeThemeDialogue(string nvconf, string termconf, FileHandler fileHandler)
		{
			Console.WriteLine("Enter theme for change:");
			string? theme = Console.ReadLine();
			if (theme is not null){
				fileHandler.ChangeVimColorscheme(nvconf, theme);
				fileHandler.ChangeTermColorscheme(termconf, theme);
				return "Theme changed correctly!";
			}
			return "Configs are not set on .env file.";


		}	
	}
}
