using ConsoleApp2;
using System.Collections;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text;

//Calculator calculator = new Calculator();

//CalcDelegate<double> calcDelegate = new CalcDelegate<double>(calculator.Mult);
//calcDelegate = Calculator.SubDouble; //new
//calcDelegate += calculator.AddDouble;
//calcDelegate += Calculator.Div;

//foreach (CalcDelegate<double> i in calcDelegate.GetInvocationList())
//{
//    Console.WriteLine(i(2,3));
//}

//VoidTestDelegate testDelegate = Calculator.StaticVoidTest;

//Console.WriteLine(calcDelegate(5, 5));
//testDelegate("asd", 3);

//VoidStringDelegate voidStringDelegate = Calculator.StaticStringTest;
//VoidBoolDelegate booleanDelegate = Calculator.StaticBoolTest;
//GenericDelegate<int> genericDelegate = Calculator.StaticGenericTest;

//Action<string, int, double> action = Calculator.TestAction1;
//action += Calculator.TestAction2;

//action("3", 4, 5.6);


//Func<string, int, double, string> func = Calculator.TestFunc;
//Console.WriteLine(func("a",1,2.5));

//Predicate<int> predicate = Calculator.TestPredicate;
//Console.WriteLine(predicate(12));
//Console.WriteLine(predicate(-12));

//Action<string, int> action = Calculator.Action1;
//action += Calculator.Action2;
//action += Calculator.Action3;

//foreach (Action<string, int> i in action.GetInvocationList())
//{
//    i("a", 3);
//}

//Func<int, int, int, string> func = Calculator.Func1;
//func += Calculator.Func2;
//func += Calculator.Func3;

//foreach (Func<int, int, int, string> i in func.GetInvocationList())
//{
//    Console.WriteLine(i(1, 2, 5));
//}

//Predicate<bool> predicate = Calculator.Predicate1;
//predicate += Calculator.Predicate2;
//predicate += Calculator.Predicate3;
//predicate += delegate (bool a) { return !a; };
//predicate += (bool a) => { return !a; };

//foreach (Predicate<bool> i in predicate.GetInvocationList())
//{
//    Console.WriteLine(i(true));
//}


//List<Student> students = new List<Student>
//{
//    new Student{Id=1,Name="Name1"},
//    new Student{Id=2,Name="Name2"},
//    new Student{Id=3,Name="Name3"},
//    new Student{Id=4,Name="Name4"},
//    new Student{Id=5,Name="Name5"},
//};

//students.ForEach(delegate (Student s)
//{
//    Console.WriteLine(s);
//});

//ArrayList Array = new ArrayList();

//students.ForEach(s =>
//{
//    Array.Add(new
//    {
//        Name = s.Name,
//        Age = s.Age
//    });
//});


//var str = new
//{
//    Name = students[0].Name,
//    Age = students[0].Age
//};

//Console.WriteLine(str);

//Teacher teacher = new Teacher();
//foreach (Student student in students)
//{
//    teacher.examEvent += student.ExamStudent;
//}
//teacher.ExamTeacher("Task");

//teacher.examEvent += delegate (string task)
//{
//    Console.WriteLine(task);
//};
//teacher.ExamTeacher("Task1");

//string str1 = "saasd.asd,asdsad asd";
//int count = str1.NumberWords();
//Console.WriteLine(count);

//List<Sender> senders = new List<Sender>
//{
//    new Sender{Title="Title1"},
//    new Sender{Title="Title2"},
//    new Sender{Title="Title3"},
//    new Sender{Title="Title4"}
//};

//Email email = new Email();
//foreach (Sender sender in senders)
//{
//    email.GetMail += sender.GetMail;
//}
//email.Send("IT");


//int[] arrayList = { 1, 2, 3, 4, 10, 8, 7, 6, 9, 5};

//IEnumerable<int> query = from i in arrayList
//                  where i % 2 == 0
//                  select i;

//arrayList.Where(a => a % 2 == 0).Select(a => a);

//foreach (var i in query)
//{
//    Console.Write($"{i}\t");
//}

//IEnumerable<int> query1 = from i in arrayList
//                         where i % 2 == 0
//                         orderby i ascending
//                         select i;

//Console.WriteLine();

//foreach (var i in query1)
//{
//    Console.Write($"{i}\t");
//}

//arrayList.OrderBy(i => i).Where(a => a % 2 == 0).Select(a => a);

//IEnumerable<Student> students = new List<Student>
//{
//    new Student{Id=1,Name="Name1"},
//    new Student{Id=2,Name="Name2"},
//    new Student{Id=3,Name="Name3"},
//    new Student{Id=4,Name="Name4"},
//    new Student{Id=5,Name="Name5"}
//};

