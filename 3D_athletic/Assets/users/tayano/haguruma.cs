using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haguruma : MonoBehaviour
{
    //int counter = 0;
    float move = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        float rotateValue= 180 * Time.deltaTime;
    
        transform.Rotate(new Vector3(0f, rotateValue, 0f));
    }
private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
           collision.transform.SetParent(this.gameObject.transform);
        }
        Debug.Log("“–‚½‚Á‚Ä‚¢‚é");
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
            this.gameObject.transform.DetachChildren();
        }
        Debug.Log("—£‚ê‚½");
    }
}
