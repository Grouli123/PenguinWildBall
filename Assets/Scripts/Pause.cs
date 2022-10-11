using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject _pauseButton;
    [SerializeField] private GameObject _windowMenu;
    [SerializeField] private Rigidbody _snowball;
    private bool _isPaused;

    private void Start()
    {
        _isPaused = true;
        ContinueGameParameters();
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        if (_isPaused == true)
        {
           Time.timeScale = 0;
            _snowball.isKinematic = true;
            _pauseButton.SetActive(false);
            _windowMenu.SetActive(true);

        }
        CheckPause();
    }

    public void ContinueGame()
    {
        if (_isPaused == false)
        {
            ContinueGameParameters();
        }
        CheckPause();
    }

    public void NextLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PreviousLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private void CheckPause()
    {
        _isPaused = !_isPaused;
    }

    private void ContinueGameParameters()
    {
        Time.timeScale = 1;
        _snowball.isKinematic = false;
        _pauseButton.SetActive(true);
        _windowMenu.SetActive(false);
    }


}
