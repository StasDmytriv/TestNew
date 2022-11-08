using ConsoleApp1;
using ConsoleApp1.Interface;
using System.Collections;
using System.Text;

//Employee emp = new Employee("John", "Nate", 12000);

//Employee[] empl = new Employee[]
//{
//    emp,
//    new Manager("manager","m",15000,"IBM"),
//    new Scientist("scientist","s",20000,"left"),
//    new Mentor("mentor","m",30000,"junior")
//};

//foreach (var item in empl)
//{
//    item.Print();
//}

//Point point = new Point
//{
//    X = 12,
//    Y = 23
//};

//Point point1 = new Point
//{
//    X = 56,
//    Y = 7
//};

//Console.WriteLine();
//Console.WriteLine(point++);
//Console.WriteLine(++point);

//Console.WriteLine(point--);
//Console.WriteLine(--point);

//Console.WriteLine(-point);
//Console.WriteLine(+point);

//Console.WriteLine();
//point += point1;
//Console.WriteLine(point);
//point -= point1;
//Console.WriteLine(point);
//point *= point1;
//Console.WriteLine(point);
//point /= point1;
//Console.WriteLine(point);


//Drob d1 = new Drob(1, 2);
//Drob d2 = new Drob(3, 4);
//Console.WriteLine(d1 + d2);
//Console.WriteLine();
//Console.WriteLine(d1 - d2);
//Console.WriteLine();
//Console.WriteLine(d1 * d2);
//Console.WriteLine();
//Console.WriteLine(d1 / d2);


//Drob f = new Drob(3, 4);
//int a = 10;
//Drob f1 = f * a;
//Console.WriteLine(f1);  
//Drob f2 = a * f;
//Console.WriteLine(f2);
//double d = 1.5;
//Drob f3 = f + d;
//Console.WriteLine(f3);


//laptop[] laptops = new laptop[]
//{
//    new laptop{Name = "Apple",Price=45000},
//    new laptop{Name = "Asus",Price=52000},
//    new laptop{Name = "Dell",Price=23000},
//    new laptop{Name = "Lenovo",Price=20000},
//};

//Shop shop = new Shop(laptops);
//Console.WriteLine(shop[2]);
//shop[2] = new laptop { Name = "Acer", Price = 27000 };
//Console.WriteLine(shop[2]);

//int[,] arr = new int[3, 4];
//Shop shop1 = new Shop(arr);

//Person person = new Person("one","two","three","four","five");
//person.Name = "Test";
//Console.WriteLine(person.Name);
//Console.WriteLine(person[4]);

//IAnimal[] animal = new IAnimal[]
//{
//    new Lion{Name="Lion"},
//    new Snake{Name="Snake"},
//    new Giraffe{Name="Giraffe"}
//};

//Zoo zoo = new Zoo { Animals = animal };
//zoo.Say();
//zoo.Food();

//Auditory auditory = new Auditory();
//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//auditory.Sort();
//Console.WriteLine();

//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//Exception
//MyException exception = new MyException();
//Console.WriteLine(exception.Message);

//MyException exception1 = new MyException("New exception");
//Console.WriteLine(exception.Message);

//try
//{
//	new Exception();
//    Console.WriteLine("try");
//}
//catch (Exception)
//{
//    Console.WriteLine("catch");
//}
//finally
//{
//    Console.WriteLine("finally");
//}
//Console.WriteLine("end");


//ArrayList arraylist = new ArrayList();
//Console.WriteLine(arraylist.Capacity);
//arraylist.Add(1);
//arraylist.Add("asd");
//Console.WriteLine(arraylist.Capacity);
//Console.WriteLine(arraylist.Count);
//arraylist.AddRange(new int[] { 1, 2, 3, 4, 5 });
//Console.WriteLine(arraylist.Capacity);
//Console.WriteLine(arraylist.Count);

//ArrayList arraylist1 = new ArrayList(5);


//Point2D<int> point = new Point2D<int>();
//Console.WriteLine(point);


//Uterators uterators = new Uterators(45);
//foreach (var item in uterators.GetNumber())
//{
//    Console.WriteLine(uterators);
//}

//string path = ".\\test.txt";
//using (FileStream stream = new FileStream(path,FileMode.OpenOrCreate,FileAccess.ReadWrite,FileShare.ReadWrite))
//{
//    string text = "text for test file";
//    byte[] bytes = Encoding.Default.GetBytes(text);
//    stream.Write(bytes, 0, bytes.Length);
//}

//string pathBin = ".\\test.bin";
//FileStream file = null;

//using (FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read))
//{
//    byte[] bytes = new byte[(int)stream1.Length];
//    stream1.Read(bytes, 0, bytes.Length);
//    Console.WriteLine(Encoding.Default.GetString(bytes));
//}

