using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukidarumatukurou : MonoBehaviour
{
    int counter = 0;
    [SerializeField]  float move = 5f;//‘¬“x
    float movespeed = 0;

    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        movespeed = move * Time.deltaTime;
        Vector3 p = new Vector3(0, 0, movespeed);
        transform.Translate(p);
        counter++;

        if (counter == 1000)
        {
            counter = 0;
            move *= -1;
        }
    }
}
