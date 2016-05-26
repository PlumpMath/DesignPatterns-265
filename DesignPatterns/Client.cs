using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public class Client
    {

        public List<Loan> loans { get; set; }
        public List<Deposit> Deposits { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Overdraft> Overdrafts { get; set; }

    }



    public class Loan
    {

        public Client client { get; set; }
    }


    public class Deposit
    {
        public Client client { get; set; }
    }


    public class Account
    {
        public Client client { get; set; }
    }


    public class Overdraft
    {
        public Client client { get; set; }
    }



    public abstract class CompanyModel
    {
        public abstract Client LoadClient();
    }

    public class OurCompany : CompanyModel
    {
        IClientBuilder loader;

        public OurCompany(IClientBuilder loader)
        {
            this.loader = loader;
        }

        public override Client LoadClient()
        {
            loader.LoadAccounts();
            loader.LoadDeposits();
            loader.LoadLoans();
            loader.LoadOverdrafts();

            return loader.GetClient;
        }
    }

    public interface IClientBuilder
    {

        void LoadLoans();
        void LoadDeposits();
        void LoadAccounts();
        void LoadOverdrafts();

        Client GetClient
        {
            get;
        }
    }

    public class ClientLoader : IClientBuilder
    {
        protected Client client;

        public ClientLoader()
        {
            this.client = new Client();
        }

        public void LoadAccounts()
        {
            client.Accounts = new List<Account>();
        }

        public void LoadDeposits()
        {
            client.Deposits = new List<Deposit>();
        }

        public void LoadLoans()
        {
            client.loans = new List<Loan>();
        }

        public void LoadOverdrafts()
        {
            client.Overdrafts = new List<Overdraft>();
        }

        public Client GetClient { get { return client; } }

    }




}
