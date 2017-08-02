namespace design_patterns.FactoryPattern
{
    using System;

    public static class Factory
    {
        public static FactoryModel Create(string name, int length)
        {
            if (string.IsNullOrEmpty(name)) { throw new ArgumentNullException(nameof(name)); }

            return new FactoryModel
            {
                Name = name,
                Length = length
            };
        }
    }
}