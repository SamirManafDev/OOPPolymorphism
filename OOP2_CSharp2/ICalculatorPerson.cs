using System;

namespace OOP2_CSharp
{
    interface ICalculatorable
    {
        void Name();
        void Salary();
        void VacationDays();

    }
    

    class Proqraming : ICalculatorable
    {
        //public string PersonName { get; set; }
        //public Proqraming(string personName)
        //{
        //    PersonName = personName;
        //}
        public void Name()
        {
            Console.WriteLine("SAMIR");
        }

        public void Salary()
        {
            Console.WriteLine("80 000$");
        }

        public void VacationDays()
        {
            Console.WriteLine("7 day");
        }
    }
    class Design : ICalculatorable
    {
        public void Name()
        {
            Console.WriteLine("Senani");
        }

        public void Salary()
        {
            Console.WriteLine("1000$");
        }

        public void VacationDays()
        {
            throw new NotImplementedException();
        }
    }
    class Manager : ICalculatorable
    {
        public void Name()
        {
            throw new NotImplementedException();
        }

        public void Salary()
        {
            throw new NotImplementedException();
        }

        public void VacationDays()
        {
            throw new NotImplementedException();
        }
    }

}
