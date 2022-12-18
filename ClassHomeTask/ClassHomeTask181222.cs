Console.WriteLine("Welcome To Code Academy\r\n#GelecekBurada");
CodeAcademy CodeAcademy = new CodeAcademy();
Student Student = new Student();

try
{
CodeAcademy.Question("Adınızı Ve Soyadınızı Daxil Edin:   ");
CodeAcademy.NameSurname(Console.ReadLine(), Console.ReadLine());
CodeAcademy.Question("Tehsil Aldıqınız Qrupun Adını Daxil Edin:  ");
CodeAcademy.GroupName(Console.ReadLine());
CodeAcademy.Question("Topladığınız Balı Daxil Edin");
CodeAcademy.PointQuantity(int.Parse(Console.ReadLine()));
CodeAcademy.Detail();
CodeAcademy.CheckTheScores();
}
catch 
{
    Console.WriteLine("Düzgün Eded Daxil Edin!!!");
    Console.ReadLine(); 
}
    

