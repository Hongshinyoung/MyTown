using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange: MonoBehaviour
{
    public string sceneName;
    public void MoveScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}