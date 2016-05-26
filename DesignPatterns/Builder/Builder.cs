using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    class Builder
    {
        void Caller()
        {
            IClientBuilder builder = new ClientLoader();
            CompanyModel company = new OurCompany(builder);

            Client client = company.LoadClient();

        }
    }







}
