namespace MobilePhoneClasses
{
    using System;

    internal class Display //1. Define class display. Dispaly characteristics(size and number of colors)
    {
        public Display(ulong size, ulong numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        //5. Use properties to encapsulate the data fields inside display
        public ulong Size { get; set; }
        public ulong NumberOfColors { get; set; }

        public override string ToString()
        {
            return string.Format("Display size(inches): {0}\nDisplay number of colors: {1}", this.Size, this.NumberOfColors);
        }
    }
}
