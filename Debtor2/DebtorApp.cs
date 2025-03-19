

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

        public void AddBorrowe()
        {
            Console.WriteLine("Podaj nazwę dłużnika którego chccesz dodać do listy ");

            var userName = Console.ReadLine();

            Console.WriteLine("Podaj kwotę długu ");

            var userAmount = Console.ReadLine();
            var amountInDecimal = default(decimal);

            while (!decimal.TryParse(userAmount, out  amountInDecimal ))
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

        public void ListAllBorrower()
        {
            Console.WriteLine("Oto lista Twoich dłużników: ");
           
            foreach(var borrower in BorrowerManager.ListBorrowers())
            {
                Console.WriteLine(borrower);
            }
            

        }

        public void AskForAction()
        {

        }

    }
}
