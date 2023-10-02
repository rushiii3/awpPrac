using System;
    public delegate void BirthdayEventHandler(DateTime birthday);
    public class BirthdayCalculator
    {
        public event BirthdayEventHandler BirthdayEvent;
        public void CalculateAge(DateTime birthday)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthday.Year;
            Console.WriteLine($"Your age is: {age}");
            OnBirthdayEvent(birthday);
        }
        protected virtual void OnBirthdayEvent(DateTime birthday)
        {
            if (BirthdayEvent != null)
            {
                BirthdayEvent(birthday);
            }
        }
}
    class Prac2c1
    {
        public static void BirthdayEventHandlerMethod(DateTime birthday)
    {
        Console.WriteLine("Happy Birthday! You were born on {0}.",birthday);
    }
        static void Main(string[] args)
        {
            BirthdayCalculator calculator = new BirthdayCalculator();
            calculator.BirthdayEvent += BirthdayEventHandlerMethod;
            Console.Write("Enter your birthday (yyyy-mm-dd): ");
            DateTime birthday = Convert.ToDateTime(Console.ReadLine());
            calculator.CalculateAge(birthday);
        }
    }

// Enter your birthday (yyyy-mm-dd): 2003-03-27
// Your age is: 20
// Happy Birthday! You were born on 03/27/2003 00:00:00.
