#region S

//********************************** before Single Responsibility Patterns **********************************

//class CreatAccount
//{
//    public void CreatAccountMehtod(string name ,string password,string gmail)
//    {
//        if(name != null && password != null)
//        {
//            bool check = true;
//            foreach (var account in accounts)
//            {
//                if (account.name == name && account.password == password)
//                    check = false;
//            }
//            if (check)
//            {
//                int VerifyCode = Random.Shared.Next(111111, 999999);
//                MailMessage msg = new MailMessage();
//                msg.From = new MailAddress( "Gmail");
//                string sbj = "VERIFY CODE";
//                msg.Subject = sbj;
//                msg.To.Add(new MailAddress(gmail));
//                msg.IsBodyHtml = true;
//                var smtpClient = new SmtpClient("smtp.gmail.com")
//                {
//                    Port = 587,
//                    Credentials = new NetworkCredential("pervinagayev28@gmail.com","asdasd"),
//                    EnableSsl = true
//                };
//                smtpClient.Send(msg);
//                Console.WriteLine("enter code");
//                var code = Console.ReadLine();
//                if(code == VerifyCode.ToString())
//                {
//                    //created account
//                }

//            }
//        }
//    }

//}



//********************************** after Single Responsibility Patterns **********************************



//class CreatAccount
//{
//    private bool IsEmpty(string name, string password, string gmail) =>
//        name != null && password != null && gmail != null;



//    private bool hasAccount(string name, string password)
//    {
//        foreach (var account in accounts)
//        {
//            if (account.name == name && account.password == password)
//                return false;
//        }
//        return true;
//    }
//    public void CreatAccountMehtod(string name, string password, string gmail)
//    {
//        if (IsEmpty(name, password, gmail))
//        {

//            if (hasAccount(name,password))
//            {
//                Console.WriteLine("enter code");
//                var code = Console.ReadLine();
//                if (code == GetCode.GmailVerify(gmail))
//                {
//                    //created account
//                }

//            }
//        }
//    }

//}


//public static class GetCode
//{
//    public static string GmailVerify(string gmail)
//    {
//        //----------- SMTP ------------

//        int VerifyCode = Random.Shared.Next(111111, 999999);
//        MailMessage msg = new MailMessage();
//        msg.From = new MailAddress("asdasda");
//        string sbj = "VERIFY CODE";
//        msg.Subject = sbj;
//        msg.To.Add(new MailAddress(gmail));
//        msg.IsBodyHtml = true;
//        var smtpClient = new SmtpClient("smtp.gmail.com")
//        {
//            Port = 587,
//            Credentials = new NetworkCredential("pervinagayev28@gmail.com", "asdasda")),
//            EnableSsl = true
//        };
//        smtpClient.Send(msg);
//        return VerifyCode.ToString();
//    }
//}

#endregion
#region O

//********************************** before Open/Closed Patterns **********************************

//class Soldier
//{

//    void shoot(string gun)
//    {
//        if(gun =="AKM")
//        {
//            //some...
//        }
//        else if (gun == "RQP")
//        {
//            //some...
//        }
//        else if (gun == "ZEFER")
//        {
//            //some...
//        }
//    }
//}


//********************************** after Open/Closed Patterns **********************************


//class Soldier
//{

//    void shoot(Gun gun)
//    {
//        gun.shoot();
//    }
//}

//interface Gun
//{
//    void shoot();

//}


//class RQP : Gun
//{
//    public void shoot()
//    {
//        //some....
//    }
//}

//class AKM : Gun
//{
//    public void shoot()
//    {
//        //some...
//    }
//}
#endregion
#region L

//********************************** before Liskov Substitution Patterns **********************************

//bu prinsipe uygun yazilmamis bir kod,daha dogrusu bu prinsipi ezerek classlar arasinda bir elaqe qurmak mentiqsizdir ,meselen;


//class  Bird
//{
//    public void fly()
//    {
//        //FLYING...
//    } 
//}

//class Penguin : Bird
//{
//    public void fly()
//    {
//        throw new Exception("cant fly");
//    }
//}

//Penguin p - new();
//p.fly();//error olacak cunki pengui uca bilmir,ve derived base yerine islene bilmeyecey deye,prinsip pozulacak



//********************************** after Liskov Substitution Patterns **********************************


//class  Bird
//{
//    public void Move()
//    {
//        //moving...
//    } 
//}

//class Penguin : Bird
//{
//    public void fly()
//    {
//        move....
//    }
//}

//Penguin p - new();
//p.Move();



#endregion
#region I

//********************************** before Interface Segregation Patterns **********************************



//interface Person
//{

//    void Getage(string age);
//    void Getname(string name);
//    void Getsurname(string surname);
//    void Getworkplace(string workPlace);

//}






//class OlderPerson : Person
//{
//    public void Getage(string age)
//    {
//        Console.WriteLine("25");
//    }

//    public void Getname(string name)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getsurname(string surname)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getworkplace(string workPlace)
//    {
//        Console.WriteLine("some");
//    }
//}

//class childPerson : Person
//{
//    public void Getage(string age)
//    {
//        Console.WriteLine("15");
//    }

//    public void Getname(string name)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getsurname(string surname)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getworkplace(string workPlace)
//    {
//        throw new Exception("age is under 18");
//    }
//}



//********************************** after Interface Segregation Patterns **********************************

//interface Person
//{

//    void Getage(string age);
//    void Getname(string name);
//    void Getsurname(string surname);

//}

//interface PersonOlder
//{
//    void Getworkplace(string workPlace);

//}




//class OlderPerson : Person, PersonOlder
//{
//    public void Getage(string age)
//    {
//        Console.WriteLine("25");
//    }

//    public void Getname(string name)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getsurname(string surname)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getworkplace(string workPlace)
//    {
//        Console.WriteLine("some");
//    }
//}

//class childPerson : Person
//{
//    public void Getage(string age)
//    {
//        Console.WriteLine("15");
//    }

//    public void Getname(string name)
//    {
//        Console.WriteLine("some");
//    }

//    public void Getsurname(string surname)
//    {
//        Console.WriteLine("some");
//    }


//}

#endregion
#region D

//********************************** before Dependency Inversion Patterns **********************************

using System.ComponentModel.DataAnnotations;

//class Student
//{
//    void go(Car car)
//    {
//        car.go();
//    }
//}
//class Car
//{
//    public void go()
//    {
//        //went
//    }
//}


//********************************** after Dependency Inversion Patterns **********************************


//interface ITranspration
//{
//    void go();
//}
//class Student
//{
//    void go(ITranspration transp)
//    {
//        transp.go();
//    }
//}
//class Car:ITranspration
//{
//    public void go()
//    {
//        //went
//    }
//}


//class Bcycle : ITranspration
//{
//    public void go()
//    {
//        //went
//    }
//}



#endregion