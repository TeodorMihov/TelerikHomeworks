namespace TestClasses
{
    using MobilePhoneClasses;
    using System;
    using System.Collections.Generic;
    

    //7. Write a class GSMTest to test the GSM class:
    public class GSMTest
    {
        public static void GSMTesting()
        {
            //7.1 Create an array of few instances of the GSM class.
            List<GSM> phones = new List<GSM>(); 
            
            GSM firstPhone = new GSM("Nokia","China");
            GSM secondPhone = new GSM("Alcatel","China",300m,"Kalefin");
            GSM thirdPhone = new GSM("Ericsson","China",17.99m,"Kalistrati","Duracel",17,3);
            GSM fourthPhone = new GSM("Motorola", "China", 999.99m, "Bai Ivan", "Infinite", 3000000, 100000, 8, 16000);

            phones.Add(firstPhone);
            phones.Add(secondPhone);
            phones.Add(thirdPhone);
            phones.Add(fourthPhone);

            foreach (var phone in phones)
            {
                Console.WriteLine(phone);
            }

        }
    }
}
