namespace TestClasses
{
    using MobilePhoneClasses;
    using System;

    //12. Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.

    public class GSMCallHistoryTest
    {
        public static void TestHistoryFunctionality()
        {
            GSM mobilePhone = new GSM("BeerPhone", "China"); //12.1 Create an instance of the GSM class.

            //12.2 Add few calls.
            mobilePhone.AddCall("0888 88 88 88", 15);
            mobilePhone.AddCall("0888 88 88 88", 26);
            mobilePhone.AddCall("0888 33 33 33", 37);

            //12.3 Display the information about the calls
            Console.WriteLine("Call history:");
            mobilePhone.PrintCallHistory();
            
            mobilePhone.RemoveTheLongestCall();

            Console.WriteLine("Call history without longest call:");
            mobilePhone.PrintCallHistory();

            mobilePhone.ClearCallsHistory();

            Console.WriteLine("Empty call history:");
            mobilePhone.PrintCallHistory();
        }
    }
}
