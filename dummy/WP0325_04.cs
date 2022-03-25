using System;

namespace AO6O_ArraySorting
{
    class Car
    {
        int carNumber;
        DateTime inTime;
        DateTime outTime;

        public void SetInTime()
        {
            this.inTime = DateTime.Now;
        }

        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }


        public static void Main(string[] arg)
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

        }


    }
}