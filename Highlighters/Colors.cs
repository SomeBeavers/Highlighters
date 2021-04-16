using System;

namespace Highlighters
{
    public partial class Colors
    {
        /// <summary>
        /// Comment.
        /// TODO: todo comment.
        /// BUG: test bug.
        /// </summary>
        /// <param name="delegateParameter1"></param>
        /// <param name="delegateParameter2"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        private int DelegateHandler(string delegateParameter1, Record delegateParameter2, bool b)
        {
            throw new NotImplementedException();
        }

        private int _propertyWithBackingField;
        public string AutoProperty { get; set; }
        
        public int PropertyWithBackingField
        {
            get => this._propertyWithBackingField;
            set => this._propertyWithBackingField = value;
        }

        public const bool Constant = false;

        public delegate int Del(string delegateParameter1, Record delegateParameter2);
    }

    public record Record: IInterface
    {
        public override string ToString()
        {
            Console.WriteLine("test");
            return base.ToString();
        }

        string IInterface.ImplementedInterfaceMethod(string name) => throw new NotImplementedException();

        public int NotImplementedMethod()
        {
            throw new NotImplementedException();
        }
    }

    internal enum MyEnum
    {
        A,B,C,D,E
    }
}