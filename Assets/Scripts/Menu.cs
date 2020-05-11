using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject winMessage;

    public void win()
    {
        winMessage.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
