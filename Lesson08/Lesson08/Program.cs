using System.Text;

namespace Lesson08
{
    internal class Program
    {
        static string currentPath = "C:\\files";
        static Stack<string> directoryHistory = new Stack<string>();
        static void Main(string[] args)
        {

            #region File Stream

            //string input = Console.ReadLine() ?? "";

            //string currentDirectory = Directory.GetCurrentDirectory();
            //string path = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

            // files Papka bo'lmasa yaratish
            //if (!Directory.Exists($"{path}\\files"))
            //{
            //    Directory.CreateDirectory($"{path}\\files");
            //}

            //string filePath = $"{path}\\files\\note.dat";

            //byte[] bytes = GetBytes(input);

            // Agar fayl mavjud bo'lsa uni ichidagi ma'lumotni ochirib,
            // byte massivini yozish.
            //using (FileStream fs = new(filePath, FileMode.OpenOrCreate))
            //{
            //    fs.Write(bytes, 0, bytes.Length);
            //}

            //Console.WriteLine();

            // Faylni ochishga urunadi, agarda fayl mavjud bo'lmasa
            // FileNotFoundException yuzaga keladi.
            // Faylni ichidagi barcha baytlarni, outputBytes massiviga
            // 0chi indexidan boshlab, uzunlicha elementlarni o'qiydi.
            // O'qilgan massivni string toifasiga aylantirib, ekranga chiqaradi.
            //using (FileStream fs = new(filePath, FileMode.Open))
            //{
            //    byte[] outputBytes = new byte[fs.Length];
            //    fs.Read(outputBytes, 0, outputBytes.Length);

            //    string output = GetString(outputBytes);

            //    Console.WriteLine($"Output text: {output}");
            //}

            // 12345678
            // fs.Seek(-3, SeekOrigin.End) 12345678
            //                                 ^
            // fs.Seek(3, SeekOrigin.Begin) 12345678
            //                                ^

            // Faylni ochishga urunadi, agarda fayl mavjud bo'lmasa
            // FileNotFoundException yuzaga keladi.
            // Faylni ichidagi barcha baytlarni, outputBytes massiviga
            // 0chi indexidan boshlab, uzunligini yarimicha elementlarni o'qiydi.
            // O'qilgan massivni string toifasiga aylantirib, ekranga chiqaradi.
            //using (FileStream fs = new(filePath, FileMode.Open))
            //{
            //    fs.Seek(0, SeekOrigin.Begin);

            //    byte[] outputBytes = new byte[fs.Length];
            //    fs.Read(outputBytes, 0, outputBytes.Length / 2);

            //    string output = GetString(outputBytes);
            //    Console.WriteLine($"Text from file: {output}");
            //}

            // Faylni ochishga urunadi, agarda fayl mavjud bo'lmasa
            // FileNotFoundException yuzaga keladi.
            // Faylni ichidagi barcha baytlarni, outputBytes massiviga
            // 0 indexidan boshlab, berilgan faylni yarimidan boshlab
            // uzunligini yarimicha elementlarni o'qiydi.
            // O'qilgan massivni string toifasiga aylantirib, ekranga chiqaradi.
            //using (FileStream fs = new(filePath, FileMode.Open))
            //{
            //    fs.Seek(fs.Length / -2, SeekOrigin.End);

            //    byte[] outputBytes = new byte[fs.Length];
            //    fs.Read(outputBytes, 0, outputBytes.Length / 2);

            //    string textFromFile = GetString(outputBytes);
            //    Console.WriteLine($"Text from file: {textFromFile}");
            //}

            #endregion

            #region Stream Writer / Reader

            //string input = Console.ReadLine() ?? "";

            //string currentDirectory = Directory.GetCurrentDirectory();
            //string path = Directory.GetParent(currentDirectory).Parent.Parent.FullName + "\\files\\note.txt";

            //if (!File.Exists(path))
            //{
            //    File.Create(path).Close();
            //}

            //using (StreamWriter writer = new StreamWriter(path))
            //{
            //    writer.WriteLine(input);
            //}

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    string output = reader.ReadLine();
            //    Console.WriteLine($"text from file: {output}");
            //}

            //using (StreamReader reader = new StreamReader(path))
            //{
            //    int output = reader.Read();

            //    while (output != -1)
            //    {
            //        output = reader.Read();

            //        Console.Write(Convert.ToChar(output));
            //    }
            //}

            #endregion

            #region Lesson-07 homework

            Directory.CreateDirectory(currentPath);
            PrintDirectoryName(currentPath);

            Console.WriteLine("1. Create Directory    2. Delete Directory    3. Show All Folders    4. Show All Folders with children");
            Console.WriteLine("5. Create File         6. Delete File         7. Show All Files      8. Show All Files in Directory with children");
            Console.WriteLine("9. Read File           10. Write  File        11. File Details       12. Encode file (Cesar/Vernam)");
            Console.WriteLine("9. Change current directory    10. Return to parent directory");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateDirectory();
                    break;
                case 2:
                    DeleteDirectory();
                    break;
                case 3:
                    ShowAllFolders(currentPath);
                    break;
                case 4:
                    ShowAllFoldersWithChildren(currentPath);
                    break;
                case 9:
                    ChangeDirectory();
                    break;
                case 10:
                    ReturnToParentDirectory();
                    break;
            }

            Console.WriteLine("Enter any key, to continue...");
            Console.ReadKey();
            Console.Clear();

            Main(args);

            #endregion
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