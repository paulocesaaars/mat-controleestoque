﻿namespace MAT.ControleEstoque.Business.ValueObjects.Product
{
    public class SuggestedPrice
    {
        private const string INVALID_VALUE_NULL = "Informe o valor de venda desse produto";
        public float Value { get; private set; }

        public SuggestedPrice(float value)
        {
            if (value == null)
                throw new ArgumentException(INVALID_VALUE_NULL);

            Value = value;
        }
    }
}
