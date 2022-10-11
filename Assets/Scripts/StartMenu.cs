using UnityEngine;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private GameObject _playCanvas;
    [SerializeField] private GameObject _menuCanvas;

    private void Start()
    {
        _menuCanvas.SetActive(false);
        _playCanvas.SetActive(true);        
    }

    public void OnClickPlayButton()
    {        
        _playCanvas.SetActive(false);
        _menuCanvas.SetActive(true);        
    }
}
