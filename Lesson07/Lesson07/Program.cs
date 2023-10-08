using System.Runtime.InteropServices;

namespace Lesson07
{
    internal class Program
    {
        static string path = "D:\\TestDrive";
        static void Main(string[] args)
        {
            try
            {
                Menu();
            }
            catch (Exception)
            {

            }

            Main(args);
        }
        static void Menu()
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("1. Create Directory    2. Delete Directory    3. Show All Folders    4. Show All Folders with children");
            Console.WriteLine("5. Create File         6. Delete File         7. Show All Files      8. Show All Files in Directory with children");
            Console.WriteLine("9. Change current directory    10. Return to parent directory    11.Read File");
            Console.WriteLine("12.Write File    13.File details    14.Encrypt file  15.Decrypt file");

            Console.Write("Choose the category : ");

            int.TryParse(Console.ReadLine() ?? "0" , out int menu);
            
            switch(menu)
            {
                case 1 : CreateDirectory();                 break;
                case 2 : DeleteDirectory();                 break;
                case 3 : ShowAllFolders(path);              break;
                case 4 : ShowAllFoldersWithChildrens(path); break;
                case 5 : CreateFile();                      break;
                case 6 : DeleteFile();                      break; 
                case 7 : ShowAllFile();                     break;
                case 8 : ShowAllFileWithChildren(path);     break;
                case 9 : ChangeCurrentDirectory();          break;
                case 10: BackToParentDirectory();          break;
                case 11: ReadFile();                        break;
                case 12: FileWrite();                       break;
                case 13: DisplayInfoFile();                 break;
                case 14: EnCode(Encryption);                break;
                case 15: EnCode(Decryption);                break;       
            }
        }
        static void CreateDirectory()
        {
            Console.Write("Enter name directory : ");
            
            string nameDirectory = Console.ReadLine() ?? "";

            Directory.CreateDirectory($"{path}\\{nameDirectory}");
        }
        static void DeleteDirectory()
        {
            Console.Write("Enter name directory : ");

            string nameDirectory = Console.ReadLine() ?? "";

            try
            {
                Directory.Delete($"{path}\\{nameDirectory}");
            }
            catch (Exception)
            {
                Console.WriteLine("Bu papka bo'sh emas!");
            }
        }
        static void ShowAllFolders(string anyPath)
        {
            string[] directories = Directory.GetDirectories(anyPath);

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Console.ForegroundColor = currentColor;
        }
        static void ShowAllFoldersWithChildrens(string path1)
        {
            string[] directories = Directory.GetDirectories(path1);

            if(directories.Length== 0)
            {
                return;
            }
            
            foreach(var directory in directories) 
            {
                ShowAllFoldersWithChildrens(directory);
            }


            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
            Console.ResetColor();
        }

        static void CreateFile()
        {
            Console.Write("Enter name File : ");

            string nameFile= Console.ReadLine() ?? "";

            if (!File.Exists($"{path}\\New Text Document1.txt"))
            {
                try
                {
                    FileStream stream = File.Create($"{path}\\{nameFile}.txt");
                    stream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        static void DeleteFile()
        {
            Console.WriteLine("Enter name file");
            string nameFile = Console.ReadLine() ?? "";

            if (File.Exists($"{path}\\{nameFile}.txt"))
            {
                File.Delete($"{path}\\{nameFile}.txt");
            }
            else
            {
                Console.WriteLine("File not exist!");
            }

        }
        static void ShowAllFile()
        {
            string[] files = Directory.GetFiles(path);

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.ResetColor();
        }
        static void ShowAllFileWithChildren(string path1)
        {
            string[] directories= Directory.GetDirectories(path1);
            
            List<string> files = new List<string>();
            
            //Birinchi kirib kelgan papkadagi fayllar tashlab ketilmasligi va undan keyingi
            //kod sifati yaxshilanishi uchun ->
            if (path1 == path)
            {
                files = Directory.GetFiles(path1).ToList();
            }

            foreach (var directory in directories)
            {
                files.AddRange(Directory.GetFiles(directory).ToList());
                
                ShowAllFileWithChildren(directory);
            }

            if (files.Count== 0)
            {
                return;
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            Console.ResetColor();
        }
        static void ChangeCurrentDirectory()
        {
            Console.Write("Enter name directory for change current directory : ");

            string nameDirectory = Console.ReadLine() ?? "";
            nameDirectory = path + "\\" + nameDirectory;

            if (Directory.Exists(nameDirectory))
            {
                path = nameDirectory;
            }
            else
            {
                Console.WriteLine("Bunday nomli papka topilmadi!");
            }
        }
        static void BackToParentDirectory()
        {
            Console.WriteLine($"Current directory is {path}");

            path = Directory.GetParent(path).FullName;

            Console.WriteLine($"Current directory is : {path}");
        }
        static void ReadFile()
        {
            Console.WriteLine("Enter filen name or path");

            string fileName = Console.ReadLine() ?? "";
            fileName = "\\" + fileName + ".txt";

            if (!File.Exists(path + fileName))
            {
                Console.WriteLine("File not found!");
                return;
            }
           
            using (StreamReader reader= new StreamReader(path + fileName))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                int output = reader.Read();

                while (output != -1)
                {
                    Console.Write(Convert.ToChar(output));
                    output = reader.Read();
                }

                Console.ResetColor();
                Console.WriteLine();
            }
        } 
        static void FileWrite()
        {
            Console.WriteLine("Enter file name or path");

            string fileName = Console.ReadLine() ?? "";

            fileName = path + "\\" + fileName + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
                Console.WriteLine("Do you want create new file ? 1.Yes    2.No");
                
                if (int.Parse(Console.ReadLine() ?? "0") != 1)
                {
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter(fileName,true))
            {
                Console.Write("Enter the text: ");

                string input = Console.ReadLine() ?? "";

                writer.WriteLine(input);
            }
        }
        static void DisplayInfoFile()
        {
            Console.WriteLine("Enter filen name or path");

            string fileName = path + "\\" + Console.ReadLine() + ".txt";
            
            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
                return;
            }
            FileInfo file = new(fileName);

            Console.WriteLine($"File name {file.FullName}");
            Console.WriteLine($"File attribute : {file.Attributes}");
            Console.WriteLine($"Creation time : {file.CreationTime}");
            Console.WriteLine($"Last write time : {file.LastWriteTime}");
        }
        static void EnCode(Action<byte, byte[]>func)
        {
            Console.WriteLine("Enter filen name or path");

            string fileName = Console.ReadLine() ?? "";
            fileName = path + "\\" + fileName + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
                return;
            }
            
            byte[] readText = File.ReadAllBytes(fileName);

            Console.WriteLine("Enter the key : ");
            byte.TryParse(Console.ReadLine(), out byte key);
            
            //Main enryption or decryption
            func(key,readText);
            

            File.WriteAllBytes(fileName, readText);
        }
        static void Encryption(byte key,byte[] readText)
        {
            Console.WriteLine("the text is encrypted");
            for (int i = 0; i<readText.Length; i++)
            { 
                readText[i] += key;
                Console.Write((char)readText[i] + " ");
            }
        }
        static void Decryption(byte key, byte[] readText)
        {
            Console.WriteLine("the text is decrypted");
            for (int i = 0; i<readText.Length; i++)
            {
                readText[i] -= key;
                Console.Write((char)readText[i] + " ");
            }

        }

    }

}