//Console.WriteLine();

//students.OrderBy(s => s.Id).Where(s => s.Id >= 3).Select(s => s.Name);

//string[] s = { "sada sd", "sa d asd sadasff", "sad" };

//IEnumerable<string> query3 = from i in s
//                          let words = i.Split()
//                          from w in words
//                          where w.Count() > 3
//                          select w;

//foreach (var i in query3)
//{
//    Console.Write($"{i}" + "\t");
//}

//var avarage = arrayList.Average();

//var studentsIdAverage = students.Select(students => students.Id).Average();

//double[] arrayList = { 1.2, 2.3, 3.5, 4.7, 10.1, 8.2, 7.3, 6.4, 9.5, 5.6};

//var sorted = arrayList.OrderBy(a => a);
//foreach (var i in sorted)
//    Console.Write($"{i}\t");

//Console.WriteLine();
//var BiggerAvg = arrayList.Where(a => a > arrayList.Average());
//foreach (var i in BiggerAvg)
//    Console.Write($"{i}\t");

//Console.WriteLine();
//var nepar = arrayList.Where(a => a % 2 != 0);
//foreach(var i in nepar)
//    Console.Write($"{i}\t");

//List<Car> cars = new List<Car>
//{
//    new Car{Number = "123",Model="A",Year = 2000},
//    new Car{Number = "456",Model="B",Year = 2010},
//    new Car{Number = "789",Model="C",Year = 2020},
//    new Car{Number = "111",Model="C",Year = 2000},
//};

//var SameYear = cars.Where(a => a.Year == 2000);
//var Model = cars.Where(a => a.Model.Contains("A") || a.Model.Contains("B"));
//var Number = cars.Select(a => a.Number);
//var NumAndModel = cars.Select(a => new {Number = a.Number,Model = a.Model});


//string emailPattern = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";

//Regex regex = new Regex(emailPattern);
//string email = Console.ReadLine();

//Console.WriteLine(regex.IsMatch(email)? "Email is correct" : "Email is incorrect");


//-------------------------------Binary Serializable------------------//

//Person person = new Person(123) { FirstName = "first", LastName = "last", Age = 12 };
//BinaryFormatter formatter = new BinaryFormatter();

//using (Stream stream = File.Create("test.bin"))
//{
//    formatter.Serialize(stream, person);
//}

//Person p = null;

//using (Stream stream = File.OpenRead("test.bin"))
//{
//    p = (Person)formatter.Deserialize(stream);
//}

//Console.WriteLine(p);

////-------------------------------Soap Serializable------------------//

//SoapFormatter soapFormatter = new SoapFormatter();

//using (Stream stream = File.Create("test.soap"))
//{
//    soapFormatter.Serialize(stream, person);
//}

//p = null;

//using (Stream stream = File.OpenRead("test.soap"))
//{
//    p = (Person)soapFormatter.Deserialize(stream);
//}

//Animal animal = new Animal(123) { Name = "dog", Age = 5, Food = new List<string>{ "meat", "bones" } };
//BinaryFormatter formatter = new BinaryFormatter();

//using (Stream stream = File.Create("animal.bin"))
//{
//    formatter.Serialize(stream, animal);
//}

//Animal a = null;

//using (Stream stream = File.OpenRead("animal.bin"))
//{
//    a = (Animal)formatter.Deserialize(stream);
//}

//Console.WriteLine(a);

//SoapFormatter soapFormatter = new SoapFormatter();

//using (Stream stream = File.Create("animal.soap"))
//{
//    soapFormatter.Serialize(stream, animal);
//}

//a = null;

//using (Stream stream = File.OpenRead("animal.soap"))
//{
//    a = (Animal)soapFormatter.Deserialize(stream);
//}

//Student1 student1 = new Student1(123, "student", 20, "UKU");
//XmlSerializer xmlSerializer = new XmlSerializer(typeof(Student1));

//using (Stream stream = File.Create("test.xml"))
//{
//    xmlSerializer.Serialize(stream, student1);
//}

//using (XmlWriter writer = XmlWriter.Create("test.xml", new XmlWriterSettings { Indent = true }))
//{
//    xmlSerializer.Serialize(writer, student1);
//}

//Student1 s = null;

//using (Stream stream = File.OpenRead("test.xml"))
//{
//    s = (Student1)xmlSerializer.Deserialize(stream);
//}

//Console.WriteLine(s);

//List<Student1> students = new List<Student1>
//{
//    new Student1(123, "student1", 20, "UKU"),
//    new Student1(456, "student2", 22, "UKU"),
//    new Student1(789, "student3", 21, "UKU"),
//    new Student1(010, "student4", 23, "UKU")
//};

