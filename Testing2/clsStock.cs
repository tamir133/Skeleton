using System;

namespace Testing2
{
    class clsStock
    {
        public clsStock()
        {
        }

        public bool Available { get; internal set; }
        public int StockID { get; internal set; }
        public string StockName { get; internal set; }
        public DateTime DateAdded { get; internal set; }
        public int StockQuantity { get; internal set; }
        public decimal Price { get; internal set; }

        private Int32 mStockID;
        public Int32 StockID
        {
            get
            {
                return mStockID;
            }
            set
            {
                mStockID = value;
            }
        }
        private Int32 mStockName;
        public Int32 StockName
        {
            get
            {
                return mStockName;
            }
            set
            {
                mStockName = value;
            }
        }
        private Int32 mStockQuantity;
        public Int32 StockQuantity
        {
            get
            {
                return mStockQuantity;
            }
            set
            {
                mStockQuantity = value;
            }
        }
        private Int32 mDateAdded;
        public Int32 DateAdded
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        private Int32 mPrice;
        public Int32 Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
            }
        }
        private Int32 mStockAvailable;
        public Int32 StockAvailable
        {
            get
            {
                return mStockAvailable;
            }
            set
            {
                mStockAvailable = value;
            }
        }


        public bool Find(int StockID)
        {
            //set the private data members to the test data value
            mStockID = 1;
            mStockName = "Nike";
            mStockQuantity = 100;
            mDateAdded = Convert.ToDateTime("01/04/2022");
            mPrice = 100;
            mStockAvailable = 1;
    
            return true;
        }

    }
}
}