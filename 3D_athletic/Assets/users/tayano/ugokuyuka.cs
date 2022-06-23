using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokuyuka : MonoBehaviour
{
    int counter = 0;
    float move = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 p = new Vector3(move, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == 1000)
        {
            counter = 0;
            move *= -1;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "playre_temp")
        {
            collision.transform.SetParent(this.gameObject.transform);
        }
        Debug.Log("“–‚½‚Á‚Ä‚¢‚é");


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "playre_temp")
        {
            this.gameObject.transform.DetachChildren();
        }
        Debug.Log("—£‚ê‚½");
    }

}

