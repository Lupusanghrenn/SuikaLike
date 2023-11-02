using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FruitID : IEquatable<FruitID>
{
    public string ID;

public override bool Equals(object obj)
    {
        return Equals(obj as FruitID);
    }

    public bool Equals(FruitID other)
    {
        return other is not null &&
               ID == other.ID;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(ID);
    }

    public static bool operator ==(FruitID left, FruitID right)
    {
        return EqualityComparer<FruitID>.Default.Equals(left, right);
    }

    public static bool operator !=(FruitID left, FruitID right)
    {
        return !(left == right);
    }
}
