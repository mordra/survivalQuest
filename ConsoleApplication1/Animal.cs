namespace ConsoleApplication1
{
    public class Animal : IAnimal
    {
        public string Name;

        public virtual bool IsNocturnal()
        {
            return false;
        }
    }
}