using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpPower;
    private Rigidbody rb;
    private bool isJumping = false;
    private Vector3 latestPos;  //�O���Position
    public AudioClip jump12;
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
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
        {
            velocity.z += 1;
        }
        //���֐i��
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 1;
        }
            
        //���֐i��
        if (Input.GetKey(KeyCode.S))
        {
            velocity.z -= 1;
        }
        //�E�֐i��
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 1;
        }
            

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
            audioSource.PlayOneShot(jump12);
        }

        Vector3 diff = transform.position - latestPos;   //�O�񂩂�ǂ��ɐi�񂾂����x�N�g���Ŏ擾
        latestPos = transform.position;  //�O���Position�̍X�V

        //�x�N�g���̑傫����0.01�ȏ�̎��Ɍ�����ς��鏈��������
        if (diff.magnitude > 0.01f)
        {
            transform.rotation = Quaternion.LookRotation(velocity); //������ύX����
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
