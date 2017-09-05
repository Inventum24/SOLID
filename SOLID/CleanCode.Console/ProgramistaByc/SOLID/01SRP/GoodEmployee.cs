using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.Console.ProgramistaByc.SOLID._01SRP
{

class GoodEmployee
    {
        private readonly string _email;
        private readonly int _salary;
        private readonly ValidityTool _validityTool;
        private string _name;
        private string _surname;


        public GoodEmployee(string name, string surname, string email, byte salary)
        {
            _salary = salary;
            _email = email;
            _name = name;
            _surname = surname;

            _validityTool = new ValidityTool();
        }

        private string ValidateEmail()
        {
            return _validityTool.ValidateEmail(_email);
        }

        private bool IsAdult()
        {
            return _validityTool.CheckSalary(_salary);
        }
    }

    class ValidityTool
    {
        private readonly int _salaryThreshold = 2500;

        public string ValidateEmail(string email)
        {
            string message = string.Empty;

            if (string.IsNullOrWhiteSpace(email))
                message += "brak emaila, ";

            if (!email.Contains("@"))
                message += "niepoprawna email, ";


            return message;
        }

        public bool CheckSalary(int salary)
        {
            return salary >= _salaryThreshold;
        }
    }
}
