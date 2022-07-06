using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokuyuka : MonoBehaviour
{
    int counter = 0;
    [SerializeField]  float move = 3.0f;//ë¨ìx
    float movespeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        movespeed = move * Time.deltaTime;
        Vector3 p = new Vector3(movespeed, 0, 0);
        transform.Translate(p);
        counter++;

        if (counter == 1500)//âùïúÇ∑ÇÈÇ‹Ç≈ÇÃãóó£
        {
            counter = 0;
            move *= -1;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
            collision.transform.SetParent(this.gameObject.transform);
        }
        Debug.Log("ìñÇΩÇ¡ÇƒÇ¢ÇÈ");


    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "kyarakuta")
        {
            this.gameObject.transform.DetachChildren();
        }
        Debug.Log("ó£ÇÍÇΩ");
    }

}