//try
//{
//    file = new FileStream(pathBin, FileMode.OpenOrCreate, FileAccess.ReadWrite);
//    string text = "text bin";
//    byte[] bytes = Encoding.Default.GetBytes(text);
//    file.Write(bytes, 0, bytes.Length);
//}
//finally
//{
//    if (file != null)
//    {
//        file.Flush();
//        file.Close();
//    }
//}

//try
//{
//    file = new FileStream(pathBin, FileMode.Open, FileAccess.Read);
//    byte[] bytes = new byte[(int)file.Length];
//    file.Read(bytes, 0, bytes.Length);

//    Console.WriteLine(Encoding.Default.GetString(bytes));
//}
//finally
//{
//    if (file != null)
//    {
//        file.Flush();
//        file.Close();
//    }
//}

//string path = ".\\task1.txt";
//using (FileStream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
//{
//    string text = "text";
//    byte[] bytes = Encoding.Default.GetBytes(text);
//    stream.Write(bytes, 0, bytes.Length);
//}

//using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write))
//{
//    string text = "task";
//    byte[] bytes = Encoding.Default.GetBytes(text);
//    stream.Write(bytes, 0, bytes.Length);
//}

//using (FileStream stream1 = new FileStream(path, FileMode.Open, FileAccess.Read))
//{
//    byte[] bytes = new byte[(int)stream1.Length];
//    stream1.Read(bytes, 0, (int)bytes.Length);
//    Console.WriteLine(Encoding.Default.GetString(bytes));
//}

//using (StreamWriter stream = new StreamWriter(path,true))
//{
//    string str = "text one two three, {0} {1} {2}";
//    stream.WriteLine(str,"1","2","3");
//}

//using (StreamReader reader = new StreamReader(path))
//{
//    Console.WriteLine(reader.ReadToEnd());
//}

//using (FileStream s = new FileStream(pathBin, FileMode.Create))
//{
//    using (BinaryWriter binary = new BinaryWriter(s))
//    {
//        string s1 = "test";
//        int a = 23;
//        double b = 34.5;

//        binary.Write(s1);
//        binary.Write(a);
//        binary.Write(b);
//    }
//}

//using (FileStream s = new FileStream(pathBin, FileMode.Open))
//{
//    using (BinaryReader reader = new BinaryReader(s))
//    {
//        Console.WriteLine(reader.ReadString());
//        Console.WriteLine(reader.ReadInt32());
//        Console.WriteLine(reader.ReadDouble());
//    }
//}


//Directory
//DirectoryInfo

//File
//FileInfo

//string path = ".";
//DirectoryInfo directory = new DirectoryInfo(path);

//Console.WriteLine(directory.FullName);
//Console.WriteLine(directory.CreationTime);

//FileInfo[] fileInfos = directory.GetFiles();
//foreach (FileInfo file in fileInfos)
//{
//    Console.WriteLine(file.FullName);
//    //Console.WriteLine(file.Name);
//    //Console.WriteLine(file.CreationTime);
//    //Console.WriteLine(file.DirectoryName);  
//}

//if (!directory.Exists)
//{
//    directory.Create();
//}

//DirectoryInfo directoryInfo = directory.CreateSubdirectory("SubDir");
//Console.WriteLine(directoryInfo.FullName);


//string s = directory.FullName + @"\testBin{0}.bin";
//for (int i = 0; i < 3; i++)
//{
//    string buff = string.Format(s, i);
//    if (!File.Exists(buff))
//        File.Create(buff);
//}


//string[] files = Directory.GetFiles(directory.FullName,"test*.txt");   
//foreach (string file in files)
//    Console.WriteLine(file);


//DirectoryInfo projDir  = Directory.GetParent(path);
//Console.WriteLine(projDir.Parent);

//if(directory.Exists)
//    directoryInfo.Delete(true);



//string path = @"D:\\itstep\ConsoleApp1\ConsoleApp1\bin\Debug\net6.0";
//DirectoryInfo directory = new DirectoryInfo(path);

//if (!directory.Exists)
//    directory.Create();

//for (int i = 0; i < 3; i++)
//{
//    if (!File.Exists(path + $@"\text{i}.txt"))
//        using (FileStream fs = File.Create(path + $@"\text{i}.txt"));

//    if (!File.Exists(path + $@"\bin{i}.bin"))
//        using (FileStream fs = File.Create(path + $@"\bin{i}.bin"));
//}


//FileW_R fl = new FileW_R(path);
//foreach (var i in fl.GetFilesName())
//{
//    fl.WriteInfoToFile(i, "info");
//}

//fl.GetInfoFromAllFiles();


Calculator calculator = new Calculator();

CalcDelegate calcDelegate = new CalcDelegate(calculator.Mult);
calcDelegate = Calculator.Sub; //new
calcDelegate += calculator.Add;
calcDelegate += Calculator.Div;

foreach (CalcDelegate i in calcDelegate.GetInvocationList())
{
    Console.WriteLine(i);
}