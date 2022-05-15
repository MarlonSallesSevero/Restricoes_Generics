using System;
using System.Collections.Generic;
namespace Services
{
    internal class CalculationService
    {
        public Generico Max<Generico>(List<Generico> list) where Generico : IComparable //Criando um metodo Generico
        {
            if (list == null)
            {
                throw new ArgumentException("Lista nula, nao existe itens na mesma");
            }

            Generico max = list[0];
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;
        }
    }
}
