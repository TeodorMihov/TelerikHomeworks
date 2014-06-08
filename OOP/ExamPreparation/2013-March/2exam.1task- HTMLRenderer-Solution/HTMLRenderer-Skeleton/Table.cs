namespace HTMLRenderer
{
    using System;

    public class Table : Element, IElement, ITable
    {
        private IElement[,] cells;
        public Table(int rows, int cols)
            : base("table")
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows { get; private set; }

        public int Cols { get; private set; }

        public IElement this[int row, int col]
        {
            get
            {
                return this.cells[row,col];
            }
            set
            {
                if (this.Rows < 0)
                {
                    throw new ArgumentNullException("Rows cannot be negative!");
                }
                if (this.Cols < 0)
                {
                    throw new ArgumentNullException("Cols cannot be negative!");
                }
                this.cells[row,col] = value;
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException("Cannot get text content of Html table!");
            }
            set
            {
                throw new InvalidOperationException("Cannot set text content of Html table!");
            }
        }

        public override System.Collections.Generic.IEnumerable<IElement> ChildElements
        {
            get
            {
                throw new InvalidOperationException("Html tables do not have child elements!");
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("Html tables do not have child elements so such cannot be added!");
        }

        public override void Render(System.Text.StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int row = 0; row < this.Rows; row++)
            {
                output.Append("<tr>");

                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append("<td>");

                    output.Append(this.cells[row, col].ToString());

                    output.Append("</td>");
                }

                output.Append("</tr>");
            }

            output.AppendFormat("</{0}>", this.Name);
        }
    }
}
