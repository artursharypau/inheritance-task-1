using System;

namespace inheritance_task_1
{
    class Entrance : ElectricMeter
    {
        private readonly Floor[] _floors;

        public Entrance()
        {
            _floors = new Floor[]
            {
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
                new Floor(),
            };
        }

        public void AddToTheBill(int quantity)
        {
            Console.Write("Choose a floor (0 - 8): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _floors[index].AddToTheBill(quantity);
                Add(quantity);
            }
        }

        public int ShowTheBill(OperationSelection selection)
        {
            Console.Write("Choose an entrance (0 - 4): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                return selection switch
                {
                    OperationSelection.ApartmentBill => 
                    _floors[index].ShowTheBillOfOneApartment(),

                    OperationSelection.FloorBill => 
                    _floors[index].ShowTheTotalBillOfTheFloor(),

                    _ => throw new Exception(),
                };
            }

            return default;
        }

        public int ShowTheTotalBillOfTheEntrance()
        {
            return Show();
        }
    }
}
