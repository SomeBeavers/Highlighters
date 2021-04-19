using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Buffers;

namespace Highlighters
{
    // Class Identifier
    public class ColorsBase
    {
        public virtual void OverrideMe()
        {
        
            
            }

        private const int Test = 1;
        private void TTTT()
        {
        }
    }

    public partial class Colors:IDisposable
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
            foreach (var s in new List<string>().Where(x => x == String.Empty))
            {
                return s.Length;
            }

            throw new NotImplementedException();
        }

        private int _propertyWithBackingField;
        public string AutoProperty { get; set; }
        
        public int PropertyWithBackingField
        {
            // Accessor Identifier
            get => this._propertyWithBackingField;
            set => this._propertyWithBackingField = value;
        }

        // Constant Identifier
        public const bool Constant = false;

        public delegate int Del(string delegateParameter1, Record delegateParameter2);

        public event Del SomeEvent;

        public void Dispose()
        {
        }

        public override void OverrideMe()
        {
            base.OverrideMe();
        }
    }

    public static class StaticClass
    {
        public static void StaticMethod()
        {
            string stringVariable = "Console.WriteLine(\"test\");";
        }

        public static void StaticMethodUsage()
        {
            StaticMethod();
        }
    }

    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public record Record(string Surname, string Name): IInterface
    {
        public Record(string name) : this(name, "Doe")
        {
            // comment
            Name = name;
        }

        public Record() : this("", "")
        {
        }

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

        public void Method2()
        {
            throw new NotImplementedException();
            Console.WriteLine("test");
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }

    internal enum MyEnum
    {
        A,
        B,
        C,
        D,
        E
    }

    #nullable enable annotations
    struct NullableStruct
    {
        public static decimal CalculateToll(object vehicle) =>
            vehicle switch
            {
                DeliveryTruck { GrossWeightClass1: > 5000 } => 10.00m + 5.00m,
                DeliveryTruck { GrossWeightClass1: < 3000 } => 10.00m - 2.00m,
                DeliveryTruck _ => 10.00m,

                _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
            };

        //parameterRecord 
        public void Nullable1(Record? parameterRecord, MyEnum enuEnum)
        {
            object a = null;
            CalculateToll(vehicle: null!);
            if (parameterRecord == null) throw new ArgumentNullException(nameof(parameterRecord));
            var valueTuple = (enuEnum, true);
            if (valueTuple is (MyEnum.A, _))
            {
            }
            else switch (enuEnum, true)
            {
                case (MyEnum.B, _):
                    break;
                case (MyEnum.D, _):
                    break;
                case (MyEnum.C, _):
                case (MyEnum.E, _):
                    break;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(enuEnum), enuEnum, null);
            }
        }
    }

    internal abstract class DeliveryTruck
    {
        public int GrossWeightClass1
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}