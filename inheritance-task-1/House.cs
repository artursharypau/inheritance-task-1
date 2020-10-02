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

        public override void Add(int quantity)
        {
            Console.Write("Choose an entrance (0 - 4): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _entrances[index].Add(quantity);
                base.Add(quantity);
            }
        }

        public override int Show(BillSelection selection)
        {
            if (selection == BillSelection.HouseBill)
            {
                return ShowTotalBill();
            }

            Console.Write("Choose an entrance (0 - 4): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                return selection switch
                {
                    BillSelection.ApartmentBill =>
                    _entrances[index].Show(selection),

                    BillSelection.FloorBill =>
                    _entrances[index].Show(selection),

                    BillSelection.EntranceBill =>
                    _entrances[index].Show(selection),

                    _ => throw new Exception(),
                };
            }

            return default;
        }
    }
}
