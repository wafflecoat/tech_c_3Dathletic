using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haguruma : MonoBehaviour
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
       

        if (counter == 300)
        {
            counter = 0;
            move *= -1;
        }
        transform.Rotate(new Vector3(0f, -0.4f, 0f));
    }
private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
           collision.transform.SetParent(this.gameObject.transform);
        }
        Debug.Log("当たっている");
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
            this.gameObject.transform.DetachChildren();
        }
        Debug.Log("離れた");
    }
}
