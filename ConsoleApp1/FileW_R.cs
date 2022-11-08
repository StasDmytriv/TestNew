using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;

public class FileW_R
{
    public string Path { get; set; }

    public FileW_R(string path)
    {
        Path = path;
    }

    public void GetInfoFromAllFiles()
    {
        if (Directory.Exists(Path))
        {
            foreach (var file in Directory.EnumerateFiles(Path))
            {
                using (StreamReader stream = new StreamReader(file))
                {
                    Console.WriteLine(stream.ReadToEnd());
                }
            }
        }
    }

    public void WriteInfoToFile(string filename,string info)
    {
        if (Directory.Exists(Path))
        {
            if (File.Exists(Path + $@"\{filename}"))
            {
                using (StreamWriter stream = new StreamWriter(Path + $@"\{filename}"))
                {
                    stream.Write(info);
                }
            }
        }
    }

    public string[] GetFilesName()
    {
        if (Directory.Exists(Path))
        {
            FileInfo[] fileInfo = new DirectoryInfo(Path).GetFiles();
            string [] files = new string[fileInfo.Length];

            for (int i = 0; i < files.Length; i++)
            {
                files[i] = fileInfo[i].Name;
            }
            return files;
        }
        throw new DirectoryNotFoundException();
    }

    public void GetFileInfo(string filename)
    {
        FileInfo fileInfo = new FileInfo(Path + $@"\{filename}");

        Console.WriteLine(fileInfo.FullName);
        Console.WriteLine(fileInfo.Name);
        Console.WriteLine(fileInfo.CreationTime);
        Console.WriteLine(fileInfo.DirectoryName);
    }

    public void GetFilesPattern(string pattern)
    {
        foreach (var item in Directory.GetFiles(Path, pattern))
        {
            Console.WriteLine(item);
        }
    }
}
