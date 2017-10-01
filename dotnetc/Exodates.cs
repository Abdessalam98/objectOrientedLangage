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
            string stringto = "06/12/1998";
            DateTime DateFromString = DateTime.ParseExact(stringto, "dd/MM/yyyy", null);
            Console.WriteLine (DateFromString);
        }

    }
}