//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student1>));

//using (XmlWriter writer = XmlWriter.Create("ListStudents.xml", new XmlWriterSettings { Indent = true }))
//{
//    xmlSerializer.Serialize(writer, students);
//}

//List<Student1> s = null;

//using (Stream stream = File.OpenRead("ListStudents.xml"))
//{
//    s = (List<Student1>)xmlSerializer.Deserialize(stream) as List<Student1>;
//}

//foreach (var i in students)
//{
//    Console.WriteLine(i);
//}


//List<Car1> cars = new List<Car1>
//{
//    new Car1(1,2010,"a",Mark.Audi),
//    new Car1(2,2011,"b",Mark.Mercedes),
//    new Car1(3,2012,"c",Mark.Bmw),
//    new Car1(4,2013,"d",Mark.Ford)
//};

//XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Car1>));

//using (XmlWriter writer = XmlWriter.Create("ListCars.xml", new XmlWriterSettings { Indent = true }))
//{
//    xmlSerializer.Serialize(writer, cars);
//}

//List<Car1> s = null;

//using (Stream stream = File.OpenRead("ListCars.xml"))
//{
//    s = (List<Car1>)xmlSerializer.Deserialize(stream);
//}

//foreach (var i in cars)
//{
//    Console.WriteLine(i);
//}

//string jsonString = JsonSerializer.Serialize<List<Car1>>(cars,new JsonSerializerOptions { WriteIndented = true});
//Console.WriteLine(jsonString);

//using (Stream stream = File.Create("test.json")) { }
//    File.WriteAllText("test.json", jsonString);

//Console.WriteLine(File.ReadAllText("test.json"));

//List<Car1> cars1 = JsonSerializer.Deserialize<List<Car1>>(jsonString);
//Console.WriteLine(string.Join(",",cars1));


//XmlTextWriter writer = null;

//try
//{
//    writer = new XmlTextWriter("Cars.xml",Encoding.Unicode);
//    writer.Formatting = Formatting.Indented;

//    writer.WriteStartDocument();
//    writer.WriteStartElement("Cars");

//    writer.WriteStartElement("Car");
//    writer.WriteAttributeString("Image","test.jpeg");

//    writer.WriteElementString("Manufaturer", "BMW");
//    writer.WriteElementString("Model", "X5");
//    writer.WriteElementString("Year", "2018");
//    writer.WriteElementString("Color", "Black");
//    writer.WriteElementString("Speed", "220");

//    writer.WriteEndElement();

//    writer.WriteEndElement();
//    writer.WriteEndDocument();
//}
//catch
//{

//}
//finally
//{
//    if (writer != null) 
//    {
//        writer.Dispose();
//        writer.Close();
//    }
//}


//XmlTextWriter writer = null;

//try
//{
//    writer = new XmlTextWriter("House.xml", Encoding.Unicode);
//    writer.Formatting = Formatting.Indented;

//    writer.WriteStartDocument();
//    writer.WriteStartElement("House");

//    writer.WriteStartElement("Apartment");
//    writer.WriteAttributeString("Number", "1");

//    writer.WriteElementString("Rooms", "1");
//    writer.WriteElementString("People", "1");
//    writer.WriteElementString("Price", "20000");

//    writer.WriteEndElement();

//    writer.WriteStartElement("Apartment");
//    writer.WriteAttributeString("Number", "2");

//    writer.WriteElementString("Rooms", "2");
//    writer.WriteElementString("People", "2");
//    writer.WriteElementString("Price", "30000");

//    writer.WriteEndElement();

//    writer.WriteStartElement("Apartment");
//    writer.WriteAttributeString("Number", "3");

//    writer.WriteElementString("Rooms", "3");
//    writer.WriteElementString("People", "3");
//    writer.WriteElementString("Price", "40000");

//    writer.WriteEndElement();

//    writer.WriteEndElement();
//    writer.WriteEndDocument();
//}
//catch
//{

//}
//finally
//{
//    if (writer != null)
//    {
//        writer.Dispose();
//        writer.Close();
//    }
//}

XmlDocument document = new XmlDocument();
document.Load("Cars.xml");
//Output(document.DocumentElement);

XmlNode root = document.DocumentElement;

XmlNode bike = document.CreateElement("Motobike");
XmlNode elem1 = document.CreateElement("Manafacture");
XmlNode elem2 = document.CreateElement("Model");
XmlNode elem3 = document.CreateElement("Year");
XmlNode elem4 = document.CreateElement("Color");
XmlNode elem5 = document.CreateElement("Speed");

