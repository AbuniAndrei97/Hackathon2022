using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Conditions
{
    public static bool LessThan(int right, int left)
    {
        return right < left;
    }

    public static bool MoreThan(int right, int left)
    {
        return right > left;
    }

    public static bool EqualTo(int right, int left)
    {
        return right == left;
    }

    public static bool DifferentFrom(int right, int left)
    {
        return right != left;
    }
}
