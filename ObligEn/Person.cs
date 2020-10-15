using System;
using System.Data.Common;
using System.Runtime.InteropServices;

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

        public string GetDescription()
        {
            var text = "";

            if (FirstName != null) text += $"{FirstName} ";
            if (LastName != null) text += $"{LastName} ";
            if (Id != 0) text += $"(Id={Id})";
            if (BirthYear != 0) text += $" Født: {BirthYear} ";
            if (DeathYear != 0) text += $"Død: {DeathYear} ";
            //Object Father's Name and Id
            if (Father != null) text += $"Far: {Father} ";
            //Object Mother's Name and Id
            if (Mother != null) text += $"Mor: {Mother}";

            return text;
        }
    }
}