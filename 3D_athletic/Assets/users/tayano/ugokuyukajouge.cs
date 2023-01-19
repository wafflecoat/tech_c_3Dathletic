using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ugokuyukajouge : MonoBehaviour
{
    float counter = 0;
    [SerializeField] float move = 3.0f;//速度
    float movespeed = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        movespeed = move * Time.deltaTime;
        Vector3 p = new Vector3(0, movespeed, 0);
        transform.Translate(p);
        counter += Time.deltaTime;

        if (counter >= 1.5)//往復するまでの距離
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
