using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionValueLess : MonoBehaviour
{
    public int left = -1;
    public Functions.Condition condition = Conditions.LessThan;
    public int right;
    public Functions.Iterator iterator;
}
