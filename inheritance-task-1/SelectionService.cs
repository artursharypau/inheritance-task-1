using System;

namespace inheritance_task_1
{
    class SelectionService
    {
        public House SelectOperation()
        {
            var house = new House();

            while (true)
            {
                Console.WriteLine("1. To pay the electric bill.");
                Console.WriteLine("2. View the electric bill of: ");
                Console.Write("Choose an operation: ");

                switch (Enum.Parse(
                    typeof(OperationSelection),
                    Console.ReadLine()))
                {
                    case OperationSelection.Add:
                        var quantity = EnterTheAmount();
                        house.Add(quantity);
                        break;

                    case OperationSelection.Show:
                        var bill = house.Show(ChooseBill());
                        Console.WriteLine(bill);
                        break;

                    default:
                        return house;
                }

                Console.WriteLine(new String('_', 99));
            }
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

        private BillSelection ChooseBill()
        {
            BillSelection selection = default;

            Console.WriteLine();
            Console.WriteLine("\t1. The bill of one apartment.");
            Console.WriteLine("\t2. The bill of one floor.");
            Console.WriteLine("\t3. The bill of one entrance.");
            Console.WriteLine("\t4. The bill of the whole house.");
            Console.Write("Choose the bill: ");

            return (selection = (BillSelection)Enum.Parse(
                    typeof(BillSelection),
                    Console.ReadLine())) switch
            {
                BillSelection.ApartmentBill => selection,
                BillSelection.FloorBill => selection,
                BillSelection.EntranceBill => selection,
                BillSelection.HouseBill => selection,
                _ => throw new Exception(),
            };
        }
    }
}
