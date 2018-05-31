using System;

namespace Basket
{
    public struct BasketLineArticle
    {
        public string Id { get; set; }
        public int Number { get; set; }
        public string Label { get; set; }

        public static object First(Func<object, bool> func)
        {
            throw new NotImplementedException();
        }
    }
}