using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForFunction : MonoBehaviour
{
    private int length;
    private Functions.Instruction instruction;

    public void GetMethod(int value)
    {
        Functions.TestCall(value);
    }

    public void SetLength(int value)
    {
        this.length = value;
    }

    public void SetInstruction(Functions.Instruction instruction)
    {
        this.instruction = instruction;
    }

    void Update()
    {
        if(length > 0 && instruction != null)
        {
            Functions.ForCard(length, 10, instruction);
        }
    }
}
