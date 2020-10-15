using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace ObligEn
{
    
    //make a new list
    public class FamilyApp
    {
        
        public FamilyApp(params Person[] people)
        {
            
        // _people = new List<Person>(people);
        }
    
        //CommandPrompt "vis, hjelp, liste"
        public const string CommandPrompt = "What Would You Like To Do ";

        public static string HandleCommand(string command)
        {
            command = command.ToLower();
            if (command == "hjelp")
            {
                return "vis <id> = Vise en bestemt person. \n" +
                       "hjelp = Viser alle kommandoene. \n" +
                       "liste = lister alle personer som finner i registeret.";
            }

            if (command == "vis")
            {
                
            }
            return "uskjent kommando";
        }

        //WelcomeMessage
        public string WelcomeMessage = "Welcome!";
        //HandleCommand
    }
}