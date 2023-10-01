using System.Runtime.InteropServices;

namespace Lesson07
{
    internal class Program
    {
        static string path = "D:\\TestDrive";
        static void Main(string[] args)
        {
            #region DriveInfo

            //DriveInfo[] drives = DriveInfo.GetDrives();

            //foreach (var drive in drives)
            //{
            //    Console.WriteLine($"name: {drive.Name}");
            //    Console.WriteLine($"Total size: {drive.TotalSize}");
            //    Console.WriteLine($"Free space: {drive.AvailableFreeSpace}");
            //    Console.WriteLine($"Type: {drive.DriveType}");
            //    Console.WriteLine($"Ready: {drive.IsReady}");
            //    Console.WriteLine($"Root: {drive.RootDirectory}");
            //}

            #endregion

            #region Directory

            //string path = @"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03";

            // Console.WriteLine(Directory.Exists(path));

            // pathda bo'lgan barcha fayllarni va papkalarni olish
            //string[] files = Directory.GetFiles(path);
            //string[] directories = Directory.GetDirectories(path);

            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}
            //Console.WriteLine();

            //foreach (var directory in directories)
            //{
            //    Console.WriteLine(directory);
            //}

            //Console.WriteLine();

            //Console.WriteLine($"Current directory: {Directory.GetCurrentDirectory()}");
            //Console.ReadKey();

            // Yangi papka ochish
            //Console.WriteLine(Directory.Exists(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03\NewFolder"));
            //Directory.CreateDirectory(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03\NewFolder");
            //Console.WriteLine(Directory.Exists(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03\NewFolder"));

            // Papkani boshqa papkaga ko'chirish
            // Agarda oshqa papkada shu nomli papka mavjud bo'lsa exception qaytaradi
            //try
            //{
            //    Directory.Move(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03\NewFolder", @"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module2\NewFolder");
            //    Console.WriteLine(Directory.Exists(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03\NewFolder"));
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine($"Papka yaratishda xato bo'ldi. Papka uje mavjud bo'lishi mumkin. Batafsil: {ex.Message}");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Nimadur nito ketti... Batafsil: {ex.Message}");
            //}

            // Papkani o'zidan oldingi papkani qaytarish
            // Console.WriteLine(Directory.GetParent(@"C:\Users\Miraziz_Khidoyatov\Documents\Pdp\G4\Module-03"));

            // Proektni ichida yangi papka ochish
            //string projectPath = Directory.GetCurrentDirectory();
            //projectPath = Directory.GetParent(projectPath).Parent.Parent.FullName;
            //Directory.CreateDirectory($"{projectPath}\\files");
            //Directory.CreateDirectory($"{projectPath}\\files");

            // Papkani o'chirish
            // Agarda papka ichida fayl yoki papka bo'lsa o'chirish
            // mumkin bo'lmasligi uchun exception qaytaradi.
            //try
            //{
            //    Directory.Delete($"{projectPath}\\files");
            //}
            //catch (IOException ex)
            //{
            //    Console.WriteLine($"Ochirib bo'lmadi, sabab: {ex.Message}.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Nima bo'lganini bilmay qoldik... {ex.Message}.");
            //}

            #endregion

            #region DirectoryInfo

            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\files\newfolder");
            //Console.WriteLine(directoryInfo.FullName);

            // Yangi papka ochish
            if (!directoryInfo.Exists)
            {
                directoryInfo.Create();
            }

            // Papka qachon yaratilgani xaqida ma'lumot
            //Console.WriteLine(directoryInfo.CreationTime);
            // Papkaga qachon oxirgi martta kirilgan
            //Console.WriteLine(directoryInfo.LastAccessTime);
            // Papka qachon oxirgi martta o'zgartirilgan
            //Console.WriteLine(directoryInfo.LastWriteTime);

            // Papkani o'chirish
            //Console.WriteLine(directoryInfo.Exists);
            //directoryInfo.Delete();
            //Console.WriteLine(directoryInfo.Exists);

