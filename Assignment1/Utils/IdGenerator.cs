using System;

class IdGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}