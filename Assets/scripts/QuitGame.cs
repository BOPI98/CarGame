using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitGame : MonoBehaviour
{
    public GameObject guiObject;
    // Start is called before the first frame update
    void Start()
    {
        guiObject.SetActive(false);
    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
            Debug.Log("quit");
            Application.Quit();
                //SceneManager.LoadScene(levelToLoad);
            }
    }
    void OnTriggerExit()
    {
        guiObject.SetActive(false);
    }
}
