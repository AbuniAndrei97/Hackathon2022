using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionValueMoreHP : MonoBehaviour
{
    public int left = 50;//cica HP
    public Functions.Condition condition = Conditions.MoreThan;
    public int right;
    public Functions.Iterator iterator;
}
