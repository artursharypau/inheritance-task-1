using System;

namespace inheritance_task_1
{
    class House : ElectricMeter
    {
        private readonly Entrance[] _entrances;

        public House()
        {
            _entrances = new Entrance[]
            {
                new Entrance(),
                new Entrance(),
                new Entrance(),
                new Entrance(),
                new Entrance(),
            };
        }

        public void AddToTheBill()
        {
            var quantity = EnterTheAmount();

            Console.Write("Choose an entrance (0 - 4): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _entrances[index].AddToTheBill(quantity);
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
                    _entrances[index].ShowTheBill(selection),

                    OperationSelection.FloorBill =>
                    _entrances[index].ShowTheBill(selection),

                    OperationSelection.EntranceBill =>
                    _entrances[index].ShowTheTotalBillOfTheEntrance(),

                    _ => throw new Exception(),
                };
            }

            return default;
        }

        public int ShowTheTotalBillOfTheHouse()
        {
            return Show();
        }

        private int EnterTheAmount()
        {
            Console.Write("Make payment: ");

            if (Int32.TryParse(Console.ReadLine(), out int quantity) &&
                quantity <= Int32.MaxValue &&
                quantity > 0)
            {
                return quantity;
            }

            throw new InvalidOperationException();
        }
    }
}
