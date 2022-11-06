using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionValueLessHP : MonoBehaviour
{
    public int left = 50;//cica HP
    public Functions.Condition condition = Conditions.LessThan;
    public int right;
    public Functions.Iterator iterator;
}
