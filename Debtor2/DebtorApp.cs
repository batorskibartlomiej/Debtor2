

using Debtor.Core2;

namespace Debtor2
{
    public class DebtorApp
    {
        public BorrowerManager BorrowerManager { get; set; } = new BorrowerManager();

        public void IntroduceDebtorApp()
        {
            Console.WriteLine("Hej, witam w aplikacji dłużnik. Zapisujemy tutaj listę Twoich dłużników.");
        }

        public void AddBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika którego chccesz dodać do listy ");

            var userName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę długu ");

            var userAmount = Console.ReadLine();
            var amountInDecimal = default(decimal);

            while (!decimal.TryParse(userAmount, out amountInDecimal))
            {
                Console.WriteLine("Podano niepoprawną kwotę");
                Console.WriteLine("Podaj kwotę długu ");
                userAmount = Console.ReadLine();

            }
            BorrowerManager.AddBorrower(userName, amountInDecimal);

        }

        public void DeleteBorrower()
        {
            Console.WriteLine("Podaj nazwę dłużnika którego chccesz usunąć z listy ");

            var userName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę długu ");

            var userAmount = Console.ReadLine();

            BorrowerManager.DeleteBorrower(userName);
            Console.WriteLine("Udało się usunąć dłużnika");

        }

        public void ListAllBorrowers()
        {
            Console.WriteLine("Oto lista Twoich dłużników: ");

            foreach (var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }


        }

        public void AskForAction()
        {
            Console.WriteLine("Podaj czynność którą chcesz wykonać ");
            
            var userInput = default(string);

            while (userInput != "exit")
            {

                Console.WriteLine("add - Dodawanie dłużnika");
                Console.WriteLine("del - Usuwanie dłuznika");
                Console.WriteLine("list - Wypisywanie listy dłużnik");
                Console.WriteLine("exit - Wyjście z programu");

                userInput = Console.ReadLine();
                userInput = userInput.ToLower();

                switch (userInput)
                {
                    case "add":
                        AddBorrower();
                        break;
                    case "del":
                        DeleteBorrower();
                        break;
                    case "list":
                        ListAllBorrowers();
                        break;
                    default:
                        Console.WriteLine("Podano złą wartość");
                        break;
                } 



            } 

        }
    }

}
