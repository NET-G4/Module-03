using System.Text;

namespace Lesson08
{
    internal class Program
    {
        static string currentPath = "C:\\files";
        static Stack<string> directoryHistory = new Stack<string>();
        static void Main(string[] args)
        {
            Console.WriteLine();
        }

        static byte[] GetBytes(string input) => Encoding.Default.GetBytes(input);

        static string GetString(byte[] bytes) => Encoding.Default.GetString(bytes);

        #region Homework

        static void CreateDirectory()
        {
            string input = Console.ReadLine();

            if (Directory.Exists($"{currentPath}\\{input}"))
            {
                PrintError($"Directory {input} already exists.");
                return;
            }

            Directory.CreateDirectory($"{currentPath}\\{input}");

            Console.WriteLine($"Directory {input} was created");
        }

        static void DeleteDirectory()
        {
            string input = Console.ReadLine();

            if (!Directory.Exists($"{currentPath}\\{input}"))
            {
                PrintError($"Directory does not exist.");
                return;
            }

            Directory.Delete($"{currentPath}\\{input}");

            Console.WriteLine($"Directory {input} was deleted.");
        }

        static void ShowAllFolders(string path)
        {
            string[] directories = Directory.GetDirectories(path);

            if (directories.Length == 0)
            {
                Console.WriteLine("Directory is empty.");
            }

            foreach (var directory in directories)
            {
                PrintDirectoryName(directory);
            }
        }

        static void ShowAllFoldersWithChildren(string path)
        {
            string[] directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                PrintDirectoryName(directory);

                string[] strings = Directory.GetDirectories(directory);
                if (strings.Length == 0)
                {
                    continue;
                }

                ShowAllFoldersWithChildren(directory);
            }
        }

        static void ChangeDirectory()
        {
            ShowAllFolders(currentPath);

            string input = Console.ReadLine();

            if (!Directory.Exists($"{currentPath}\\{input}"))
            {
                PrintError($"Diretory {input.ToUpper()} does not exist");

                return;
            }

            directoryHistory.Push(currentPath);
            currentPath = $"{currentPath}\\{input}";
        }

        static void ReturnToParentDirectory()
        {
            if (directoryHistory.Count == 0)
            {
                PrintError("You are in root directory");
                return;
            }

            currentPath = directoryHistory.Pop();
        }

        static void PrintError(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(error);
            Console.ResetColor();
        }

        static void PrintDirectoryName(string name)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(name);
            Console.ResetColor();
        }

        #endregion
    }
}