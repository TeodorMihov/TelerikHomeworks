namespace MobilePhoneClasses
{
    using System;
    using System.Collections.Generic;

    public class GSM //1. Define class GSM holds model, manufacturer, price, owner, battery characteristics and display characteristics
    {
        #region Fields
        //6. Add a static field IPhone4S in the GSM class to hold the information about iPhone 4S
        private static GSM iPhone4S = new GSM("Iphone 4S","Apple",450m,"No owner","Rechargeable",200,8,4,160000); 

        private string manufacturer;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        #endregion

        //2. Define several constructors. Model and manufacturer are mandatory.
        #region Constructors
        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = 0;
            this.Owner = "No owner!";
            this.battery = new Battery("No model", 0, 0);
            this.display = new Display(0, 0);
            this.CallHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, decimal price, string owner)
            : this(model, manufacturer)
        {
            this.price = price;
            this.owner = owner;
        }

        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, ulong hoursIdle, ulong hoursTalk)
            : this(model, manufacturer, price, owner)
        {
            this.battery = new Battery(batteryModel, hoursIdle, hoursTalk);
        }

        public GSM(string model, string manufacturer, decimal price, string owner, string batteryModel, ulong hoursIdle, ulong hoursTalk, ulong size, ulong numberOfColors)
            :this(model,manufacturer,price,owner,batteryModel,hoursIdle,hoursTalk)
        {
            this.display = new Display(size, numberOfColors);
        }
        #endregion

        //5. Use properties to encapsulate the data fields inside the GSM
        #region Property
        public static GSM Iphone4S 
        {
            get
            {
                return GSM.iPhone4S;  //Add a static property IPhone4S in the GSM class to hold the information about iPhone 4S
            }
        }

        public string Model { get; set; }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {

                    throw new ArgumentException("Enter correct manufacturer!");
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public decimal Price
        {
            
            get 
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enter correct owner!");
                }
            }
        }

        private List<Call> CallHistory //9. Add a property CallHistory in the GSM class. Use the system class List<Call>
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                this.callHistory = value;
            }
        }
        #endregion

        //10. Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
        public void AddCall(string number, ulong callDuration)
        {
            this.callHistory.Add(new Call(DateTime.Now,number,callDuration));
        }

        public void DeleteCall(int index)
        {
            this.callHistory.RemoveAt(index);
        }

        public void ClearCallsHistory()
        {
            this.callHistory.Clear();
        }

        //11. Add a method that calculates the total price of the calls. Assume the price per minute is fixed and is provided as a parameter.
        public decimal PriceOfCalls()
        {
            decimal priceOfSecond = 0.37m / 60;

            ulong callTime = 0;
            
            foreach (var call in callHistory)
            {
                callTime += call.CallDuration;
            }

            decimal priceOfCalls = callTime * priceOfSecond;
            
            return priceOfCalls;
        }

        //12.4 Remove the longest call from the history and calculate the total price again.
        public void RemoveTheLongestCall()
        {
            ulong maxCallDuration = 0;
            int longestCallIndex = 0;

            for (int currentIndex = 0; currentIndex < this.callHistory.Count; currentIndex++)
            {
                ulong currentCallDuration = this.callHistory[currentIndex].CallDuration;
                if (currentCallDuration > maxCallDuration)
                {
                    maxCallDuration = currentCallDuration;
                    longestCallIndex = currentIndex;
                }
            }
            callHistory.RemoveAt(longestCallIndex);
        }

        public void PrintCallHistory()
        {
            foreach (var call in this.CallHistory)
            {
                Console.WriteLine(call.CallDuration);
            }
        }
        public override string ToString() //4. Add a method in the GSM class for displaying all information about it
        {
            return string.Format("GSM model: {0}\nManufacturer: {1}\nOwner: {2}\nPrice: {3}\n{4}\n{5}\n\n", this.Model, this.Manufacturer, this.Owner, this.Price, this.battery, this.display);
        }
    }
}
