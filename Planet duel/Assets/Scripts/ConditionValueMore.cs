using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionValueMore : MonoBehaviour
{
    public int left = -1;
    public Functions.Condition condition = Conditions.MoreThan;
    public int right;
    public Functions.Iterator iterator;
}
