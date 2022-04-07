namespace HelloWorld
{
    class FileHandler
    {
        public void ReadConfigFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException();

                string[] configLines = System.IO.File.ReadAllLines(@filePath);
                foreach (string line in configLines)
                {
                    Console.WriteLine(line);
                }


            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found on specified file.");
            }
        }
        public void ChangeVimColorscheme(string filePath, string theme)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException();

                string[] configLines = File.ReadAllLines(@filePath);
                var fileManipulator = new FileManipulation();
                fileManipulator.ReplaceColorschemeLine(configLines, filePath, "colorscheme", "colorscheme " + theme);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found on specified file.");
            }

        }
        public void ChangeTermColorscheme(string filePath, string theme)
        {
            try
            {
                if (!File.Exists(filePath))
                    throw new FileNotFoundException();

                string[] configLines = File.ReadAllLines(@filePath);
                var fileManipulator = new FileManipulation();
                fileManipulator.ReplaceColorschemeLine(configLines, filePath, "colors: ", "colors: *" + theme);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found on specified file.");
            }

        }
    }
}
