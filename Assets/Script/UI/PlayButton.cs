using UnityEngine;

public class PlayButton : MonoBehaviour
{
    public void LoadScene(int i)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(i);
    }
}
