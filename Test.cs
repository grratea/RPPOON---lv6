using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace RPPOON___lv6
{
    public class Test
    {
        public static void Run1()
        {
            Notebook notebook = new Notebook();
            Note note1 = new Note("prva", "danas je petak");
            Note note2 = new Note("druga", "sutra je subota");
            Note note3 = new Note("treca", "preksutra je nedjelja");

            notebook.AddNote(note1);
            notebook.AddNote(note2);
            notebook.AddNote(note3);

            IAbstractIterator firstIterator = notebook.GetIterator();

            for (Note note = firstIterator.First(); firstIterator.IsDone == false; note = firstIterator.Next())
            {
                note.Show();
                Console.WriteLine();
            }

            notebook.RemoveNote(note3);

            IAbstractIterator secondIterator = notebook.GetIterator();
            Note currentNote = secondIterator.First();

            while (secondIterator.IsDone == false)
            {
                currentNote.Show();
                Console.WriteLine();
                currentNote = secondIterator.Next();
            }

            notebook.Clear();
            Console.WriteLine("NAKON CLEARA:");

            IAbstractIterator thirdIterator = notebook.GetIterator();

            while (thirdIterator.IsDone == false)
            {
                thirdIterator.Current.Show();
                Console.WriteLine();
                thirdIterator.Next();
            }
        }

        public static void Run2()
        {
            Box box = new Box();
            Product tv = new Product("Sony", 199.49);
            Product socks = new Product("Adidas", 4.0);
            Product book = new Product("Dune", 9.99);

            box.AddProduct(tv);
            box.AddProduct(socks);
            box.AddProduct(book);

            IAbstractBoxIterator firstIterator = box.GetIterator();
            Console.WriteLine("PRVIIIII");
            for (Product product = firstIterator.First(); firstIterator.IsDone == false; product = firstIterator.Next())
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine();
            }

            box.RemoveProduct(tv);

            IAbstractBoxIterator secondIterator = box.GetIterator();

            Console.WriteLine();
            Console.WriteLine("DRUUUUGI");

            Product currentProduct = secondIterator.First();

            while (secondIterator.IsDone == false)
            {
                Console.WriteLine(currentProduct.ToString());
                currentProduct = secondIterator.Next();
                Console.WriteLine();
            }

            box.Clear();

            Console.WriteLine();
            Console.WriteLine("TREEEEECI");
            for (IAbstractBoxIterator thirdIterator = box.GetIterator(); thirdIterator.IsDone == false; thirdIterator.Next())
            {
                Console.WriteLine(thirdIterator.Current.ToString());
            }

            Console.WriteLine("rip njega nema");
        }
        public static void Run3()
        {
            ToDoItem todo = new ToDoItem("Neki zadaci", "zad1 zad2 zad3", DateTime.Now);
            CareTaker careTaker = new CareTaker();
            careTaker.StoreMemento(todo.StoreState());

            todo.ChangeTimeDue(DateTime.Now.AddDays(3));
            careTaker.StoreMemento(todo.StoreState());

            todo.ChangeTask("zad4 zad5 zad6");
            careTaker.StoreMemento(todo.StoreState());

            todo.Rename("drugi naslov");
            careTaker.StoreMemento(todo.StoreState());


            Console.WriteLine("Sadašnji:");
            Console.WriteLine(todo.ToString());

            Console.WriteLine();

            todo.RestoreState(careTaker.RestoreMemento()); // na kojem je trenutno
            todo.RestoreState(careTaker.RestoreMemento()); // jos jednom da dodem na ovaj prosli
            Console.WriteLine("Prošli 1:");
            Console.WriteLine(todo.ToString());

            Console.WriteLine();

            todo.RestoreState(careTaker.RestoreMemento());
            Console.WriteLine("Prošli 2:");
            Console.WriteLine(todo.ToString());

            Console.WriteLine();

            todo.RestoreState(careTaker.RestoreMemento());
            Console.WriteLine("Prošli 3:");
            Console.WriteLine(todo.ToString());
        }


        public static void Run4()
        {
            BankAccount account = new BankAccount("Tea", "Osijek", 300000);
            BankCareTaker careTaker = new BankCareTaker();
            careTaker.StoreMemento(account.StoreState());

            account.ChangeOwnerAddress("Zagreb");
            careTaker.StoreMemento(account.StoreState());

            account.ChangeOwnerAddress("New York");
            careTaker.StoreMemento(account.StoreState());

            account.UpdateBalance(300);
            careTaker.StoreMemento(account.StoreState());

            Console.WriteLine("Sadašnji:");
            Console.WriteLine(account.ToString());

            Console.WriteLine();

            account.RestoreState(careTaker.RestoreMemento());
            account.RestoreState(careTaker.RestoreMemento());
            Console.WriteLine("Stari: " + account.ToString());

            Console.WriteLine();

            account.RestoreState(careTaker.RestoreMemento());
            Console.WriteLine("Stari: " + account.ToString());

            Console.WriteLine();

            account.RestoreState(careTaker.RestoreMemento());
            Console.WriteLine("Stari: " + account.ToString());
        }
        
        public static void Run5()
        {
            AbstractLogger logger = new ConsoleLogger(MessageType.ALL);
            FileLogger fileLogger = new FileLogger(MessageType.ERROR | MessageType.WARNING, "C:\\Users\\Tea\\Desktop\\faks\\Razvoj Programske Podrške Objektno Orijentiranim Načelima\\LV\\LV 1\\RPPOON - lv6\\logFile.txt");
            logger.SetNextLogger(fileLogger);

            logger.Log("oki doki smoki", MessageType.INFO);
            logger.Log("part22222", MessageType.WARNING); // ispisuje samo ovu i dolje
            logger.Log("ljetooo", MessageType.ERROR);  

        }
        
        public static void Run6and7()
        {
            StringChecker digit = new StringDigitChecker();
            StringChecker length = new StringLengthChecker(3);
            StringChecker upper = new StringUpperCaseChecker();
            StringChecker lower = new StringLowerCaseChecker();

            digit.SetNext(length);
            length.SetNext(upper);
            upper.SetNext(lower);

            string[] passwd = { "Lozinka", "L1", "lozinka1", "LOZINKA2", "Lozinka1" };

            foreach (string p in passwd)
            {
                Console.WriteLine("Checking " + p + " is " + digit.Check(p));
            }

            PasswordValidator validator = new PasswordValidator(digit);
            validator.AddChecker(length);
            validator.AddChecker(upper);
            validator.AddChecker(lower);

            Console.WriteLine();

            foreach (string p in passwd)
            {
                Console.WriteLine("Checking " + p + " is " + validator.CheckPassword(p));
            }
        }
    }
}
