using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamebgm : MonoBehaviour
{
    public AudioClip BGM_title;

    private AudioSource source;

    private string beforeScene = "TitleScene";

    public bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {

        if (DontDestroyEnabled)
        {
      
            DontDestroyOnLoad(this);
        }

        source = GetComponent<AudioSource> ();

        source.clip = BGM_title;
		source.Play();

        SceneManager.activeSceneChanged += OnActiveSceneChanged;
    }


    void OnActiveSceneChanged ( Scene prevScene, Scene nextScene ) {
		
		
		if (beforeScene == "ClearScene" && nextScene.name == "TitleScene")
        {
			source.Stop ();
		}

		//メインからメニューへ
		if (beforeScene == "OrverScene" && nextScene.name == "TitleScene") 
        {
			source.Stop ();
		}
        beforeScene = nextScene.name;
    }

    // Update is called once per frame
    void Update()
    {
        

    }
    
}
