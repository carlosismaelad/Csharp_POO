using System;


namespace ExerVetoresPensionato
{
    public class Rent
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Rent()
        {

        }
        public Rent(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }

    }
}