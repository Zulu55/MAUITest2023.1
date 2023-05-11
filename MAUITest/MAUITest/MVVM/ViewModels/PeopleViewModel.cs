using MAUITest.MVVM.Models;

namespace MAUITest.MVVM.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            People = new()
            {
                new Person { Name = "Juan", Age = 48, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Ledys", Age = 38, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Geralin", Age = 28, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Ronal", Age = 18, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Valery", Age = 8, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Omaira", Age = 58, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
                new Person { Name = "Martiana", Age = 18, BirthDate = new DateTime(1974, 9, 23), IsMarried =true, LunchTime = new TimeSpan(12, 30, 0), Weight = 89 },
            };
        }

        public List<Person> People { get; set; }
    }

}
