using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour {

    public float m_TimeToTransition;

    public void LoadLevel(string _sceneName)
    {
        StartCoroutine(LoadYourAsyncScene(_sceneName));
    }

    public void QuitApplication()
    {
        Application.Quit();
    }


    IEnumerator LoadYourAsyncScene(string _scene)
    {
        /* AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_scene);
         Debug.Log(asyncLoad.progress);

         while (!asyncLoad.isDone)
         {
             yield return null;
         }*/
        yield return new WaitForSeconds(m_TimeToTransition);
        SceneManager.LoadScene(_scene);
    }

}
