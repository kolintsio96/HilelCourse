namespace Dictionary
{
    internal class PhoneDirectory
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        public void Add(int key, string value) {
            if (dictionary.ContainsKey(key))
            {
                Console.WriteLine("This phone already exists");
            } else
            {
                dictionary.Add(key, value);
            }
        }

        public void RemoveByName(string name)
        {
            try
            {
                var item = dictionary.First(d => d.Value == name);
                dictionary.Remove(item.Key);
            } catch {
                Console.WriteLine($"Name {name} not found!");
            }
            
        }
        public int GetPhoneByName(string name)
        {
            try
            {
                var item = dictionary.First(d => d.Value == name);
                return item.Key;
            } catch {
                throw new Exception($"Name {name} not found!");
            }
            
        }
        public void GetAllPhones()
        {
            if ( dictionary.Count > 0 )
            {
                foreach (var item in dictionary)
                {
                    Console.WriteLine($"Phone: {item.Key}, Name: {item.Value}");
                }
            } else
            {
                Console.WriteLine("Dictionary is empty!");
            }
        }
    }
}
