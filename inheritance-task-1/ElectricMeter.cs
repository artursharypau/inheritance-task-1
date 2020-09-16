namespace inheritance_task_1
{
    class ElectricMeter
    {
        private int Bill { get; set; }

        public void Add(int quantity)
        {
            Bill += quantity;
        }

        public int Show()
        {
            return Bill;
        }
    }
}
