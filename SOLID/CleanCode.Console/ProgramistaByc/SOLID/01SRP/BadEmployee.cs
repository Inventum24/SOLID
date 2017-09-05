using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._01SRP
{
    /// <summary>
    /// Classes have two responsibilities: store data and validate data
    /// </summary>
    class BadEmployee
    {
        private readonly string _email;
        private readonly int _salary;
        private string _name;
        private string _surname;
        private int _salaryThreshold;

        public BadEmployee(string name, string surname, string email, int salary)
        {
            _salary = salary;
            _email = email;
            _name = name;
            _surname = surname;
        }

        private string ValidateEmail()
        {
            string message = string.Empty;

            if (string.IsNullOrWhiteSpace(_email))
                message += "brak emaila, ";

            if (!_email.Contains("@"))
                message += "niepoprawny email, ";


            return message;
        }

        private bool CheckSalary()
        {
            return _salary >= _salaryThreshold;
        }
    }
}
