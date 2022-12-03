using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void LoadScene(int sceneBuilIndex)
    {
        SceneManager.LoadScene(sceneBuilIndex);
    }
}
