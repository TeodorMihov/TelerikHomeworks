namespace MobilePhoneClasses
{
    using System;

 //8. Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone number and duration (in seconds).

    internal class Call
    {
        public Call(DateTime date, string dialedPhone,  ulong callDuration)
        {
            this.Date = date;
            this.CallDuration = callDuration;
            this.DialedPhone = dialedPhone;
        }

        public DateTime Date { get; private set; }

        public string DialedPhone { get; private set; }

        public ulong CallDuration { get; private set; }
    }
}
