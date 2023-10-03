using System.Text;

namespace Lesson09
{
    internal class Program
    {
        static byte[] array;
        static void Main(string[] args)
        {
            #region Create local folder

            string path =
                "C:\\Users\\Miraziz_Khidoyatov\\Documents\\Pdp\\G4\\Module-03\\Lesson09\\Lesson09\\files";

            Directory.CreateDirectory(path);

            string fileName = $"{path}\\data.dat";
            string personsFile = $"{path}\\person.dat";

            File.Create(fileName).Close();

            #endregion

            #region Binary Writer

            //string input = Console.ReadLine();

            //using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    using (BinaryWriter writer = new BinaryWriter(stream))
            //    {
            //        writer.Write(input ?? "Empty value");
            //    }
            //}

            //using (FileStream stream = new FileStream(personsFile, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    Person person = new Person()
            //    {
            //        Id = 5,
            //        FullName = "John Doe"
            //    };

            //    using (BinaryWriter writer = new BinaryWriter(stream))
            //    {
            //        writer.Write(person.Id);
            //        writer.Write(person.FullName);
            //    }
            //}

            #endregion

            #region Binary Reader

            //using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            //{
            //    using (BinaryReader reader = new BinaryReader(stream))
            //    {
            //        int value = reader.Read();
            //        while (value > 0)
            //        {
            //            Console.WriteLine(Convert.ToChar(value));
            //            Console.WriteLine(value);
            //            value = reader.Read();
            //        }
            //    }
            //}

            //using (FileStream stream = new FileStream(personsFile, FileMode.Open, FileAccess.Read))
            //{
            //    using (BinaryReader reader = new BinaryReader(stream))
            //    {

            //        int id = reader.ReadInt32();
            //        string name = reader.ReadString();

            //        Console.WriteLine($"Id: {id}, Name: {name}");
            //    }
            //}

            #endregion

            #region Console Stream

            //ConsoleStream stream = new ConsoleStream();
            //string text = "Hello world, writing";
            //byte[] bytes = Encoding.UTF8.GetBytes(text);
            //stream.Write(bytes, 0, text.Length);

            //Console.WriteLine();

            //byte[] result = new byte[text.Length];
            //stream.Read(result, 0, text.Length);

            //string output = Encoding.UTF8.GetString(result);
            //Console.WriteLine(output);

            //using (Stream stream = new ConsoleStream())
            //{
            //    using (CustomBinaryWriter writer = new CustomBinaryWriter(stream))
            //    {
            //        writer.Write("Hello, World");
            //    }
            //}

            //using (Stream stream = new ConsoleStream())
            //{
            //    using (CustomBinaryWriter reader = new CustomBinaryWriter(stream))
            //    {
            //        string output = reader.Read();
            //        Console.WriteLine(output);
            //    }
            //}

            #endregion

            #region Custom Stream Reader/Writer

            //using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            //{
            //    using (CustomBinaryWriter writer = new CustomBinaryWriter(stream))
            //    {
            //        writer.Write("Hell, World");
            //    }
            //}

            //using (FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate))
            //{
            //    using (CustomBinaryWriter writer = new CustomBinaryWriter(stream))
            //    {
            //        Console.WriteLine(writer.Read());
            //    }
            //}

            // using (NetworkStream ns = new NetworkStream(new Socket(new SafeSocketHandle())))
            //{
            //    using (CustomBinaryWriter writer = new CustomBinaryWriter(ns))
            //    {

            //    }
            //}

            #endregion
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FullName { get; set; }
    }

    class CustomBinaryWriter : IDisposable
    {
        public Stream FileStream { get; set; }

        public CustomBinaryWriter(Stream fileStream)
        {
            FileStream = fileStream;
        }

        public void Write(string value)
        {
            ArgumentNullException.ThrowIfNull(value);

            byte[] bytes = ConvertToBytes(value);

            FileStream.Write(bytes, 0, bytes.Length);
        }

        public string Read()
        {
            byte[] bytes = new byte[FileStream.Length];

            FileStream.Read(bytes, 0, bytes.Length);

            return ConvertToString(bytes);
        }

        protected byte[] ConvertToBytes(string value) => Encoding.UTF8.GetBytes(value);

        protected string ConvertToString(byte[] bytes) => Encoding.UTF8.GetString(bytes);

        public void Dispose()
        {

        }
    }

    class ConsoleStream : Stream
    {
        public override bool CanRead => throw new NotImplementedException();

        public override bool CanSeek => throw new NotImplementedException();

        public override bool CanWrite => throw new NotImplementedException();

        public override long Length => "Hello, World".Length;

        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Flush()
        {
            Console.WriteLine("flush");
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            ArgumentNullException.ThrowIfNull(buffer);

            if (offset < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(offset));
            }

            if (count > buffer.Length)
            {
                throw new ArgumentNullException(nameof(count));
            }

            if (count < 0)
            {
                return;
            }

            for (int i = offset; i < count + offset; i++)
            {
                Console.Beep();
                Thread.Sleep(100);
                Console.Write(buffer[i]);
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            string str = "Hello, World";
            int strCounter = 0;

            for (int i = offset; i < count + offset; i++)
            {
                buffer[i] = Convert.ToByte(str[strCounter++]);
            }

            return -1;
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }
    }

    class CustomMemoryStream : Stream
    {
        public override bool CanRead => throw new NotImplementedException();

        public override bool CanSeek => throw new NotImplementedException();

        public override bool CanWrite => throw new NotImplementedException();

        public override long Length => throw new NotImplementedException();

        public override long Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public CustomMemoryStream(byte[] array)
        {

        }

        public override void Flush()
        {
            throw new NotImplementedException();
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            throw new NotImplementedException();
        }

        public override long Seek(long offset, SeekOrigin origin)
        {
            throw new NotImplementedException();
        }

        public override void SetLength(long value)
        {
            throw new NotImplementedException();
        }


    }

}