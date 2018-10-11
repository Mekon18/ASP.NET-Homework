namespace Task1
{
    class Man
    {
        public string Name { get; set; }
        public uint Age { get; private set; }
        public uint Weight { get; set; }
        public string Gender { get; set; }

        public Man(string name, uint age, string gender, uint weight)
        {
            Name = name;
            Age = age;
            Gender = gender;
            Weight = weight;
        }

        public void Rename(string name)
        {
            Name = name;
        }

        public void SetAge(uint age)
        {
            Age = age;
        }

        public void SetWeight(uint weight)
        {
            Weight = weight;
        }
    }
}
