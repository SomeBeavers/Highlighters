namespace Highlighters
{
    interface IInterface
    {
        public string ImplementedInterfaceMethod(string name) => name;

        public int NotImplementedMethod();
    }
}