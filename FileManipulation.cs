namespace HelloWorld
{
    class FileManipulation
    {
        public void ReplaceColorschemeLine(string[] configLines, string filePath, string wordForLineReplacement, string configChangeOfThemeString)
        {
            int lineWithWordForReplacement = 0;
            int index = 0;
            foreach (string line in configLines)
            {
                if (line.Contains(wordForLineReplacement))
                {
                    lineWithWordForReplacement = index;
                    break;
                }
                index++;
            }
            configLines[index] = configChangeOfThemeString;
            File.WriteAllLines(@filePath, configLines);

        }
    }
}
