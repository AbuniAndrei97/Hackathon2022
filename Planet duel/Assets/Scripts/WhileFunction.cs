using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileFunction : MonoBehaviour
{
    private int left;
    private Functions.Condition condition;
    private int right;
    private Functions.Instruction instruction;
    private int instructionValue;
    private Functions.Iterator iterator;
    private bool StopUpdate = false;


    public void SetLeft(int left)
    {
        this.left = left;
    }

    public void SetRight(int right)
    {
        this.right = right;
    }

    public void SetCondition(Functions.Condition condition)
    {
        this.condition = condition;
    }

    public void SetInstruction(Functions.Instruction instruction)
    {
        this.instruction = instruction;
    }

    public void SetInstructionValue(int instructionValue)
    {
        this.instructionValue = instructionValue;
    }

    public void SetIterator(Functions.Iterator iterator)
    {
        this.iterator = iterator;
    }

    void Update()
    {
        if(left > 0 && right> 0 && condition != null && instruction != null && instructionValue > 0 && iterator != null && !StopUpdate)
        {
            Functions.WhileCard(left, right, condition, instructionValue, instruction, iterator);
            StopUpdate = true;
        }
    }
}
