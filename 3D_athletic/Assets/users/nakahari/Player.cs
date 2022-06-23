using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }

    [SerializeField] private Vector3 velocity; //移動方向
    [SerializeField] private float moveSpeed = 1.0f; //移動速度

    // Update is called once per frame
    void Update()
    {

        //WASD入力から、XZ平面(水平な地面)を移動する方向(velocity)を得る
        velocity = Vector3.zero;
        //前へ進む
        if (Input.GetKey(KeyCode.W))
            velocity.z += 1;
        //左へ進む
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;
        //後ろへ進む
        if (Input.GetKey(KeyCode.S))
            velocity.z -= 1;
        //右へ進む
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;

        //速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            //プレイヤーの位置(trabsform.position)の更新
            //移動方向ベクトル(velocity)を足しこみます
            transform.position += velocity;
        }

    }

}
