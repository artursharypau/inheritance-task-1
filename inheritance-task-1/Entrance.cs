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

        public override void Add(int quantity)
        {
            Console.Write("Choose a floor (0 - 8): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _floors[index].Add(quantity);
                base.Add(quantity);
            }
        }

        public override int Show(BillSelection selection)
        {
            if (selection == BillSelection.EntranceBill)
            {
                return ShowTotalBill();
            }

            Console.Write("Choose a floor (0 - 4): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                return selection switch
                {
                    BillSelection.ApartmentBill =>
                    _floors[index].Show(selection),

                    BillSelection.FloorBill =>
                    _floors[index].Show(selection),

                    _ => throw new Exception(),
                };
            }

            return default;
        }
    }
}
