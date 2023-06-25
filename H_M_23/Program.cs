using H_M_23;


//string folder = "D:\\Study\\.Net(Najot)\\C#\\H_M_23\\TxtFiles\\test.txt";
//var r = new StreamWriter(folder, false, Encoding.UTF8);
//r.WriteLine("Hello11");
//r.Close();


//FileStream f = new FileStream("test.txt",FileMode.Create);
//Console.WriteLine("Nechta file yaratasiz?");
//int son = int.Parse(Console.ReadLine());
//Console.WriteLine("Matn kiriting");
//string matn = Console.ReadLine();
//StaticClass.CreateNewTxtFiles(son);
//StaticClass.AddTextToTxtFiles(matn);



StaticClass.CreateNewTxtFiles(10);
StaticClass.AddTextToTxtFiles("Hello World!!!");