using System;
using System.Collections.Generic;
using System.Linq;

namespace ObligEn
{
    public class FamilyApp
    {
        //CommandPrompt "vis, hjelp, liste"
        public const string CommandPrompt = "What Would You Like To Do ";

        private static List<Person> _people;

        //WelcomeMessage
        public string WelcomeMessage = "Welcome";

        public FamilyApp(params Person[] people)
        {
            _people = new List<Person>(people);
        }

        //HandleCommand
        public object HandleCommand(string command)
        {
            var com = command.ToLower();
            var vis = com.Substring(0, 3);
            

            switch (com)
            {
                case "hjelp":
                    return "vis <id> = Vise en bestemt person. \n" +
                           "hjelp = Viser alle kommandoene. \n" +
                           "liste = lister alle personer som finner i registeret.";
                case "liste":
                {
                    foreach (var peoples in _people)
                    {
                        Console.WriteLine(peoples.GetDescription());
                    }
                    break;
                }
            }
            
            var tempId = com.Substring(4, 0); 
            var id = int.Parse(tempId);
            
            if (vis == "vis" && id != 0)
            {
                
                foreach (var peoples in _people.Where(peoples => peoples.Id == id))
                {
                    Console.WriteLine(peoples.GetDescription() + "\n" + "Barn:");
                    
                    foreach (var child in _people)
                    {
                        if (child.Father != null)
                        {
                            if(child.Father.Id == id) Console.WriteLine(child.GetDescription());
                        }
                        if (child.Mother != null)
                        {
                            if(child.Mother.Id == id) Console.WriteLine(child.GetDescription());
                        }
                    }
                }
            }
            return "";
        }
    }
}