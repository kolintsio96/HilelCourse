namespace Address
{
    internal class Address
    {
		private string index;

		public string Index
		{
			get { return index; }
			set { if (value.Length == 5) index = value; }
		}

        private string city = "";

        public string City
        {
            get { return city; }
            set { if (!String.IsNullOrEmpty(value)) city = value; }
        }
        
        private string country = "";

        public string Country
        {
            get { return country; }
            set { if (!String.IsNullOrEmpty(value)) country = value; }
        }
        
        private string street = "";

        public string Street
        {
            get { return street; }
            set { if (!String.IsNullOrEmpty(value)) street = value; }
        }
        
        private int house;

        public int House
        {
            get { return house; }
            set { if (value > 0) house = value; }
        }
        
        private int apartment;

        public int Apartment
        {
            get { return apartment; }
            set { if (value > 0) apartment = value; }
        }

        public string GetAddress()
        {
            string fullAddress = $"{House} {Street} {Apartment}, {City}, {Country}, {Index}";
            return fullAddress;

        }

    }
}
