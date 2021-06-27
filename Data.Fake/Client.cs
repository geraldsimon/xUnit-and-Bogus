using System;

namespace Data.Fake
{
    public class Client
    {
        public Client(Guid id,
            string firstName,
            string lastName,
            string gender,
            DateTime birthday,
            string phone,
            decimal salary
            )
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Birthday = birthday;
            Phone = phone;
            Salary = salary;
        }

        public Guid ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public decimal Salary { get; set; }
        public string Email { get; set; }
    }
}