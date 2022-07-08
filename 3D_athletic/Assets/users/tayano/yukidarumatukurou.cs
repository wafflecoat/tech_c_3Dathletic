using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yukidarumatukurou : MonoBehaviour
{
    float counter = 0;
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
        counter += Time.deltaTime;

        if (counter >= 1)
        {
            counter = 0;
            move *= -1;
        }
    }
}
