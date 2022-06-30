using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haguruma : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0f,-1f, 0f));
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
