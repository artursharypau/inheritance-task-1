namespace inheritance_task_1
{
    class ElectricMeter
    {
        private int Bill { get; set; }

        public virtual void Add(int quantity)
        {
            Bill += quantity;
        }

        public virtual int Show(BillSelection selection)
        {
            return Bill;
        }

        public int ShowTotalBill()
        {
            return Bill;
        }
    }
}
