using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void LoadScenes(int sceneIndex)
    {
        Debug.Log("Loading =>" + sceneIndex);
        SceneManager.LoadScene(sceneIndex);
    }

}
