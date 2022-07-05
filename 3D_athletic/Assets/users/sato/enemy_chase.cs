using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemy_chase : MonoBehaviour
{
    private Rigidbody rb;//Rigidbody�̏��
    private GameObject target;//�ǂ�������Ώۂ̏��
    [SerializeField] private float speed = 1.0f;//���x
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
        transform.LookAt(target.transform);//�v���C���[�̕�������
        transform.position += transform.forward * speed * Time.deltaTime;//�����Ă�����ɐi��
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player1")//�S�ɕ߂܂�����
        {
            SceneManager.LoadScene("OrverScene");
        }
        rb.isKinematic = true;//��Q���ɓ��������Ƃ��ɕ����̏�����isKinematic�ɕύX����
    }
    void OnCollisionExit(Collision collision)
    {
        rb.isKinematic = false;//��Q�����痣�ꂽ�Ƃ���isKinematic���͂���
    }
}