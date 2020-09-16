using System;

namespace inheritance_task_1
{
    class Floor : ElectricMeter
    {
        private readonly Apartment[] _apartments;

        public Floor()
        {
            _apartments = new Apartment[]
            {
                new Apartment(),
                new Apartment(),
                new Apartment(),
                new Apartment(),
                new Apartment(),
                new Apartment(),
            };
        }

        public void AddToTheBill(int quantity)
        {
            Console.Write("Choose an apartment (0 - 5): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _apartments[index].Add(quantity);
                Add(quantity);
            }
        }

        public int ShowTheBillOfOneApartment()
        {
            Console.Write("Choose an apartment (0 - 5): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                return _apartments[index].Show();
            }

            return default;
        }

        public int ShowTheTotalBillOfTheFloor()
        {
            return Show();
        }
    }
}
