using System.Text;

namespace Lesson08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region File Stream

            string input = Console.ReadLine() ?? "";

            string currentDirectory = Directory.GetCurrentDirectory();
            string path = Directory.GetParent(currentDirectory).Parent.Parent.FullName;

            // files Papka bo'lmasa yaratish
            if (!Directory.Exists($"{path}\\files"))
            {
                Directory.CreateDirectory($"{path}\\files");
            }

            string filePath = $"{path}\\files\\note.dat";

            byte[] bytes = GetBytes(input);

            // Agar fayl mavjud bo'lsa uni ichidagi ma'lumotni ochirib,
            // byte massivini yozish.
            using (FileStream fs = new(filePath, FileMode.OpenOrCreate))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            Console.WriteLine();

            // Faylni ochishga urunadi, agarda fayl mavjud bo'lmasa
            // FileNotFoundException yuzaga keladi.
            // Faylni ichidagi barcha baytlarni, outputBytes massiviga
            // 0chi indexidan boshlab, uzunlicha elementlarni o'qiydi.
            // O'qilgan massivni string toifasiga aylantirib, ekranga chiqaradi.
            using (FileStream fs = new(filePath, FileMode.Open))
            {
                byte[] outputBytes = new byte[fs.Length];
                fs.Read(outputBytes, 0, outputBytes.Length);

                string output = GetString(outputBytes);

                Console.WriteLine($"Output text: {output}");
            }

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
            using (FileStream fs = new(filePath, FileMode.Open))
            {
                fs.Seek(0, SeekOrigin.Begin);

                byte[] outputBytes = new byte[fs.Length];
                fs.Read(outputBytes, 0, outputBytes.Length / 2);

                string output = GetString(outputBytes);
                Console.WriteLine($"Text from file: {output}");
            }

            // Faylni ochishga urunadi, agarda fayl mavjud bo'lmasa
            // FileNotFoundException yuzaga keladi.
            // Faylni ichidagi barcha baytlarni, outputBytes massiviga
            // 0 indexidan boshlab, berilgan faylni yarimidan boshlab
            // uzunligini yarimicha elementlarni o'qiydi.
            // O'qilgan massivni string toifasiga aylantirib, ekranga chiqaradi.
            using (FileStream fs = new(filePath, FileMode.Open))
            {
                fs.Seek(fs.Length / -2, SeekOrigin.End);

                byte[] outputBytes = new byte[fs.Length];
                fs.Read(outputBytes, 0, outputBytes.Length / 2);

                string textFromFile = GetString(outputBytes);
                Console.WriteLine($"Text from file: {textFromFile}");
            }

            #endregion
        }

        static void UpdateArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array[i] * 10;
            }
        }

        static byte[] GetBytes(string input) => Encoding.Default.GetBytes(input);

        static string GetString(byte[] bytes) => Encoding.Default.GetString(bytes);
    }
}