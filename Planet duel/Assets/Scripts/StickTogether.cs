using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTogether : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject child;
    public Transform parent;
    public bool functionFor = false;
    public bool functionIf = false;
    public bool functionWhile = false;

    private bool isFunction = false;
    private bool isValue = false;
    private bool isCondition = false;
    private bool isInstruction = false;

    private GameObject function;

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "FunctionCardFor" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            function = collision.gameObject;
            isFunction = true;
            functionFor = true;
        }

        if(collision.gameObject.tag == "VariableCard" && !isValue && functionFor)
        {
            Debug.Log("value attached");
            function.GetComponent<ForFunction>().SetLength(collision.gameObject.GetComponent<VariableValue>().value);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isValue = true;
        }
            
        if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction && functionFor)
        {
            Debug.Log("instruction attached");
            function.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
            function.GetComponent<ForFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionFor)
        {
            function.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
            function.GetComponent<ForFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "FunctionCardIf" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            function = collision.gameObject;
            isFunction = true;
            functionIf = true;
        }

        if(collision.gameObject.tag == "ConditionCardLessHP" && !isCondition && functionIf)
        {
            Debug.Log("condition attached");
            function.GetComponent<IfFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueLessHP>().left);
            function.GetComponent<IfFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueLessHP>().right);
            function.GetComponent<IfFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueLessHP>().condition);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
        }

        if(collision.gameObject.tag == "ConditionCardMoreHP" && !isCondition && functionIf)
        {
            Debug.Log("condition attached");
            function.GetComponent<IfFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueMoreHP>().left);
            function.GetComponent<IfFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueMoreHP>().right);
            function.GetComponent<IfFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueMoreHP>().condition);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
        }

        if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction && functionIf)
        {
            Debug.Log("instruction attached");
            function.GetComponent<IfFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
            function.GetComponent<IfFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionIf)
        {
            function.GetComponent<IfFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
            function.GetComponent<IfFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "FunctionCardWhile" && !isFunction)
        {
            Debug.Log("function attached");
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            function = collision.gameObject;
            isFunction = true;
            functionWhile = true;
        }

        if(collision.gameObject.tag == "ConditionCardLessHP" && !isCondition && functionWhile)
        {
            Debug.Log("condition attached");
            function.GetComponent<WhileFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueLessHP>().left);
            function.GetComponent<WhileFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueLessHP>().right);
            function.GetComponent<WhileFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueLessHP>().condition);
            collision.gameObject.GetComponent<ConditionValueLessHP>().iterator = collision.gameObject.GetComponent<ConditionValueLessHP>().left < collision.gameObject.GetComponent<ConditionValueLessHP>().right ? Iterators.Plus : Iterators.Minus;
            function.GetComponent<WhileFunction>().SetIterator(collision.gameObject.GetComponent<ConditionValueLessHP>().iterator);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
        }

        if(collision.gameObject.tag == "ConditionCardMoreHP" && !isCondition && functionWhile)
        {
            Debug.Log("condition attached");
            function.GetComponent<WhileFunction>().SetLeft(collision.gameObject.GetComponent<ConditionValueMoreHP>().left);
            function.GetComponent<WhileFunction>().SetRight(collision.gameObject.GetComponent<ConditionValueMoreHP>().right);
            function.GetComponent<WhileFunction>().SetCondition(collision.gameObject.GetComponent<ConditionValueMoreHP>().condition);
            collision.gameObject.GetComponent<ConditionValueMoreHP>().iterator = collision.gameObject.GetComponent<ConditionValueMoreHP>().left < collision.gameObject.GetComponent<ConditionValueMoreHP>().right ? Iterators.Plus : Iterators.Minus;
            function.GetComponent<WhileFunction>().SetIterator(collision.gameObject.GetComponent<ConditionValueMoreHP>().iterator);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
        }

        if(collision.gameObject.tag == "InstructionCardDMGDealt" && !isInstruction && functionWhile)
        {
            Debug.Log("instruction attached");
            function.GetComponent<WhileFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
            function.GetComponent<WhileFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionDMGDealt>().damage);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }

        if(collision.gameObject.tag == "InstructionCardgoBack" && !isInstruction && functionWhile)
        {
            function.GetComponent<WhileFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionGoBack>().instruction);
            function.GetComponent<WhileFunction>().SetInstructionValue(collision.gameObject.GetComponent<InstructionGoBack>().spaces);
            Destroy(collision.gameObject.GetComponent<Rigidbody2D>());
            collision.gameObject.transform.SetParent(this.transform);
            isInstruction = true;
        }
    }
}