            // Papkani boshqa joyga ko'chirish
            //try
            //{
            //    Console.WriteLine(directoryInfo.Exists);
            //    directoryInfo.MoveTo(@"C:\files\new-folder-1");
            //    Console.WriteLine(directoryInfo.Exists);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"{directoryInfo.FullName}, {ex.Message}");
            //}

            // Papkani to'liq yo'li
            // Console.WriteLine(directoryInfo.FullName);

            //DirectoryInfo[] directories = directoryInfo.GetDirectories("book*.");

            //foreach (DirectoryInfo d in directories)
            //{
            //    Console.WriteLine(d.FullName);
            //}

            #endregion

            #region File

            // file mavjud bo'lmasa yangi yaratish
            //string path = @"C:\files";

            //if (!File.Exists($"{path}\\New Text Document1.txt"))
            //{
            //    try
            //    {
            //        FileStream stream = File.Create($"{path}\\New Text Document1.txt");
            //        stream.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //if (!File.Exists($"{path}\\newFolder\\New Text Document1.txt"))
            //{
            //    try
            //    {
            //        File.Move($"{path}\\New Text Document1.txt", $"{path}\\newFolder\\New Text Document1.txt");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //if (File.Exists($"{path}\\newFolder\\New Text Document1.txt"))
            //{
            //    try
            //    {
            //        File.Copy($"{path}\\newFolder\\New Text Document1.txt", $"{path}\\New Text Document1.txt");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //if (File.Exists($"{path}\\newFolder\\New Text Document1.txt"))
            //{
            //    File.Delete($"{path}\\newFolder\\New Text Document1.txt");
            //}

            #endregion

            #region FileInfo

            //FileInfo fileInfo = new FileInfo($"C:\\files\\New File.txt");

            //if (!fileInfo.Exists)
            //{
            //    try
            //    {
            //        FileStream stream = fileInfo.Create();
            //        stream.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //if (fileInfo.Exists && !File.Exists("C:\\files\\newFolder\\New File1.txt"))
            //{
            //    try
            //    {
            //        fileInfo.MoveTo("C:\\files\\newFolder\\New File1.txt");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //if (fileInfo.Exists && !File.Exists("C:\\files\\New File.txt"))
            //{
            //    try
            //    {
            //        fileInfo.CopyTo("C:\\files\\New File.txt");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //fileInfo.MoveTo("C:\\files\\newFolder\\New File1.txt", true);
            //fileInfo.CopyTo("C:\\files\\New File.txt", true);

            //if (!fileInfo.Exists)
            //{
            //    fileInfo.Delete();
            //}

            //Console.WriteLine($"File name: {fileInfo.Name}");
            //Console.WriteLine($"Full name: {fileInfo.FullName}");
            //Console.WriteLine($"Length: {fileInfo.Length}");
            //Console.WriteLine($"Extionsion: {fileInfo.Extension}");
            //Console.WriteLine($"Directory: {fileInfo.Directory}");
            //Console.WriteLine($"Directory name: {fileInfo.DirectoryName}");
            //Console.WriteLine($"Creation time: {fileInfo.CreationTime}");
            //Console.WriteLine($"Last write time: {fileInfo.LastWriteTime}");
            //Console.WriteLine($"Last access time: {fileInfo.LastAccessTime}");

            #endregion

            #region Homework
            Menu();


