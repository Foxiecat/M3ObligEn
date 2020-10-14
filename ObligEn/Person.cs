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

        public string GetDescription(int anId, string first, string last, int birth, int death, object father,
            object mother)
        {
            string text = "";
            //Make it flexible with if statements

            if (Id != 0) text += $"{anId}";
            if (FirstName != null) text += $"{first}";
            if (LastName != null) text += $"{last}";
            if (BirthYear != 0) text += $"{birth}";
            if (DeathYear != 0) text += $"{death}";
            if (Father != null) text += $"{father}";
            if (Mother != null) text += $"{mother}";
        }
    }
}