using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Functions
{
    public delegate void Instruction(int value);
    public delegate bool Condition(int value1, int value2);
    public delegate int Iterator(int value);
    
    public static void ForCard(int length, int instructionValue, Instruction instruction)
    { 
        for(int i = 0; i < length; i++)
        {
            instruction(instructionValue);
        }
    }

    public static void IfCard(int value1, int value2, Condition condition, int intructionValue, Instruction instruction)
    {
        if(condition(value1, value2))
        {
            instruction(intructionValue);
        }
        else
        {
            //Console.WriteLine("Nothing");
        }
    }

    public static void WhileCard(int value1, int value2, Condition condition, int intructionValue, Instruction instruction, Iterator iterator)
    {
        while (condition(value1, value2))
        {
            instruction(intructionValue);
            value1 = iterator(value1);
        }
    }

    public static void WhileCard()
    {
        // while (condition(value1, value2))
        // {
        //     instruction(intructionValue);
        //     value1 = iterator(value1);
        // }
    }

    public static void TestCall(int value)
    {
        Debug.Log($"test complete {value}");
    }
}
