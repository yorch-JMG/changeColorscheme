namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DotNetEnv.Env.Load();
            var termconf = Environment.GetEnvironmentVariable("TERMCONF_FILEPATH");
            var nvconf = Environment.GetEnvironmentVariable("VIMCONF_FILEPATH");
            var fileManipulator = new FileHandler();
            if (nvconf is not null)
            {
                fileManipulator.ChangeVimColorscheme(nvconf, "gruvbox");
                fileManipulator.ReadConfigFile(nvconf);
            }
        }
    }
}
