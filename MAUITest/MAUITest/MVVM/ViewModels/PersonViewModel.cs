using MAUITest.MVVM.Models;

namespace MAUITest.MVVM.ViewModels
{
    public class PersonViewModel
    {
        public PersonViewModel()
        {
            Person = new Person
            {
                Name = "Juan Zuluaga",
                Age = 48,
                BirthDate = new DateTime(1974, 9, 23),
                IsMarried = true,
                LunchTime = new TimeSpan(12, 30, 0),
                Weight = 89
            };
        }

        public Person Person { get; set; }
    }
}
