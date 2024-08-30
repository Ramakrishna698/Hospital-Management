using System.Collections.Generic;
using System.Threading;
class project1
{
    public static void Main(string[] args)
    {

        List<string> dname = new List<string>();
        List<string> dsp = new List<string>();
        List<string> dadd = new List<string>();
        List<string> dg = new List<string>();
        List<int> dage = new List<int>();
        List<long> dph = new List<long>();
        List<string> did = new List<string>();
        string[] sp = { "CARDIOLOGIST", "PULMONOLOGIST", "NEUROLOGIST", "ONCOLOGIST", "DENTIST", "DERMOTOLOGIST", "ARTHOPEDIST", "PRACTITIONER", "GYNECOLOGIST", "PATHOLOGIST" };

        List<string> rname = new List<string>();
        List<string> radd = new List<string>();
        List<string> rg = new List<string>();
        List<int> rage = new List<int>();
        List<long> rph = new List<long>();
        List<string> rid = new List<string>();

        List<string> pname = new List<string>();
        List<string> padd = new List<string>();
        List<string> pdis = new List<string>();
        List<string> pg = new List<string>();
        List<int> page = new List<int>();
        List<long> pph = new List<long>();
        List<string> pid = new List<string>();
        List<string> med = new List<string>();
        List<int> qu = new List<int>();
        qu.Add(89);
        qu.Add(129);
        qu.Add(98);
        qu.Add(50);
        qu.Add(49);
        qu.Add(45);
        qu.Add(55);
        qu.Add(60);
        List<string> emed = new List<string>();
        List<int> equ = new List<int>();
        equ.Add(1);
        equ.Add(2);
        equ.Add(2);
        string doc, pat, uid, add, spec, val, en;
        long num, temp, count;
        Console.Clear();
    x:
        Console.WriteLine("\n\t\t\t\t\t\tHOSPITAL MANAGEMENT SYSTEM");
        Console.WriteLine("\n\n\t\t\t\t\t\tWelcome to login portal");
        Console.Write("\n1.Doctor Registration\n\n2.Reception Registration\n\n3.Patient Registration\n\n4.Exit\n\nEnter your Choice : ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\n");
        while (n <= 4 && n > 0)
        {
            if (n == 1)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t\t\t\t\tWELCOME TO REGISTRATION PORTAL FOR DOCTORS\n\n");
            j: Console.Write("1.CREATE ID\n2.UPDATE ID\n3.SHOW YOUR DETAILS\n4.DELETE ID\n5.MAIN MENU\n\nEnter your option: ");
                int ur = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            F: Thread.Sleep(1000);
                Console.Clear();
                if (ur == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\tWelcome to registraion\n\n");
                    Console.Write("Name           : ");
                    string name = Console.ReadLine();
                    dname.Add(name);
                    Console.Write("Age            : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    while (age > 100 || age < 20)
                    {
                        Console.WriteLine("Try again with a valid age ...");
                        Console.Write("Age            : ");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    dage.Add(age);
                    Console.Write("Gender(M/F/T)  : ");
                    string gen = Console.ReadLine();
                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                    {
                        Console.WriteLine("Gender is not valid. Please try again...");
                        Console.Write("Gender(M/F/T)  : ");
                        gen = Console.ReadLine();
                    }
                    dg.Add(gen.ToUpper());
                    Console.Write("Address        : ");
                    add = Console.ReadLine();
                    dadd.Add(add);
                    Console.Write("Specialization : ");
                ac: spec = Console.ReadLine();
                    count = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        if (spec.ToUpper() == sp[i])
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.WriteLine("\nEntered specialization is not valid\nPlease check the Specializations\n");
                        Console.WriteLine("CARDIOLOGIST, PULMONOLOGIST, NEUROLOGIST, ONCOLOGIST, DENTIST\nDERMOTOLOGIST, ARTHOPEDIST, PRACTITIONER, GYNECOLOGIST, PATHOLOGIST\n");
                        Console.Write("Please enter again: ");
                        goto ac;
                    }
                    dsp.Add(spec);
                y: Console.Write("Phone number   : ");
                    count = 0;
                    num = Convert.ToInt64(Console.ReadLine());
                    temp = num;
                    while (temp != 0)
                    {
                        count++;
                        temp = temp / 10;
                    }
                    if (count != 10)
                    {
                        Console.WriteLine("Phone number is not valid.Try again...");
                        goto y;
                    }
                    dph.Add(num);
                    for (int i = 0; i < did.Count; i++)
                    {
                        if (name == dname[i] && age == dage[i] && gen.ToUpper() == dg[i] && add == dadd[i] && spec == dsp[i] && num == dph[i])
                        {
                            Console.WriteLine("You have already registered");
                            Console.WriteLine("\n\nYour user id is : " + did[i]);
                            Thread.Sleep(2000);
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                    }
                    Console.WriteLine("\n\nThanks for registering ....");
                    Thread.Sleep(1000);
                    Console.WriteLine("\n\nYour user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                    did.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                    Console.Write("\nPress Enter to go to MainMenu : ");
                    string ch = Console.ReadLine();
                    if (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                }
                else if (ur == 2)
                {
                    if (did.Count == 0)
                    {
                        Console.WriteLine("No Doctor has registered yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto F;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < dname.Count; i++)
                    {
                        if (uid == did[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < dname.Count; i++)
                        {
                            if (uid == did[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + dname[i]); Thread.Sleep(500);
                                Console.WriteLine("Age            : " + dage[i]); Thread.Sleep(500);
                                Console.WriteLine("Gender         : " + dg[i]); Thread.Sleep(500);
                                Console.WriteLine("Address        : " + dadd[i]); Thread.Sleep(500);
                                Console.WriteLine("Specialization : " + dsp[i]); Thread.Sleep(500);
                                Console.WriteLine("Phone number   : " + dph[i]); Thread.Sleep(500);
                                Console.WriteLine("Doctor id      : " + did[i]);
                                Console.Write("Would you like to change your details[yes/no]: ");
                                val = Console.ReadLine();
                                if (val.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Please enter new details");
                                    dname.RemoveAt(i);
                                    Console.Write("Name           : ");
                                    string name = Console.ReadLine();
                                    dname.Add(name);
                                    dage.RemoveAt(i);
                                    Console.Write("Age            : ");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    while (age > 100 || age < 20)
                                    {
                                        Console.WriteLine("Try again with a valid age ...");
                                        Console.Write("Age            : ");
                                        age = Convert.ToInt32(Console.ReadLine());
                                    }
                                    dage.Add(age);
                                    Console.Write("Gender(M/F/T)  : ");
                                    string gen = Console.ReadLine();
                                    dg.RemoveAt(i);
                                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                                    {
                                        Console.WriteLine("Gender is not valid. Please try again...");
                                        Console.Write("Gender(M/F/T)  : ");
                                        gen = Console.ReadLine();
                                    }
                                    dg.Add(gen.ToUpper());
                                    Console.Write("Address        : ");
                                    add = Console.ReadLine();
                                    dadd.RemoveAt(i);
                                    dadd.Add(add);
                                    Console.Write("Specialization : ");
                                    spec = Console.ReadLine();
                                    dsp.RemoveAt(i);
                                    dsp.Add(spec);
                                y: Console.Write("Phone number   : ");
                                    count = 0;
                                    num = Convert.ToInt64(Console.ReadLine());
                                    temp = num;
                                    while (temp != 0)
                                    {
                                        count++;
                                        temp = temp / 10;
                                    }
                                    if (count != 10)
                                    {
                                        Console.WriteLine("Phone number is not valid.Try again...");
                                        goto y;
                                    }
                                    dph.RemoveAt(i);
                                    dph.Add(num);
                                    Console.WriteLine("\n\nThanks for registering ....");
                                    Thread.Sleep(1000);
                                    did.RemoveAt(i);
                                    Console.WriteLine("\n\nYour new user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                                    did.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                                }
                                else if (val.ToUpper() == "NO")
                                {
                                    Console.Write("\nMoving to MainMenu");
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Thread.Sleep(1000);
                                        Console.Write(".");
                                    }
                                    goto x;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                    p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto F;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                    Console.Write("\nPress Enter to go to MainMenu : ");
                    string ch = Console.ReadLine();
                    if (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                }
                else if (ur == 3)
                {
                    if (did.Count == 0)
                    {
                        Console.WriteLine("No Doctor has registered yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto F;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < dname.Count; i++)
                    {
                        if (uid == did[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < dname.Count; i++)
                        {
                            if (uid == did[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + dname[i]); Thread.Sleep(500);
                                Console.WriteLine("Age            : " + dage[i]); Thread.Sleep(500);
                                Console.WriteLine("Gender         : " + dg[i]); Thread.Sleep(500);
                                Console.WriteLine("Address        : " + dadd[i]); Thread.Sleep(500);
                                Console.WriteLine("Specialization : " + dsp[i]); Thread.Sleep(500);
                                Console.WriteLine("Phone number   : " + dph[i]); Thread.Sleep(500);
                                Console.WriteLine("Doctor id      : " + did[i]);
                            }
                        }
                        Console.Write("\n\nPress enter to goto MainMenu...");
                        en = Console.ReadLine();
                        if (true)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                    p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto F;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                }
                else if (ur == 4)
                {
                    if (did.Count == 0)
                    {
                        Console.WriteLine("No Doctor has registered yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto F;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < dname.Count; i++)
                    {
                        if (uid == did[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < dname.Count; i++)
                        {
                            if (uid == did[i])
                            {
                                dname.RemoveAt(i);
                                dage.RemoveAt(i);
                                dg.RemoveAt(i);
                                dadd.RemoveAt(i);
                                dsp.RemoveAt(i);
                                dph.RemoveAt(i);
                                did.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("\nSuccessfully deleted your profile");
                        Console.Write("\n\nPress enter to goto MainMenu...");
                        en = Console.ReadLine();
                        if (true)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                    p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto F;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                }
                else if (ur == 5)
                {
                    Console.Write("\nMoving to MainMenu");
                    for (int k = 0; k < 3; k++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    goto x;
                }
                else
                {
                    Console.WriteLine("Please enter [1/2/3/4]");
                    goto j;
                }
            }
            else if (n == 2)
            {
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
            g:
                Console.WriteLine();
                Console.WriteLine("\t\t\t\t\tWelcome to registration portal for Receptionist\n");
            h: Console.Write("1.CREATE ID\n2.UPDATE ID\n3.SHOW YOUR DETAILS\n4.DELETE ID\n5.MAIN MENU\n\nEnter your option: ");
                int ur = Convert.ToInt32(Console.ReadLine());
            G: Thread.Sleep(1000);
                Console.Clear();
                if (ur == 1)
                {
                    Console.WriteLine("\n\t\t\t\t\tWelcome to registraion\n\n");
                    Console.Write("Name           : ");
                    string name = Console.ReadLine();
                    rname.Add(name);
                    Console.Write("Age            : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    while (age > 100 || age < 20)
                    {
                        Console.WriteLine("Try again with a valid age ...");
                        Console.Write("Age            : ");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    rage.Add(age);
                    Console.Write("Gender(M/F/T)  : ");
                    string gen = Console.ReadLine();
                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                    {
                        Console.WriteLine("Gender is not valid. Please try again...");
                        Console.Write("Gender(M/F/T)  : ");
                        gen = Console.ReadLine();
                    }
                    rg.Add(gen);
                    Console.Write("Address        : ");
                    add = Console.ReadLine();
                    radd.Add(add);
                b: Console.Write("Phone number   : ");
                    num = Convert.ToInt64(Console.ReadLine());
                    count = 0;
                    temp = num;
                    while (temp != 0)
                    {
                        count++;
                        temp = temp / 10;
                    }
                    if (count != 10)
                    {
                        Console.WriteLine("Phone number is not valid.Try again...");
                        goto b;
                    }
                    rph.Add(num);
                    for (int i = 0; i < rid.Count; i++)
                    {
                        if (name == rname[i] && age == rage[i] && gen == rg[i] && add == radd[i] && num == rph[i])
                        {
                            Console.WriteLine("You have already registered");
                            Console.WriteLine("\n\nYour user id is : " + did[i]);
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                    }
                    Console.WriteLine("Thanks for registering ....");
                    Console.WriteLine();
                    Thread.Sleep(1000);
                    Console.WriteLine("Your user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                    rid.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                    Console.Write("Do you want to go to Mainmenu (1 - yes / 2 - no): ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (ur == 2)
                {
                    if (rid.Count == 0)
                    {
                        Console.WriteLine("No Receptionist Records has done yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto G;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < rname.Count; i++)
                    {
                        if (uid == rid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < rname.Count; i++)
                        {
                            if (uid == rid[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + rname[i]); Thread.Sleep(500);
                                Console.WriteLine("Age            : " + rage[i]); Thread.Sleep(500);
                                Console.WriteLine("Gender         : " + rg[i]); Thread.Sleep(500);
                                Console.WriteLine("Address        : " + radd[i]); Thread.Sleep(500);
                                Console.WriteLine("Phone number   : " + rph[i]); Thread.Sleep(500);
                                Console.WriteLine("Receptionist id: " + rid[i]);
                                Console.Write("Would you like to change your details[yes/no]: ");
                                val = Console.ReadLine();
                                if (val.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Please enter new details");
                                    rname.RemoveAt(i);
                                    Console.Write("Name           : ");
                                    string name = Console.ReadLine();
                                    rname.Add(name);
                                    rage.RemoveAt(i);
                                    Console.Write("Age            : ");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    while (age > 100 || age < 20)
                                    {
                                        Console.WriteLine("Try again with a valid age ...");
                                        Console.Write("Age            : ");
                                        age = Convert.ToInt32(Console.ReadLine());
                                    }
                                    rage.Add(age);
                                    Console.Write("Gender(M/F/T)  : ");
                                    string gen = Console.ReadLine();
                                    rg.RemoveAt(i);
                                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                                    {
                                        Console.WriteLine("Gender is not valid. Please try again...");
                                        Console.Write("Gender(M/F/T)  : ");
                                        gen = Console.ReadLine();
                                    }
                                    rg.Add(gen.ToUpper());
                                    Console.Write("Address        : ");
                                    add = Console.ReadLine();
                                    radd.RemoveAt(i);
                                    radd.Add(add);
                                y: Console.Write("Phone number   : ");
                                    count = 0;
                                    num = Convert.ToInt64(Console.ReadLine());
                                    temp = num;
                                    while (temp != 0)
                                    {
                                        count++;
                                        temp = temp / 10;
                                    }
                                    if (count != 10)
                                    {
                                        Console.WriteLine("Phone number is not valid.Try again...");
                                        goto y;
                                    }
                                    rph.RemoveAt(i);
                                    rph.Add(num);
                                    Console.WriteLine("\n\nThanks for registering ....");
                                    Thread.Sleep(1000);
                                    rid.RemoveAt(i);
                                    Console.WriteLine("\n\nYour new user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                                    rid.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                                }
                                else if (val.ToUpper() == "NO")
                                {
                                    Console.Write("\nMoving to MainMenu");
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Thread.Sleep(1000);
                                        Console.Write(".");
                                    }
                                    goto x;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                    p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto G;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                    Console.Write("Enter 1 to go to MainMenu : ");
                    string ch = Console.ReadLine();
                    if (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                }
                else if (ur == 3)
                {
                    if (rid.Count == 0)
                    {
                        Console.WriteLine("No Receptionist Records has done yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto G;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < rname.Count; i++)
                    {
                        if (uid == rid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < rname.Count; i++)
                        {
                            if (uid == rid[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + rname[i]); Thread.Sleep(500);
                                Console.WriteLine("Age            : " + rage[i]); Thread.Sleep(500);
                                Console.WriteLine("Gender         : " + rg[i]); Thread.Sleep(500);
                                Console.WriteLine("Address        : " + radd[i]); Thread.Sleep(500);
                                Console.WriteLine("Phone number   : " + rph[i]); Thread.Sleep(500);
                                Console.WriteLine("Receptionist id: " + rid[i]);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                    p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto G;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                    Console.Write("Press Enter to go to MainMenu : ");
                    string ch = Console.ReadLine();
                    if (true)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                }
                else if (ur == 4)
                {
                    if (rid.Count == 0)
                    {
                        Console.WriteLine("No Receptionist Records has done yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto G;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    z: Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < rname.Count; i++)
                    {
                        if (uid == rid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < rname.Count; i++)
                        {
                            if (uid == rid[i])
                            {
                                rname.RemoveAt(i);
                                rage.RemoveAt(i);
                                rg.RemoveAt(i);
                                radd.RemoveAt(i);
                                rph.RemoveAt(i);
                                rid.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("\nSuccessfully deleted your profile");
                        Console.Write("\n\nPress enter to goto MainMenu...");
                        en = Console.ReadLine();
                        if (true)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                    }
                    else
                    {
                        Console.WriteLine("The Entered ID was incorrect.\n\nAre you registered?");
                        Console.Write("\n1 -> Yes\n2 -> No\n\nEnter your choice: ");
                        p: int ch2 = Convert.ToInt32(Console.ReadLine());
                        if (ch2 == 1)
                        {
                            Console.Clear();
                            goto z;
                        }
                        else if (ch2 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Would U like to register");
                            Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        y: int ch1 = Convert.ToInt32(Console.ReadLine());
                            if (ch1 == 1)
                            {
                                ur = 1;
                                goto G;
                            }
                            else if (ch1 == 2)
                            {
                                Console.Write("\nMoving to MainMenu");
                                for (int i = 0; i < 3; i++)
                                {
                                    Thread.Sleep(1000);
                                    Console.Write(".");
                                }
                                goto x;
                            }
                            else
                            {
                                Console.Write("Please enter 1 or 2: ");
                                goto y;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2: ");
                            goto p;
                        }
                    }
                }
                else if (ur == 5)
                {
                    Console.Write("\nMoving to MainMenu");
                    for (int k = 0; k < 3; k++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    goto x;
                }
                else
                {
                    Console.WriteLine("Please enter [1/2/3/4]");
                    goto h;
                }
            }
            else if (n == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Thread.Sleep(1000);
                Console.Clear();
            l:
                Console.WriteLine("\n\n\t\t\t\t\tWelcome to Patient Registration Portal\n");
            o: Console.Write("1.CREATE ID\n2.UPDATE ID\n3.SHOW YOUR DETAILS\n4.DELETE ID\n5.VISIT DOCTOR\n6.MAIN MENU\n\nEnter your option: ");
                int ur = Convert.ToInt32(Console.ReadLine());
            u: Thread.Sleep(1000);
                Console.Clear();
                if (ur == 1)
                {
                    if (rid.Count == 0)
                    {
                        Console.WriteLine("Sorry for the inconvenience.\n\nNo receptionist had registered yet.");
                        Thread.Sleep(2000);
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Clear();
                        goto x;
                    }
                    Console.WriteLine("\n\t\t\t\t\tWelcome to registraion\n\n");
                    Console.Write("Name           : ");
                    string name = Console.ReadLine();
                    pname.Add(name);
                    Console.Write("Age            : ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    while (age < 0 && age > 100)
                    {
                        Console.WriteLine("Try again with a valid age ...");
                        Console.Write("Age            : ");
                        age = Convert.ToInt32(Console.ReadLine());
                    }
                    page.Add(age);
                    Console.Write("Gender(M/F/T)  : ");
                    string gen = Console.ReadLine();
                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                    {
                        Console.WriteLine("Gender is not valid. Please try again...");
                        Console.Write("Gender(M/F/T)  : ");
                        gen = Console.ReadLine();
                    }
                    pg.Add(gen);
                    Console.Write("Address        : ");
                    add = Console.ReadLine();
                    padd.Add(add);
                c: Console.Write("Phone number   : ");
                    num = Convert.ToInt64(Console.ReadLine());
                    count = 0;
                    temp = num;
                    while (temp != 0)
                    {
                        count++;
                        temp = temp / 10;
                    }
                    if (count != 10)
                    {
                        Console.WriteLine("Phone number is not valid.Try again...");
                        goto c;
                    }
                    pph.Add(num);
                    Console.Write("Purpose of visit: ");
                    pdis.Add(Console.ReadLine());
                    for (int i = 0; i < pid.Count; i++)
                    {
                        if (name == pname[i] && age == page[i] && gen == pg[i] && add == padd[i] && num == pph[i])
                        {
                            Console.WriteLine("\nYou have already registered");
                            Console.WriteLine("\n\nYour user id is : " + did[i]);
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                    }
                    Thread.Sleep(1000);
                    Console.WriteLine("Thanks for registering ....\n\n");
                    Thread.Sleep(1000);
                    Console.WriteLine("Your user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                    pid.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                    Console.Write("\n1 -> MainMenu\n2 -> Visit Doctor\n\nEnter your choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Thread.Sleep(2000);
                        goto x;
                    }
                    else if (ch == 2)
                    {
                        ur = 5;
                        goto u;
                    }
                }
                else if (ur == 2)
                {
                    if (pid.Count == 0)
                    {
                        Console.WriteLine("No Patient Records has done yet.\n\nWould you like to register");
                        y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    Console.Write("\nPlease provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < pname.Count; i++)
                    {
                        if (uid == pid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < pname.Count; i++)
                        {
                            if (uid == pid[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + pname[i]); Thread.Sleep(1000);
                                Console.WriteLine("Age            : " + page[i]); Thread.Sleep(1000);
                                Console.WriteLine("Address        : " + padd[i]); Thread.Sleep(1000);
                                Console.WriteLine("Gender         : " + pg[i]); Thread.Sleep(1000);
                                Console.WriteLine("Phone number   : " + pph[i]); Thread.Sleep(1000);
                                Console.WriteLine("Patient id     : " + pid[i]);
                                Console.Write("Would you like to change your details[yes/no]: ");
                                val = Console.ReadLine();
                                if (val.ToUpper() == "YES")
                                {
                                    Console.WriteLine("Please enter new details");
                                    pname.RemoveAt(i);
                                    Console.Write("Name           : ");
                                    string name = Console.ReadLine();
                                    pname.Add(name);
                                    page.RemoveAt(i);
                                    Console.Write("Age            : ");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    while (age > 100 || age < 20)
                                    {
                                        Console.WriteLine("Try again with a valid age ...");
                                        Console.Write("Age            : ");
                                        age = Convert.ToInt32(Console.ReadLine());
                                    }
                                    page.Add(age);
                                    Console.Write("Gender(M/F/T)  : ");
                                    string gen = Console.ReadLine();
                                    pg.RemoveAt(i);
                                    while (gen.ToUpper() != "M" && gen.ToUpper() != "F" && gen.ToUpper() != "T")
                                    {
                                        Console.WriteLine("Gender is not valid. Please try again...");
                                        Console.Write("Gender(M/F/T)  : ");
                                        gen = Console.ReadLine();
                                    }
                                    pg.Add(gen.ToUpper());
                                    Console.Write("Address        : ");
                                    add = Console.ReadLine();
                                    padd.RemoveAt(i);
                                    padd.Add(add);
                                    Console.Write("Specialization : ");
                                    spec = Console.ReadLine();
                                    dsp.RemoveAt(i);
                                    dsp.Add(spec);
                                y: Console.Write("Phone number   : ");
                                    count = 0;
                                    num = Convert.ToInt64(Console.ReadLine());
                                    temp = num;
                                    while (temp != 0)
                                    {
                                        count++;
                                        temp = temp / 10;
                                    }
                                    if (count != 10)
                                    {
                                        Console.WriteLine("Phone number is not valid.Try again...");
                                        goto y;
                                    }
                                    pph.RemoveAt(i);
                                    pph.Add(num);
                                    Console.WriteLine("\n\nThanks for registering ....");
                                    Thread.Sleep(1000);
                                    pid.RemoveAt(i);
                                    Console.WriteLine("\n\nYour new user id is : " + (name.Substring(0, 2).ToUpper() + (num % 1000) + age));
                                    pid.Add(name.Substring(0, 2).ToUpper() + (num % 1000) + age);
                                }
                                else if (val.ToUpper() == "NO")
                                {
                                    Console.Write("\nMoving to MainMenu");
                                    for (int k = 0; k < 3; k++)
                                    {
                                        Thread.Sleep(1000);
                                        Console.Write(".");
                                    }
                                    goto x;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.Clear();
                    y: Console.WriteLine("You have not registered.Would U like to register");
                        Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    Console.Write("\n1 -> MainMenu\n2 -> Visit Doctor\n\nEnter your choice: ");
                    int ch = Convert.ToInt32(Console.ReadLine());
                    if (ch == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("\nMoving to MainMenu");
                        for (int k = 0; k < 3; k++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                    else if (ch == 2)
                    {
                        ur = 5;
                        goto u;
                    }
                }
                else if (ur == 3)
                {
                    if (pid.Count == 0)
                    {
                        Console.WriteLine("No Patient Records has done yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    Console.Write("\nPlease provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < pname.Count; i++)
                    {
                        if (uid == pid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < pname.Count; i++)
                        {
                            if (uid == pid[i])
                            {
                                Console.WriteLine();
                                Console.WriteLine("Name           : " + pname[i]); Thread.Sleep(1000);
                                Console.WriteLine("Age            : " + page[i]); Thread.Sleep(1000);
                                Console.WriteLine("Address        : " + padd[i]); Thread.Sleep(1000);
                                Console.WriteLine("Gender         : " + pg[i]); Thread.Sleep(1000);
                                Console.WriteLine("Phone number   : " + pph[i]); Thread.Sleep(1000);
                                Console.WriteLine("Patient id     : " + pid[i]);
                            }
                        }
                        Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch = Convert.ToInt32(Console.ReadLine());
                        if (ch == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                        else if (ch == 2)
                        {
                            ur = 5;
                            goto u;
                        }
                    }
                    else
                    {
                        Console.Clear();
                    y: Console.WriteLine("You have not registered.Would U like to register");
                        Console.WriteLine("1 -> Registration\n2 -> Main Menu");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                }
                else if (ur == 4)
                {
                    if (pid.Count == 0)
                    {
                        Console.WriteLine("No Patient Records has done yet.\n\nWould you like to register");
                    y: Console.Write("\n1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                        int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int k = 0; k < 3; k++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < pname.Count; i++)
                    {
                        if (uid == pid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        for (int i = 0; i < pname.Count; i++)
                        {
                            if (uid == pid[i])
                            {
                                pname.RemoveAt(i);
                                page.RemoveAt(i);
                                pg.RemoveAt(i);
                                padd.RemoveAt(i);
                                pph.RemoveAt(i);
                                pid.RemoveAt(i);
                            }
                        }
                        Console.WriteLine("\nSuccessfully deleted your profile");
                        Console.Write("\n\nPress enter to goto MainMenu...");
                        en = Console.ReadLine();
                        if (true)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have not registered.Would U like to register");
                        Console.WriteLine("1 -> Registration\n2 -> Main Menu");
                    y: int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2");
                            goto y;
                        }
                    }
                }
                else if (ur == 5)
                {
                    if (pid.Count == 0)
                    {
                        Console.WriteLine("No patient had registered yet\n");
                        Console.WriteLine("Would U like to register");
                        Console.Write("1 -> Registration\n2 -> Main Menu\n\nEnter your choice: ");
                    y: int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            goto x;
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2");
                            goto y;
                        }
                    }
                    if (did.Count == 0)
                    {
                        Console.WriteLine("Sorry for the inconvenience.\n\nNo doctor had registered yet.");
                        Thread.Sleep(2000);
                        Console.Write("\nMoving to MainMenu");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        goto x;
                    }
                    Console.Write("Please provide your Id : ");
                    uid = Console.ReadLine();
                    int ct = 0;
                    for (int i = 0; i < pname.Count; i++)
                    {
                        if (uid == pid[i])
                        {
                            ct = 1;
                            break;
                        }
                    }
                    if (ct == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\nplease wait while we are connecting doctor");
                        for (int i = 0; i < 3; i++)
                        {
                            Thread.Sleep(1000);
                            Console.Write(".");
                        }
                        Console.Clear();
                        Console.WriteLine("Doctor  : What's your problem?");
                        Console.Write("Patient : ");
                        pat = Console.ReadLine();
                        Console.WriteLine("Doctor  : Oh! OK. Since how many days");
                        Console.Write("Patient : ");
                        pat = Console.ReadLine();
                        Console.WriteLine("Doctor  : Take the medication as per the prescription");
                        Console.Write("Patient : ");
                        pat = Console.ReadLine();
                        Console.Write("Do you want to visit doctor again ('1') or proceed with the formaties ('Enter any key') :");
                        string v = Console.ReadLine();
                        int ch2 = 0;
                        if (v == "1")
                        {
                            Console.WriteLine("Doctor  : Are U suffering from any type of headache or vomiting sensation[YES/NO]");
                            Console.Write("Patient : ");
                            pat = Console.ReadLine();
                            if (pat.ToUpper() == "YES")
                            {
                                Console.WriteLine("Doctor  : Ok then. I'll prefer some more medicines use them for some days");
                                Console.Write("Patient : ");
                                pat = Console.ReadLine();
                                ch2 = 1;
                            }
                            else
                            {
                                Console.WriteLine("Doctor  : Then don't worry about anything");
                                Console.Write("Patient : ");
                                pat = Console.ReadLine();
                            }
                            Console.WriteLine("Doctor  : Alright! You can leave now");
                            Console.Write("Patient : ");
                            pat = Console.ReadLine();
                        }
                        for (int i = 0; i < pid.Count; i++)
                        {
                            if (uid == pid[i])
                            {
                                Console.WriteLine("These are the medicines you need are as follows ....");
                                if (pdis[i] == "kidney")
                                {
                                    Console.WriteLine("\nBeta Blockers.\nDiuretics.\nFinerenone.\nInsulin.\nMetformin.\nStatins.\nAce.\nGLP-1.");
                                    med.Add("Beta Blockers");
                                    med.Add("Diuretics");
                                    med.Add("Finerenone");
                                    med.Add("Insulin");
                                    med.Add("Metformin");
                                    med.Add("Statins");
                                    med.Add("Ace");
                                    med.Add("GLP - 1.");
                                }
                                else if (pdis[i] == "lungs")
                                {
                                    Console.WriteLine("\nAclidinium.\nArformoterol. \nFormoterol. \nGlycopyrrolate. \nIndacaterol. \nOlodaterol.");
                                    med.Add("Aclidinium");
                                    med.Add("Arformoterol");
                                    med.Add("Glycopyrrolate");
                                    med.Add("Formoterol");
                                    med.Add("Indacaterol");
                                    med.Add("Olodaterol");
                                }
                                else if (pdis[i] == "heart")
                                {
                                    Console.WriteLine("Acebutolol (Sectral)\nAtenolol (Tenormin)\nBetaxolol (Kerlone)\nBisoprolol/hydrochlorothiazide (Ziac)\nBisoprolol (Zebeta)\nMetoprolol (Lopressor, Toprol XL)");
                                    med.Add("Acebutolol (Sectral)");
                                    med.Add("Atenolol (Tenormin)");
                                    med.Add("Betaxolol (Kerlone)");
                                    med.Add("Bisoprolol/hydrochlorothiazide (Ziac)");
                                    med.Add("Bisoprolol (Zebeta)");
                                    med.Add("Metoprolol (Lopressor, Toprol XL)");
                                }
                                else if (pdis[i] == "ent")
                                {
                                    Console.WriteLine("Fluticasone nasal preparations.\nGentamicin ear drops.\nHydrocortisone muco-adhesive tablets for mouth ulcers.\nIpratropium nasal spray (Rinaspray)");
                                    med.Add("Fluticasone nasal preparations");
                                    med.Add("Gentamicin ear drops");
                                    med.Add("Acebutolol (Sectral)");
                                    med.Add("Atenolol (Tenormin)");
                                    med.Add("Hydrocortisone muco-adhesive tablets for mouth ulcers");
                                    med.Add("Ipratropium nasal spray (Rinaspray)");
                                }
                                else
                                {
                                    Console.WriteLine("Acetaminophen\nAtorvastatin\nAmoxicillin\nLisinopril \nLevothyroxine");
                                    med.Add("Atorvastatin");
                                    med.Add("Amoxicillin");
                                    med.Add("Lisinopril ");
                                    med.Add("Betaxolol (Kerlone)");
                                    med.Add("Levothyroxine");
                                    med.Add("Acetaminophen");
                                }
                                if (ch2 == 1)
                                {
                                    Console.WriteLine("\nThese are for your headache or any other complaint");
                                    Console.WriteLine("Aspirin\nIboprofen\nOndansetron");
                                    emed.Add("Aspirin");
                                    emed.Add("Iboprofen");
                                    emed.Add("Ondansetron");
                                }
                            }
                        }
                        Console.Write("Would you like to buy the mediciences here [YES/NO]: ");
                        string y = Console.ReadLine();
                        if (y.ToUpper() == "YES")
                        {
                            Console.Clear();
                            Thread.Sleep(3000);
                            Console.WriteLine("\t\t\t\t\tBill Details \n");
                            for (int i = 0; i < pname.Count; i++)
                            {
                                if (uid == pid[i])
                                {
                                    Console.WriteLine("Name           : " + pname[i]); Thread.Sleep(1000);
                                    Console.WriteLine("Age            : " + page[i]); Thread.Sleep(1000);
                                    Console.WriteLine("Address        : " + padd[i]); Thread.Sleep(1000);
                                    Console.WriteLine("Gender         : " + pg[i]); Thread.Sleep(1000);
                                    Console.WriteLine("Phone number   : " + pph[i]); Thread.Sleep(1000);
                                    Console.WriteLine("Patient id     : " + pid[i]);
                                }
                            }
                            Console.WriteLine("Medicine name          Quantity          Total\n");
                            Console.WriteLine("------------------------------------------------");
                            int tot = 2000, spa;
                            for (int i = 0; i < med.Count; i++)
                            {
                                Thread.Sleep(3000);
                                Console.Write(med[i]);
                                spa = 25 - med[i].Length;
                                for (int j = 0; j < spa; j++)
                                {
                                    Console.Write(" ");
                                }
                                Console.WriteLine("10               " + qu[i] * 10);
                                tot = tot + (qu[i] * 10);
                            }
                            for (int i = 0; i < med.Count; i++)
                            {
                                med.RemoveAt(0);
                            }
                            if (ch2 == 1)
                            {
                                for (int i = 0; i < emed.Count; i++)
                                {
                                    Thread.Sleep(3000);
                                    Console.Write(emed[i]);
                                    spa = 25 - emed[i].Length;
                                    for (int j = 0; j < spa; j++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.WriteLine("10               " + equ[i] * 10);
                                    tot = tot + (equ[i] * 10);
                                }
                            }
                            Console.WriteLine("-------------------------------------------------");
                            Console.WriteLine("                        Total Amount : Rs." + tot + ".00");
                        }
                        else
                        {
                            Console.WriteLine("Please enter 1 or 2");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("You have not registered.Would U like to register");
                        Console.WriteLine("1 -> Registration\n2 -> Main Menu");
                    y: int ch1 = Convert.ToInt32(Console.ReadLine());
                        if (ch1 == 1)
                        {
                            ur = 1;
                            goto u;
                        }
                        else if (ch1 == 2)
                        {
                            Console.Write("\nMoving to MainMenu");
                            for (int i = 0; i < 3; i++)
                            {
                                Thread.Sleep(1000);
                                Console.Write(".");
                            }
                            goto x;
                        }
                        else
                        {
                            Console.Write("Please enter 1 or 2");
                            goto y;
                        }
                    }
                }
                else if (ur == 6)
                {
                    Console.Write("\nMoving to MainMenu");
                    for (int k = 0; k < 3; k++)
                    {
                        Thread.Sleep(1000);
                        Console.Write(".");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    goto x;
                }
                else
                {
                    Console.WriteLine("Please enter [1/2/3/4/5]: ");
                    goto o;
                }
                Thread.Sleep(5000);
                Console.Write("Do you wish to goto mainmenu type yes else exit : ");
                string ad = Console.ReadLine();
                if (ad.ToUpper() == "YES")
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Clear();
                    goto x;
                }
                break;
            }
            else
            {
                Console.Write("Exiting");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.Write(".");
                }
                break;
            }
        }
        if (n > 4 || n < 1)
        {
            Console.Clear();
            Thread.Sleep(2000);
            Console.WriteLine("please choose between the below option ...");
            goto x;
        }
    }
}