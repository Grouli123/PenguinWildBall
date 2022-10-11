using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void FirstLvl()
    {
        SceneManager.LoadScene(1);
    }
}
