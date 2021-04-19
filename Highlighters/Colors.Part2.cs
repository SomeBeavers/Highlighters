using System;

namespace Highlighters
{
    public partial class Colors : ColorsBase
    {
        public void Use()
        {
            new NullableStruct().Nullable1(parameterRecord:new Record());
            AutoProperty = "";
            Console.WriteLine(PropertyWithBackingField);
            Console.WriteLine(PropertyWithBackingField);
            Console.WriteLine(PropertyWithBackingField);
#pragma warning disable 219
            MyEnum enum1 = MyEnum.E;
#pragma warning restore 219
            Del delegateHandler = (delegateParameter1, delegateParameter2) =>
                DelegateHandler(delegateParameter1, delegateParameter2, Constant);
        }
    }
}