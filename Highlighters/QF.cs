using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace Highlighters
{
    public interface QF
    {
        public void QF1([ItemCanBeNull] List<Animal> myList)
        {
            foreach (var animal in myList)
            {
                if (animal == null)
                {
                    continue;
                }

                var nameLength = animal.Name.Length;
            }
        }
    }

    [UsedImplicitly]
    public class Animal
    {
        public string Name { get; set; }
    }
}