using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_chase : MonoBehaviour
{
    private Rigidbody rb;//Rigidbodyの情報
    private GameObject target;//追いかける対象の情報
    [SerializeField] private float speed = 1.0f;//速度
    private Vector3 lookplayer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindGameObjectWithTag("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target.transform);//プレイヤーの方を向く
        transform.position += transform.forward * speed * Time.deltaTime;//向いている方に進む
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")//鬼に捕まった時
        {
            SceneManager.LoadScene("OrverScene");
        }
        rb.isKinematic = true;//障害物に当たったときに物理の処理をisKinematicに変更する
    }
    void OnCollisionExit(Collision collision)
    {
        rb.isKinematic = false;//障害物から離れたときにisKinematicをはずす
    }
}