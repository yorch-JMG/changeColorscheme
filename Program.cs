namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var termconf = Environment.GetEnvironmentVariable("TERMCONF_FILEPATH");
            var nvconf = Environment.GetEnvironmentVariable("VIMCONF_FILEPATH");
            var fileHandler = new FileHandler();
						var userInput = new UserInputHandler();
						if (termconf is not null && nvconf is not null)
						{
							userInput.ChangeThemeDialogue(nvconf, termconf, fileHandler);
							Console.WriteLine("Attempted to change theme.");
						}
							Console.WriteLine("NO .env file, make a .env file on the project root directory.");
						
        }
    }
}
