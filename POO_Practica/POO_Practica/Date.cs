namespace POO_Practica
{
    public class Date //cambiar palabra reservada private a public
    {
        //Declarar atributos
        private int _year;
        private int _month;
        private int _day;

        //crear constructor ctor y presiono tab tab
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = Checkmonth(month);
            _day = Checkday(year, month, day);
    
        }

        private int Checkday(int year, int day, int month)//Chequear año biciesto
        {
            if (month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }

            int[] daysPermonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(day >= 1 && day <= daysPermonth[month])
            {
                return day;
            }


            throw new DayExcepcion("Invalid day");
        }

        private bool IsleapYear(int year)
        {
            
            return year % 400 ==0 || year % 4 == 0 && year % 100 != 0;


            throw new NotImplementedException();
        }

        private int Checkmonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthExcepcion($"Invalid month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}"; //realizar interpolacion de string en C#
        }

    }
}
