using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rakkaorver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Floor(this.transform.position.y)<=-300)
        {
            SceneManager.LoadScene("OrverScene");
        }
    }
}
