using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;
    // Start is called before the first frame update
    void Start()
    {
        guiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay (Collider other)
    {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
            Debug.Log("Start");
            Application.LoadLevel(levelToLoad);
            //SceneManager.LoadScene(levelToLoad);
        }
    }
    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
