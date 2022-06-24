using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_chase : MonoBehaviour
{
    private Rigidbody rb;
    private GameObject target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 0.005f;
        target = GameObject.FindGameObjectWithTag("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        //プレイヤーの方を向いてから前に進む
        transform.LookAt(target.transform);
        transform.position += transform.forward * speed;
    }
    void OnCollisionEnter(Collision collision)
    {
        rb.isKinematic = true;
    }
    void OnCollisionExit(Collision collision)
    {
        rb.isKinematic = false;
    }
}