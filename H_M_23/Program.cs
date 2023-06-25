using H_M_23;

DirectoryInfo r = new DirectoryInfo(Directory.GetCurrentDirectory());
r.CreateSubdirectory("TxtFiles");
StaticClass.CreateNewTxtFiles(10);
StaticClass.AddTextToTxtFiles("Hello World!!!");


