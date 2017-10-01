using System;
namespace dotnetc {
    class ExoDates {

        public void DateToday () {

            DateTime Today = DateTime.Now;

            Console.WriteLine (Today);
        }
        public void DateTomorrow () {

            DateTime Today = DateTime.Now;
            DateTime Tomorrow = Today.AddDays (1);
            Console.WriteLine (Tomorrow);
        }

        public void DateNextDays () {

            DateTime Today = DateTime.Now;
            for (int i = 0; i < 3; i++) {
                DateTime Day = Today.AddDays (i);
                Console.WriteLine (Day.DayOfWeek);
            }
        }
        public void StringToDate () {
            string stringto = "12/06/1998";
            DateTime DateFromString = Convert.ToDateTime(stringto);
            Console.WriteLine (DateFromString.Date);
        }

    }
}