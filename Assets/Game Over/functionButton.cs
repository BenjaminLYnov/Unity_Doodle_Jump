using UnityEngine;
using UnityEngine.SceneManagement;

public class functionButton : MonoBehaviour
{
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void quit()
    {
        Application.Quit();
    }
}
