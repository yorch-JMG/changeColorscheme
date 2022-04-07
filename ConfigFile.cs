namespace HelloWorld
{
	class ConfigFile
	{
		public ConfigFile(string name, string filePath, string theme)
		{
			Name =name;
			FilePath = filePath;
			Theme = theme;
		}
		public string Name { get; set; }
		public string FilePath { get; set; }
		public string Theme { get; set; }
	}
}
