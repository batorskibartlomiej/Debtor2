﻿using Debtor.Core2;

namespace Debtor.Core2
{
    public class BorrowerManager
    {
        private List<Borrower> Borrowers { get; set; }


        public void AddBorrower(string name, decimal amount)
        {
            var borrower = new Borrower
            {
                Name = name,
                Amount = amount
            };
            Borrowers.Add(borrower);
        }

        public void DeleteBorrower(string name)
        {

            foreach (var borrower in Borrowers)
            {
                if (borrower.Name == name)
                {
                    Borrowers.Remove(borrower);
                    return;
                }


            }

        }

        public List<string> ListBorrowers()
        {

            var borrowersStrings = new List<string>();
            var indexer = 1;
            foreach (var borrower in Borrowers)
            {
                var borrowerString = indexer + ". " + borrower.Name + " - " + borrower.Amount + " zł";
                indexer++;
                borrowersStrings.Add(borrowerString);
            }
            return borrowersStrings;


        }
    }
}

