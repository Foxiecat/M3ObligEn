using System;
using System.Collections.Generic;

namespace ObligEn
{
    //make a new list
    public class FamilyApp
    {
        //CommandPrompt "vis, hjelp, liste"
        public const string CommandPrompt = "What Would You Like To Do ";

        public static List<Person> _people;

        //WelcomeMessage
        public string WelcomeMessage = $"Welcome {_people}";

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        //HandleCommand
        public static string HandleCommand(string command)
        {
            var com = command.ToLower();
            var vis = com.Substring(0, 3);
            var tempId = com.Substring(4, 0);
            var id = int.Parse(tempId);

            switch (com)
            {
                case "hjelp":
                    return "vis <id> = Vise en bestemt person. \n" +
                           "hjelp = Viser alle kommandoene. \n" +
                           "liste = lister alle personer som finner i registeret.";
                case "liste":
                    
                    break;
            }


            if (vis == "vis" && id != 0)
            {
                //For/Foreach Person in _people, if father.Id = Person.Id then display under child
            }

            return "uskjent kommand";
        }
    }
}