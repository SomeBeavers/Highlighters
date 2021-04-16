using System;

namespace Highlighters
{
    public partial class Colors
    {
        public void Use()
        {
            AutoProperty = "";
            Console.WriteLine(PropertyWithBackingField);
#pragma warning disable 219
            MyEnum enum1 = MyEnum.E;
#pragma warning restore 219
            Del delegateHandler = (delegateParameter1, delegateParameter2) =>
                DelegateHandler(delegateParameter1, delegateParameter2, Constant);
        }
    }
}