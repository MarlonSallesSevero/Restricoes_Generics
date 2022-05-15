using System;
using System.Collections.Generic;
namespace Services
{
    internal class CalculationService
    {
        public int Max(List<int> list)
        {
            if(list == null)
            {
                throw new ArgumentException("Lista nula, nao existe itens na mesma");
            }

            int max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i] > max)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
