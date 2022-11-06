using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionValueEqual : MonoBehaviour
{
    public int left = -1;
    public Functions.Condition condition = Conditions.EqualTo;
    public int right;
    public Functions.Iterator iterator;
}
