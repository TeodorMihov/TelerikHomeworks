namespace MobilePhoneClasses
{
    using System;
    using TestClasses;

    class MainProgram
    {
        static void Main()
        {
            GSMTest.GSMTesting(); //7.2 Display the information about the GSMs in the array

            Console.WriteLine(GSM.Iphone4S); // 7.3 Display the information about the static property IPhone4S.

            GSMCallHistoryTest.TestHistoryFunctionality();

        }
    }
}
