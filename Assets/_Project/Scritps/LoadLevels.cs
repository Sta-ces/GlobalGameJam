using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevels : MonoBehaviour {

	public void LoadLevel(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName);
    }

    public void QuitApplication()
    {
        Application.Quit();
    }
}
