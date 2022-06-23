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

    [SerializeField] private Vector3 velocity; //�ړ�����
    [SerializeField] private float moveSpeed = 1.0f; //�ړ����x

    // Update is called once per frame
    void Update()
    {

        //WASD���͂���AXZ����(�����Ȓn��)���ړ��������(velocity)�𓾂�
        velocity = Vector3.zero;
        //�O�֐i��
        if (Input.GetKey(KeyCode.W))
            velocity.z += 1;
        //���֐i��
        if (Input.GetKey(KeyCode.A))
            velocity.x -= 1;
        //���֐i��
        if (Input.GetKey(KeyCode.S))
            velocity.z -= 1;
        //�E�֐i��
        if (Input.GetKey(KeyCode.D))
            velocity.x += 1;

        //���x�x�N�g���̒�����1�b��moveSpeed�����i�ނ悤�ɒ������܂�
        velocity = velocity.normalized * moveSpeed * Time.deltaTime;

        //�����ꂩ�̕����Ɉړ����Ă���ꍇ
        if (velocity.magnitude > 0)
        {
            //�v���C���[�̈ʒu(trabsform.position)�̍X�V
            //�ړ������x�N�g��(velocity)�𑫂����݂܂�
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
