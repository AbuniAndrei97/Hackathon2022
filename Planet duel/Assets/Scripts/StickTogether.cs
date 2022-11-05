using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickTogether : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject child;
    public Transform parent;

    // Update is called once per frame
    void Update()
    {


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject.GetComponent<Rigidbody2D>());        
        collision.gameObject.transform.SetParent(this.transform);
        
        if(collision.gameObject.tag == "VariableCard")
            this.GetComponent<ForFunction>().SetLength(collision.gameObject.GetComponent<VariableValue>().value);
        if(collision.gameObject.tag == "InstructionCardDMGDealt")
            this.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionDMGDealt>().instruction);
        // if(collision.gameObject.tag == "InstructionCardGoBack")
        //     this.GetComponent<ForFunction>().SetInstruction(collision.gameObject.GetComponent<InstructionValueGoBack>().instruction);
    }
}
