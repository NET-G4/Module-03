namespace Lesson07
{
    internal class Program
    {
        static string currentDirectory = @"C:\files";
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

            //string path = "C:\\Files";

            //Console.WriteLine("1. Create Directory    2. Delete Directory    3. Show All Folders    4. Show All Folders with children");
            //Console.WriteLine("5. Create File         6. Delete File         7. Show All Files      8. Show All Files in Directory with children");
            //Console.WriteLine("9. Change current directory    10. Return to parent directory");

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

            //Main(args);

            #endregion

            while (true)
            {

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("1. Создать папку");
                Console.WriteLine("2. Удалить папку");
                Console.WriteLine("3. Показать все папки");
                Console.WriteLine("4. Показать все папки с подпапками");
                Console.WriteLine("5. Создать файл");
                Console.WriteLine("6. Удалить файл");
                Console.WriteLine("7. Показать все файлы");
                Console.WriteLine("8. Показать все файлы в текущей папке и подпапках");
                Console.WriteLine("9. Изменить текущую папку");
                Console.WriteLine("0. Выход");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                    continue;
                }

                switch (choice)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
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
                        ShowAllFoldersWithChildren(currentDirectory);
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
                        ShowAllFilesWithChildren(currentDirectory);
                        break;
                    case 9:
                        ChangeCurrentDirectory();
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте еще раз.");
                        break;
                }
            }

        }
        static void CreateDirectory()
        {
            Console.WriteLine("Введите имя папки:");
            string folderName = Console.ReadLine();
            string path = Path.Combine(currentDirectory, folderName);

            if (!Directory.Exists(path))
            {
                Console.Clear();
                try
                {
                    Directory.CreateDirectory(path);
                    Console.WriteLine($"Создано папка по имени {folderName}:");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при создание папки {ex.Message}");
                }
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }
        static void DeleteDirectory()
        {
            Console.Clear();
            Console.WriteLine($"Введите имя папки для удаление:");
            string folderName = Console.ReadLine();
            string path = Path.Combine(currentDirectory, folderName);

            if (Directory.Exists(path))
            {
                try
                {
                    Directory.Delete(path);
                    Console.WriteLine($"Папка {folderName} удалена: ");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при удаление папкиЖ{ex.Message}");
                }
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }
        static void ShowAllFolders()
        {
            Console.Clear();
            if (Directory.Exists(currentDirectory))
            {
                string[] folders = Directory.GetDirectories(currentDirectory);
                Console.WriteLine("Список папки:");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }
        static void ShowAllFoldersWithChildren(string directory)
        {
            Console.Clear();
            Console.WriteLine("Список папки с подпакамиЖ");
            string[] folders = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories);
            foreach (string folder in folders)
            {
                Console.WriteLine(folder);
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }

        static void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Ввидите имя файла:");
            string fileName = Console.ReadLine();
            string path = Path.Combine(currentDirectory);
            if (!File.Exists($"{path}\\{fileName}"))
            {
                try
                {
                    FileStream stream = File.Create($"{path}\\{fileName}");
                    stream.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }
        static void DeleteFile()
        {
            Console.Clear();
            Console.WriteLine("Введите имя файла для удаления:");
            string fileName = Console.ReadLine();
            string path = Path.Combine(currentDirectory, fileName);

            try
            {
                File.Delete(path);
                Console.WriteLine($"Файл '{fileName}' удален.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при удалении файла: {ex.Message}");
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }

        static void ShowAllFiles()
        {
            Console.Clear();
            string[] files = Directory.GetFiles(currentDirectory);
            Console.WriteLine("Список файлов:");
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
            Console.WriteLine("Для продолжение нажмите любую клавишу:");
            Console.ReadKey();
        }
        static void ShowAllFilesWithChildren(string directory)
        {
            Console.WriteLine("Список файлов в текущей папке и подпапках:");
            string[] files = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
        static void ChangeCurrentDirectory()
        {
            Console.WriteLine("Введите путь к новой текущей папке:");
            string newDirectory = Console.ReadLine();
            if (Directory.Exists(newDirectory))
            {
                currentDirectory = newDirectory;
                Console.WriteLine($"Текущая папка изменена на '{currentDirectory}'.");
            }
            else
            {
                Console.WriteLine("Указанной папки не существует.");
            }
        }
    }
}
