

namespace Myspace
{
    internal class Men
    {
        public Men(string name, int age_)
        {
            Name = name;
            age = age_;
        }

        public string Name { get; set; }
        public int age { get; set; }

        public override string? ToString()
        {
            return "Name: " + Name + "; Age: " + age.ToString();
        }
    }
}
