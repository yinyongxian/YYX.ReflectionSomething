namespace YYX.ReflectionSomething.Classes
{
    class Derived:Base
    {
        private string name;

        //public Derived(string name)
        //{

        //}

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
