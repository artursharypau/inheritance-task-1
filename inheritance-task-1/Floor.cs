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

        public override void Add(int quantity)
        {
            Console.Write("Choose an apartment (0 - 5): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                _apartments[index].Add(quantity);
                base.Add(quantity);
            }
        }

        public override int Show(BillSelection selection)
        {
            if (selection == BillSelection.FloorBill)
            {
                return ShowTotalBill();
            }

            Console.Write("Choose an apartment (0 - 5): ");

            if (Int32.TryParse(Console.ReadLine(), out int index))
            {
                return selection switch
                {
                    BillSelection.ApartmentBill =>
                    _apartments[index].Show(selection),

                    _ => throw new Exception(),
                };
            }

            return default;
        }
    }
}
