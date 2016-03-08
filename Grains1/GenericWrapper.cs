using System;

namespace Grains1
{
    [Serializable]
    public class GenericWrapper<T>
    {
         public T Content { get; set; }
    }
}