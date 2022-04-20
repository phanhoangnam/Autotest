using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using System.Net.Mail;

namespace SpecFlowCalculator.Specs.Transformer
{
    [Binding]
    public class EmailTransformer
    {
        [StepArgumentTransformation(@"(.*) email")]
        public string GenerateDynamicEmailAddress(string emailAddress)
        {
            return emailAddress.Split("@")[0] + "@" + GetRandomDomain();
        }

        private string GetRandomDomain()
        {
            return new Fixture().Create<MailAddress>().Host;
        }
    }
}
