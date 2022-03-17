using System.Data;

namespace POO_Practica
{
    public class Date //cambiar palabra reservada private a public
    {
        //----------------------Declarar atributos------------------------------------------
        private int _year;
        private int _month;
        private int _day;

        //----------------crear constructor ctor y presiono tab tab--------------------------
        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = CheckDay(year, month, day);
        }

        private int CheckDay(int year, int month, int day)//Chequear año biciesto------------------
        {
            if (month == 2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DataException("Invalid day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //if (year % 4 == 0)
            //{
            //    if (year % 100 == 0)
            //    {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    return false;
            //}
        }

        private int CheckMonth(int month)
        {
            if (month >= 1 && month <= 12)
            {
                return month;
            }

            throw new MonthExcepcion($"Invalid month");
        }

        public override string ToString()
        {
            //realizar interpolación de string en C#------------------------------------------
            return $"{_year}/{_month:00}/{_day:00}";
        }

    }
}
