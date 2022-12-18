

class CodeAcademy:Student
{

    public CodeAcademy()
    {
    }
    
	public string Question(string question)
	{
			 Console.WriteLine(question);
		return question;
	}


    public void NameSurname(string name, string surname)
    {

        Name = name;
        Surname = surname;
    }
    public void GroupName(string Group)
    {
        this.Group = Group;
    }

    public void PointQuantity(int Point)
    {
        this.Point = Point;
    }

public void CheckTheScores()
    {
        if (Point<=51&&Point>=0)
        {
            isGraduated = false;
            Console.WriteLine($"Hormetli {Name} {Surname} teessufler olsun ki siz {Point} balla kesildiniz!!!" );
        }
        if (Point<=80&&Point>51)
        {
            isGraduated= true;
            Console.WriteLine($"Hormetli {Name} {Surname} balınızı artırmaq üçün ikici imtahana gire bilmezsiniz!!!");
        }
        if (Point<=95&&Point>80)
        {
            isGraduated = true;
            Console.WriteLine($"Hormetli {Name} {Surname} balınızı artırmaq üçün ikici imtahana gire bilersiniz!!!");
        }
        if (Point<=100&&Point>95)
        {
            isGraduated = true;
            Console.WriteLine($"Hormetli {Name} {Surname} Sizi Tebrik Edirik Siz Akademiyadan {Point} Balla Mezun oldunuz!!!");
        }
        else if (Point<0||Point>100)
        {
            Console.WriteLine("Düzgün reqem daxil edin!!!");
            Console.ReadLine();
        }
    }
public void Detail()
	{
        Console.WriteLine($"{Group} Qrupundan  {Name} {Surname} Topladıqınız Bal: {Point}  ");
        Console.WriteLine("Neticelere baxmaq üçün Enter-e basın ");
        Console.ReadLine();
    }
	
}