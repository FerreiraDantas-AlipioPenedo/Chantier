using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Workers
    {
        private string Name;
        private string Surname;
        private int Age;
        public enum Roles 
        {
            ChefDeChantier,
            Machiniste,
            OuvrierQualifié
        }

        public string Role;
           
        public Workers(string name, string surname, int age, Roles role)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Role = role.ToString();
        }
        

    }
}
