namespace Common
{
    using System.IO;
    using System.Reflection;

    public static class FileUtils
    {
        public static string[] GetProblemInput()
        {
            var filePath = $"{Assembly.GetCallingAssembly().GetName().Name}Input.txt";
            var problemInput = File.ReadAllLines(filePath);
            return problemInput;
        } 
    }
}
