namespace Lesson07
{
    internal class Program
    {
        static string path = @"C:\test\";
        static void Main(string[] args)
        {

            switch (Menu())
            {
                case 1:
                    CreateDirectory();
                    break;
                case 2:
                    DeleteDirectory();
                    break;
                case 3:
                    ShowAllFolders();
                    break;
                case 4:
                    ShowAllFoldersWithChildren();
                    break;
                case 5:
                    CreateFile();
                    break;
                case 6:
                    DeleteFile();
                    break;
                case 7:
                    ShowAllFiles();
                    break;
                case 8:
                    ShowAllFilesWithChildren();
                    break;
                case 9:
                    ChangeCurrentDirectory();
                    break;
                case 10:
                    ReturnToParent();
                    break;
                default:
                    Main(args);
                    break;
            }


            Console.WriteLine("\n\nPress any key to continue....");
            Console.ReadKey();
            Main(args);
        }

        static int Menu()
        {
            Console.Clear();


            Console.WriteLine($"                                    Menu\n");
            Console.WriteLine($"Current page: {path}\n");
            Console.WriteLine("1. Create Directory    2. Delete Directory    3. Show All Folders    4. Show All Folders with children");
            Console.WriteLine("5. Create File         6. Delete File         7. Show All Files      8. Show All Files in Directory with children");
            Console.WriteLine("9. Change current directory    10. Return to parent directory");


            Console.Write("\n\n\nChoose option: ");
            int option = 0;

            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 10)
            {
                Console.WriteLine("Please select frome menu!");
                Console.Write("Choose option: ");
            }

            return option;
        }

        static void CreateDirectory()
        {
            Console.Clear();
            Console.WriteLine("             Create directory section");
            Console.Write("\n\nType directory name: ");

            string directoryName = Console.ReadLine();

            if (!Directory.Exists($"{path}{directoryName}"))
            {
                Directory.CreateDirectory($"{path}{directoryName}");
                Console.WriteLine("\n\nDirectory is successfully created");
            }
            else
            {
                Console.WriteLine("\n\nDirectory is already created");
            }
        }

        static void DeleteDirectory()
        {
            Console.Clear();
            Console.WriteLine("             Delete directory section");

            Console.Write("\n\nType directory name: ");
            string directoryName = Console.ReadLine();

            if (Directory.Exists($"{path}{directoryName}"))
            {
                try
                {
                    Directory.Delete($"{path}{directoryName}");
                    Console.WriteLine("\n\nDirectory is successfully deleted");
                }
                catch (IOException ex)
                {
                    Console.WriteLine($"\n\nI can't delete directory. \nError: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Nimadir xato ketdi...! {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("\n\nDirectory is not found!");
            }
        }

        static void ShowAllFolders()
        {
            Console.Clear();
            Console.WriteLine($"             Folders list in current directory\n\n");

            string[] directories = Directory.GetDirectories(path);
            if (directories.Length == 0)
            {
                Console.WriteLine("Folders not have in current directory");
                return;
            }

            foreach (string dir in directories)
            {
                Console.WriteLine(dir);
            }
        }

        static void ShowAllFoldersWithChildren()
        {
            Console.Clear();
            Console.WriteLine("             Show all folders with children \n\n");

            string[] directories = Directory.GetDirectories(path);

            if (directories.Length == 0)
            {
                Console.WriteLine("Folders not have in current directory");
                return;
            }

            PrintFoldersWithChildren(directories);
        }

        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("             Create file section");

            Console.Write("\n\nType file name: ");
            string fileName = Console.ReadLine();


            if (File.Exists(@$"{path}{fileName}.txt"))
            {
                File.Delete(@$"{path}{fileName}.txt");
                FileStream stream = File.Create(@$"{path}{fileName}.txt");
                stream.Close();
                Console.WriteLine("\n\nFile overrided!");
            }
            else
            {
                FileStream stream = File.Create(@$"{path}{fileName}.txt");
                stream.Close();
                Console.WriteLine("\n\nFile successfully created!");
            }
        }

        static void DeleteFile()
        {
            Console.Clear();
            Console.WriteLine("             Delete file section");

            Console.Write("\n\nType file name: ");
            string fileName = Console.ReadLine();

            if (File.Exists(@$"{path}{fileName}.txt"))
            {
                File.Delete(@$"{path}{fileName}.txt");
                Console.WriteLine("\n\nFile successfully deleted!");
            }
            else
            {
                Console.WriteLine("\n\nFile not found!");
            }
        }

        static void ShowAllFiles()
        {
            Console.Clear();
            Console.WriteLine($"             Files list in current directory\n\n");

            string[] files = Directory.GetFiles(path);

            if (files.Length == 0)
            {
                Console.WriteLine("Files not have in current directory");
                return;
            }

            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }

        static void ShowAllFilesWithChildren()
        {
            Console.Clear();
            Console.WriteLine("             Show all files with children \n\n");

            string[] directories = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            if (directories.Length == 0 && files.Length == 0)
            {
                Console.WriteLine("Files don't have in this page and childrens");
                return;
            }

            if (files.Length != 0)
            {
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }

            if (directories.Length != 0)
            {
                PrintFilesWithChildren(directories);
            }
        }

        static void ChangeCurrentDirectory()
        {
            Console.Clear();
            Console.WriteLine("             Change current directory section");

            Console.Write("\n\nType folder name: ");
            string folderName = Console.ReadLine();

            if (Directory.Exists($"{path}{folderName}"))
            {
                path = $@"{path}{folderName}\";

                Console.WriteLine("\n\nCurrent page successfully changed\n");
                Console.WriteLine($"Your current page: {path}");
            }
            else
            {
                Console.WriteLine("\n\nPage not found! Please type valid folder name!");
            }
        }

        static void ReturnToParent()
        {
            Console.Clear();

            DirectoryInfo folderParent = Directory.GetParent(path);
            path = folderParent.Parent + @"\";

            Console.WriteLine("\n\nCurrent page successfully changed\n");
            Console.WriteLine($"Your current page: {path}");
        }

        static void PrintFoldersWithChildren(string[] directories)
        {
            for (int i = 0; i < directories.Length; i++)
            {
                Console.WriteLine(directories[i]);
                string[] folders = Directory.GetDirectories(directories[i]);

                if (folders.Length == 0)
                {
                    continue;
                }

                PrintFoldersWithChildren(folders);
            }
        }

        static void PrintFilesWithChildren(string[] directories)
        {
            for (int i = 0; i < directories.Length; i++)
            {
                string[] files = Directory.GetFiles(directories[i]);

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }

                string[] folders = Directory.GetDirectories(directories[i]);

                if (folders.Length == 0)
                {
                    continue;
                }

                PrintFilesWithChildren(folders);
            }
        }
    }
}