XmlNode text1 = document.CreateTextNode("BMW");
XmlNode text2 = document.CreateTextNode("C12");
XmlNode text3 = document.CreateTextNode("2003");
XmlNode text4 = document.CreateTextNode("Green");
XmlNode text5 = document.CreateTextNode("179");

elem1.AppendChild(text1);
elem2.AppendChild(text2);
elem3.AppendChild(text3);
elem4.AppendChild(text4);
elem5.AppendChild(text5);

bike.AppendChild(elem1);
bike.AppendChild(elem2);
bike.AppendChild(elem3);
bike.AppendChild(elem4);
bike.AppendChild(elem5);

root.AppendChild(bike);
document.Save("Cars.xml");
Output(document.DocumentElement);

Console.WriteLine("------------------------------------------------");
XmlTextReader reader = new XmlTextReader("Cars.xml");
reader.WhitespaceHandling = WhitespaceHandling.None;

while (reader.Read())
{
    Console.WriteLine($"type: {reader.NodeType}\t Name: {reader.Name}\t Value: {reader.Value}");

    if (reader.AttributeCount > 0)
        while (reader.MoveToNextAttribute())
            Console.WriteLine($"type: {reader.NodeType}\t Name: {reader.Name}\t Value: {reader.Value}");
}

void Output(XmlNode node)
{
    Console.WriteLine($"type: {node.NodeType}\t Name: {node.Name}\t Value: {node.Value}");

    if (node.Attributes != null)
        foreach (XmlAttribute attr in node.Attributes)
        {
            Console.WriteLine($"Type: {attr.NodeType}\t Name: {attr.Name}\t Value: {attr.Value}");
        }

    if (node.HasChildNodes)
        foreach (XmlNode childNode in node.ChildNodes)
        {
            Output(childNode);
        }
}

//XmlDocument document = new XmlDocument();
//document.Load("House.xml");

//XmlNode root = document.DocumentElement;

//root.RemoveChild(root.FirstChild);
//root.RemoveChild(root.FirstChild);

//XmlNode newApartment1 = document.CreateElement("newApartment1");
//XmlNode elem11 = document.CreateElement("Rooms");
//XmlNode elem21 = document.CreateElement("People");
//XmlNode elem31 = document.CreateElement("Price");

//XmlNode text11 = document.CreateTextNode("1");
//XmlNode text21 = document.CreateTextNode("1");
//XmlNode text31 = document.CreateTextNode("1");

//elem11.AppendChild(text11);
//elem21.AppendChild(text21);
//elem31.AppendChild(text31);

//newApartment1.AppendChild(elem11);
//newApartment1.AppendChild(elem21);
//newApartment1.AppendChild(elem31);

//root.AppendChild(newApartment1);

//XmlNode newApartment2 = document.CreateElement("newApartment2");
//XmlNode elem12 = document.CreateElement("Rooms");
//XmlNode elem22 = document.CreateElement("People");
//XmlNode elem32 = document.CreateElement("Price");

//XmlNode text12 = document.CreateTextNode("2");
//XmlNode text22 = document.CreateTextNode("2");
//XmlNode text32 = document.CreateTextNode("2");

//elem12.AppendChild(text12);
//elem22.AppendChild(text22);
//elem32.AppendChild(text32);

//newApartment2.AppendChild(elem12);
//newApartment2.AppendChild(elem22);
//newApartment2.AppendChild(elem32);

//root.AppendChild(newApartment2);

//XmlNode newApartment3 = document.CreateElement("newApartment3");
//XmlNode elem13 = document.CreateElement("Rooms");
//XmlNode elem23 = document.CreateElement("People");
//XmlNode elem33 = document.CreateElement("Price");

//XmlNode text13 = document.CreateTextNode("3");
//XmlNode text23 = document.CreateTextNode("3");
//XmlNode text33 = document.CreateTextNode("3");

//elem13.AppendChild(text13);
//elem23.AppendChild(text23);
//elem33.AppendChild(text33);

//newApartment3.AppendChild(elem13);
//newApartment3.AppendChild(elem23);
//newApartment3.AppendChild(elem33);

//root.AppendChild(newApartment3);
//document.Save("House.xml");

//Console.WriteLine("------------------------------------------------");
//XmlTextReader reader = new XmlTextReader("House.xml");
//reader.WhitespaceHandling = WhitespaceHandling.None;

//while (reader.Read())
//{
//    Console.WriteLine($"type: {reader.NodeType}\t Name: {reader.Name}\t Value: {reader.Value}");

//    if (reader.AttributeCount > 0)
//        while (reader.MoveToNextAttribute())
//            Console.WriteLine($"type: {reader.NodeType}\t Name: {reader.Name}\t Value: {reader.Value}");
//}