            // 1. Yangi papka yaratish
            // 2. Papkani o'chirish
            // 3. Xozirgi (path) ichidagi barcha papkalarni ekranga chiqarish
            // 4. Xozirgi (path) ichidagi barcha papkalarni va barcha papkalarni
            // ichidagi papkalarni ekranga chiqarish
            // 5. Yangi file yaratish
            // 6. Fileni o'chirish
            // 7. Xozirgi (path) ichidagi barcha fayllarni ekranga quyidagi ma'lumotlari bilan chiqarish:
            // File nomi
            // Qachon yaratilgani
            // Ichidagi tekstni uzunligi
            // fileni formati
            // 8. Xozirgi (path) va uning ichidagi barcha papkalarni ichidagi fayllrani ekranga chiqarish
            // 9. Xozirgi (path) ni boshqa papkaga o'zgartirish. Misol uchun
            // Dastur boshlanganida asosiy papka C:\\Files\\Notes bo'ladi
            // Foydalanuvchi 5. Create File - operatsiyasini tanlad "new" kirg'azsa
            // C:\\Files\\Notes papkasida "new.txt" nomli fayl yaralishi kerak.
            // Foydalanuvchi 9 ni kiritib "New Folder" desa, agarda shu nomli papka "C:\\Files\\Notes"
            // papkasida mavjud bo'lsa, shu papka asosida keyingi safar operatsiylar bajariladi, agar mavjud
            // bo'lmasa ekranga "Directory does not exist" xatosi chiqariladi.
            // Demak, "New Folder" papkasiga ko'chgandan keying, foydalanuvchi 5chi operatsiyani tanlab,
            // "test" kirg'azsa, C:\\Files\\Notes\\New Folder ichida "test.txt" degan fayl yaratilishi kerak.
            Main(args);

            #endregion
        }
        static void Menu()
        {
            Console.WriteLine("Menu : ");
            Console.WriteLine("1. Create Directory    2. Delete Directory    3. Show All Folders    4. Show All Folders with children");
            Console.WriteLine("5. Create File         6. Delete File         7. Show All Files      8. Show All Files in Directory with children");
            Console.WriteLine("9. Change current directory    10. Return to parent directory    11.Read File");
            Console.WriteLine("12.Write File    13.File details    14.Encode file");

            Console.Write("Choose the category : ");

            int menu = 0;

            try
            {
                menu = int.Parse(Console.ReadLine());
            }
            catch (Exception) { }

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
                case 10 : BackToParentDirectory();          break;
                case 11: ReadFile();                        break;
                case 12: FileWrite();                       break;
                case 13: DisplayInfoFile();                 break;
                case 14: Encode();                          break;
            }

        }
        static void CreateDirectory()
        {
            Console.Write("Enter name directory : ");
            
            string nameDirectory = Console.ReadLine();

            Directory.CreateDirectory($"{path}\\{nameDirectory}");
        }
        static void DeleteDirectory()
        {
            Console.Write("Enter name directory : ");

            string nameDirectory = Console.ReadLine();

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

            string nameFile= Console.ReadLine();

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
            string nameFile = Console.ReadLine();

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

            if (Directory.Exists(nameDirectory))
            {
                path += "\\" + nameDirectory;
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

            string fileName = Console.ReadLine();
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
            }
        }
        static void FileWrite()
        {
            Console.WriteLine("Enter file name or path");

            string fileName = Console.ReadLine();

            fileName = path + "\\" + fileName + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found!");
                Console.WriteLine("Do you want create new file ? 1.Yes    2.No");
                
                if (int.Parse(Console.ReadLine()) != 1)
                {
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter(fileName,true))
            {
                Console.Write("Enter the text: ");

                string input = Console.ReadLine();

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
        static void Encode()
        {
            Console.WriteLine("Enter filen name or path");

            string fileName = Console.ReadLine();
            fileName = "\\" + fileName + ".txt";

            if (!File.Exists(path + fileName))
            {
                Console.WriteLine("File not found!");
                return;
            }
            List<int> realText = new List<int>();

            using (StreamReader reader = new StreamReader(path + fileName))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                int output = reader.Read();

                while (output != -1)
                {
                    realText.Add(output);
                    Console.Write(Convert.ToChar(output));
                    output = reader.Read();
                }

                Console.ResetColor();
            }
            //// KEY = 11 SEZR CODE 
            for(int i=0; i < realText.Count; i++)
            {
                realText[i] += 11;
            }

            string resultCode = "";

            foreach (int number in realText)
            {
                if(number < 0)
                {
                    continue;
                }
                resultCode += Convert.ToChar(number);
               
                Console.Write(Convert.ToChar(number));
            }

            using (StreamWriter writer = new StreamWriter(path + fileName, false))
            {
                writer.WriteLine(resultCode);
            }
        }
    }
}