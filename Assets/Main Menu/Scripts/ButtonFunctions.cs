using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    public void Play()
    {
        SceneManager.LoadScene("level01");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
