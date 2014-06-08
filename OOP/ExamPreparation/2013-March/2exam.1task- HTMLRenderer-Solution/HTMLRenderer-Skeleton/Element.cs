namespace HTMLRenderer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class Element : IElement
    {
        private IList<IElement> childElements;

        public Element(string name)
        {
            this.Name = name;
            this.childElements = new List<IElement>();
        }

        public Element(string name, string textContent)
            :this(name)
        {
            this.TextContent = textContent;
        }

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public virtual IEnumerable<IElement> ChildElements
        {
            get 
            {
                return this.childElements; 
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (this.Name != null)
            {
                output.Append("<");
                output.Append(this.Name);
                output.Append(">");
            }

            if (this.TextContent != null)
            {
                foreach (var symbol in this.TextContent)
                {
                    switch (symbol)
                    {
                        case '<':
                            output.Append("&lt");
                            break;
                        case '>':
                            output.Append("&rt");
                            break;
                        case '&':
                            output.Append("&amp");
                            break;
                        default:
                            output.Append(symbol);
                            break;
                    }
                }
            }

            foreach (var childElement in this.childElements)
            {
                childElement.Render(output);
            }

            if (this.Name != null)
            {
                output.Append("</");
                output.Append(this.Name);
                output.Append(">");
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);

            return output.ToString();
        }
    }
}
