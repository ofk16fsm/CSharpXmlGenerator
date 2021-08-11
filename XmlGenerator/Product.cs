namespace XmlGenerator
{
    struct Product
    {
        private int id;
        private string name;
        private int price;
        private string type;
        private int playtime;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public string Type { get => type; set => type = value; }
        public int Playtime { get => playtime; set => playtime = value; }
       
    }
}
