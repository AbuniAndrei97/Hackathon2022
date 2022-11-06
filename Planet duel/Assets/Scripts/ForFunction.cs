using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForFunction : MonoBehaviour
{
    private int length;
    private int instructionValue;
    private Functions.Instruction instruction;
    private bool StopUpdate = false;

    public void SetLength(int length)
    {
        this.length = length;
    }

    public void SetInstructionValue(int instructionValue = 0)
    {
        this.instructionValue = instructionValue;
    }
    
    public void SetInstruction(Functions.Instruction instruction)
    {
        this.instruction = instruction;
    }

    void Update()
    {
        if(length > 0 && instruction != null && !StopUpdate)
        {
            Functions.ForCard(length, instructionValue, instruction);
            StopUpdate = true;
        }
    }
}
