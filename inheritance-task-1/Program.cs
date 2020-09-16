using System;

namespace inheritance_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChooseOperation();
        }

        public static House ChooseOperation()
        {
            var house = new House();
            OperationSelection selection = default;

            while (true)
            {
                Console.Write("1. To pay the electric bill.\t");
                Console.WriteLine("2. View the electric bill of one apartment.\t");
                Console.Write("3. View the electric bill of one floor.\t");
                Console.WriteLine("4. View the electric bill of one entrance.\t");
                Console.WriteLine("5. View the electric bill of the whole house.\t");
                Console.Write("Choose an operation (1 - 5): ");

                switch (selection = (OperationSelection)Enum.Parse(
                    typeof(OperationSelection),
                    Console.ReadLine()))
                {
                    case OperationSelection.AddToTheBill:
                        house.AddToTheBill();
                        break;

                    case OperationSelection.ApartmentBill:
                        Console.WriteLine(house.ShowTheBill(selection));
                        break;

                    case OperationSelection.FloorBill:
                        Console.WriteLine(house.ShowTheBill(selection));
                        break;

                    case OperationSelection.EntranceBill:
                        Console.WriteLine(house.ShowTheBill(selection));
                        break;

                    case OperationSelection.HouseBill:
                        Console.WriteLine(house.ShowTheTotalBillOfTheHouse());
                        break;

                    default:
                        return house;
                }

                Console.WriteLine();
            }
        }

    }
}
