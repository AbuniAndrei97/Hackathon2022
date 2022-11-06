using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfFunction : MonoBehaviour
{
    private int left;
    private Functions.Condition condition;
    private int right;
    private Functions.Instruction instruction;
    private int instructionValue;
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

    public void SetInstructionValue(int instructionValue = 0)
    {
        this.instructionValue = instructionValue;
    }

    void Update()
    {
        if(left > 0 && right> 0 && condition != null && instruction != null && instructionValue > 0 && !StopUpdate)
        {
            Functions.IfCard(left, right, condition, instructionValue, instruction);
            StopUpdate = true;
        }
    }
}
