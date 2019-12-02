using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMenu : MonoBehaviour
{
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Cancel"))
        {
            Application.LoadLevel(levelToLoad);
            //SceneManager.LoadScene(levelToLoad);
        }
    }
}
