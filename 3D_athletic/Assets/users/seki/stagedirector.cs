using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stagedirector : MonoBehaviour
{
    private GameObject pzahyou;
    // Start is called before the first frame update
    void Start()
    {
        pzahyou = GameObject.FindGameObjectWithTag("Player1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
