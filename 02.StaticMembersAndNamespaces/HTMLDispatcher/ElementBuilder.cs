using System;

namespace HTMLDispatcher
{
    public class ElementBuilder
    {
        private string elementName;
        private string element;

        public ElementBuilder(string elementName)
        {
            this.ElementName = elementName;
        }

        public string ElementName
        {
            get
            {
                return this.elementName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ElementName", "ElementName cannot be null or an empty string.");
                }

                this.elementName = value;
            }
        }

        public void AddAttribute(string attribute, string value)
        {
            
        }
    }
}