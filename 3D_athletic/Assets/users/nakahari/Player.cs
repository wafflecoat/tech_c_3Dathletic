using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    private bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
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
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            velocity.z += 1;
        }
        //左へ進む
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            velocity.x -= 1;

        }
            
        //後ろへ進む
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            velocity.z -= 1;
        }
        //右へ進む
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            velocity.x += 1;
        }
            

        //速度ベクトルの長さを1秒でmoveSpeedだけ進むように調整します
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //いずれかの方向に移動している場合
        if (velocity.magnitude > 0)
        {
            //プレイヤーの位置(trabsform.position)の更新
            //移動方向ベクトル(velocity)を足しこみます
            transform.position += velocity;
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            rb.velocity = Vector3.up * jumpPower;
            isJumping = true;
        }
        

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

}
