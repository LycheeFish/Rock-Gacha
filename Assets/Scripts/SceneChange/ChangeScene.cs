using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    
    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    public float fadewait;

    private void Awake()
    {
        if (fadeInPanel != null)
        {
            // white to clear fade
            GameObject panel = Instantiate(fadeInPanel, Vector3.zero, Quaternion.identity) as GameObject;
            Destroy(panel, 1);
        }
    }
    // button requires void function 
    // create void function to call the non void function: IEnumerator
    public void Trigger(string sceneToLoad)
    {
        
        StartCoroutine(FadeCoroutine(sceneToLoad));
    }

    public IEnumerator FadeCoroutine(string sceneToLoad)
    {
        if(fadeOutPanel != null)
        {
            // Create a fadeOutPanel at null position and rotate
            // clear to white fade
            Instantiate(fadeOutPanel, Vector3.zero, Quaternion.identity); 
        }
        yield return new WaitForSeconds(fadewait);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneToLoad);
        // while above runs, keep pausing at start screen, i.e. until we press ENTER
        while (!asyncOperation.isDone)
        {
            yield return null;
        }

    }
}
