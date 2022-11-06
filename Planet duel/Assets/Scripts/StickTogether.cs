using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTogether : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject child;
    public Transform parent;
    private ForFunction functionFor;// = new ForFunction();
    private IfFunction functionIf;// = new IfFunction();
    private WhileFunction functionWhile;// = new WhileFunction();

    public bool isFor = false;
    public bool isIf = false;
    public bool isWhile = false;

    private bool isFunction = false;
    private bool isValue = false;
    private bool isCondition = false;
    private bool isInstruction = false; 

    private int value;
    private Functions.Instruction instruction;
    private int instructionValue;
    private int left;
    private int right;
    private Functions.Condition condition;

    // Update is called once per frame
    void Update()
    {
        if(!isFunction && !isInstruction && (!isCondition || !isValue))
        {
            if(isFor)
            {
                functionFor.SetLength(value);
                functionFor.SetInstruction(instruction);
                functionFor.SetInstructionValue(instructionValue);
            }
            if(isIf)
            {
                functionIf.SetLeft(left);
                functionIf.SetRight(right);
                functionIf.SetCondition(condition);
                functionIf.SetInstruction(instruction);
                functionIf.SetInstructionValue(instructionValue);
            }
            if(isWhile)
            {
                functionWhile.SetLeft(left);
                functionWhile.SetRight(right);
                functionWhile.SetCondition(condition);
                functionWhile.SetInstruction(instruction);
                functionWhile.SetInstructionValue(instructionValue);
            }
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FunctionCardFor" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            functionFor = collision.gameObject.GetComponent<ForFunction>();
            isFunction = true;
            isFor = true;
        }

        if(collision.gameObject.tag == "VariableCard" && !isValue)
        {
            Debug.Log("value attached");
            //function.GetComponent<ForFunction>().SetLength(collision.gameObject.GetComponent<VariableValue>().value);
            value = collision.gameObject.GetComponent<VariableValue>().value;
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isValue = true;
        }
            
        if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction)
        {
            Debug.Log("instruction attached");
            //function.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
            //function.GetComponent<ForFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
            instruction = collision.gameObject.GetComponent<InstructionDMGDealt>().instruction;
            instructionValue = collision.gameObject.GetComponent<InstructionDMGDealt>().damage;
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        // if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionFor)
        if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction)
        {
            // function.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
            // function.GetComponent<ForFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
            instruction = collision.gameObject.GetComponent<InstructionGoBack>().instruction;
            instructionValue = collision.gameObject.GetComponent<InstructionGoBack>().spaces;
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "InstructionCardHeal" && !isInstruction)
        {
            // function.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionHeal>().instruction);
            // function.GetComponent<ForFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionHeal>().heal);
            instruction = collision.gameObject.GetComponent<InstructionHeal>().instruction;
            instructionValue = collision.gameObject.GetComponent<InstructionHeal>().heal;
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "FunctionCardIf" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            functionIf = collision.gameObject.GetComponent<IfFunction>();
            isFunction = true;
            isIf = true;
        }

        if((collision.gameObject.tag == "ConditionCardLess" || collision.gameObject.tag == "ConditionCardMore" || collision.gameObject.tag == "ConditionCardEqual") && !isCondition)
        {
            Debug.Log("condition attached");
            // function.GetComponent<IfFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueLess>().left);
            // function.GetComponent<IfFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueLess>().right);
            // function.GetComponent<IfFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueLess>().condition);
            left = collision.gameObject.GetComponent<ConditionValueLess>().left;
            right = collision.gameObject.GetComponent<ConditionValueLess>().right;
            condition = collision.gameObject.GetComponent<ConditionValueLess>().condition;
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
        }

        // if(collision.gameObject.tag == "ConditionCardMore" && !isCondition && functionIf)
        // {
        //     Debug.Log("condition attached");
        //     // function.GetComponent<IfFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueMore>().left);
        //     // function.GetComponent<IfFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueMore>().right);
        //     // function.GetComponent<IfFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueMore>().condition);

        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        // }

        // if(collision.gameObject.tag == "ConditionCardEqual" && !isCondition && functionIf)
        // {
        //     Debug.Log("condition attached");
        //     function.GetComponent<IfFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueEqual>().left);
        //     function.GetComponent<IfFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueEqual>().right);
        //     function.GetComponent<IfFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueEqual>().condition);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        // }

        // if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction && functionIf)
        // {
        //     Debug.Log("instruction attached");
        //     function.GetComponent<IfFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
        //     function.GetComponent<IfFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }

        // if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionIf)
        // {
        //     function.GetComponent<IfFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
        //     function.GetComponent<IfFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }

        // if(collision.gameObject.tag == "InstructionCardHeal" && !isInstruction && functionIf)
        // {
        //     function.GetComponent<IfFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionHeal>().instruction);
        //     function.GetComponent<IfFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionHeal>().heal);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }

        if(collision.gameObject.tag == "FunctionCardWhile" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            functionWhile = collision.gameObject.GetComponent<WhileFunction>();
            isFunction = true;
            isWhile = true;
        }

        // if(collision.gameObject.tag == "ConditionCardLess" && !isCondition && functionWhile)
        // {
        //     Debug.Log("condition attached");
        //     function.GetComponent<WhileFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueLess>().left);
        //     function.GetComponent<WhileFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueLess>().right);
        //     function.GetComponent<WhileFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueLess>().condition);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        // }

        // if(collision.gameObject.tag == "ConditionCardMore" && !isCondition && functionWhile)
        // {
        //     Debug.Log("condition attached");
        //     function.GetComponent<WhileFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueMore>().left);
        //     function.GetComponent<WhileFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueMore>().right);
        //     function.GetComponent<WhileFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueMore>().condition);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        // }

        // if(collision.gameObject.tag == "ConditionCardEqual" && !isCondition && functionWhile)
        // {
        //     Debug.Log("condition attached");
        //     function.GetComponent<WhileFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueEqual>().left);
        //     function.GetComponent<WhileFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueEqual>().right);
        //     function.GetComponent<WhileFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueEqual>().condition);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        // }

        // if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction && functionWhile)
        // {
        //     Debug.Log("instruction attached");
        //     function.GetComponent<WhileFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
        //     function.GetComponent<WhileFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }

        // if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionWhile)
        // {
        //     function.GetComponent<WhileFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
        //     function.GetComponent<WhileFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }

        // if(collision.gameObject.tag == "InstructionCardHeal" && !isInstruction && functionWhile)
        // {
        //     function.GetComponent<WhileFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionHeal>().instruction);
        //     function.GetComponent<WhileFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionHeal>().heal);
        //     Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
        //     collision.gameObject.transform.SetParent(this.transform);
        //     isInstruction = true;
        // }
    }
}
