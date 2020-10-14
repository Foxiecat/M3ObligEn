using System;
using System.Data.Common;

namespace ObligEn
{
    public class Person
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int BirthYear;
        public int DeathYear;
        public object Father;
        public object Mother;
        
        public object GetDescription(int anId, string first, string last, int birth, int death, object father, object mother)
        {
            Id = 1;
            Id = anId;
            FirstName = first;
            LastName = last;
            BirthYear = birth;
            DeathYear = death;
            Father = father;
            Mother = mother;
        }

        public object GetDescription()
        {
            throw new NotImplementedException();
        }
    }
}