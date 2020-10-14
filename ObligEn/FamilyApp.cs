using System.Collections.Generic;
using System.Data.Common;

namespace ObligEn
{
    //make a new list
    public FamilyApp(params Person[] people)
    {
    _people = new List<Person>(people);
    }
    public class FamilyApp
    {
        //CommandPrompt "vis, hjelp, liste"
    }
}