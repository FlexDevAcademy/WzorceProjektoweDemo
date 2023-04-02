namespace BuilderDemo
{
    public class House
    {
        public List<string> parts = new List<string>();
        public void Add(string part)
        {
            this.parts.Add(part);
        }

    }
}
