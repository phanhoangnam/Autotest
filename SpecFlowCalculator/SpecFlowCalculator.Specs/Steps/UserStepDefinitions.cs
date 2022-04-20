using AutoFixture;
using TechTalk.SpecFlow;
using Xunit.Abstractions;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class UserStepDefinitions
    {
        private readonly ITestOutputHelper _outputHelper;

        public UserStepDefinitions(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Given(@"I enter random user data")]
        public void GivenIEnterRandomUserData()
        {
            var person = new Fixture()
                .Build<User>()
                .With(x => x.Email, "nam@gmail.com")
                .Create();

            _outputHelper.WriteLine($"The user {person.Name} has email {person.Email} and his address {person.Address} with phone number {person.Phone}");
        }

        [Given(@"I input dynamic domain for (.* email)")]
        public void GivenIInputDynamicDomainForNamGmail_ComEmail(string email)
        {
            _outputHelper.WriteLine($"The random email address is: {email}");
        }

    }

    public record User
    {
        public string Name { get; init; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
    }
}
