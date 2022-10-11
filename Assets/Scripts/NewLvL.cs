using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLvL : MonoBehaviour
{
    [SerializeField] private int _level;

    public void SwichToNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + _level);
    }
}
