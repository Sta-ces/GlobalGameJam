using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour {

    public float m_TimeToTransition;

    public void LoadLevel(string _sceneName)
    {
        //yield return new WaitForSeconds(m_TimeToTransition);
        StartCoroutine(LoadYourAsyncScene(_sceneName));
        //SceneManager.LoadScene(_sceneName);
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
