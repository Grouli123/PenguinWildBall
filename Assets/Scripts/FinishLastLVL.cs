using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLastLVL : MonoBehaviour
{  

[SerializeField] private GameObject _deathEffect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.CompareTag("Death"))
        {        
            SceneManager.LoadScene(7);
        }        

        if (other.CompareTag("Boom"))
        {
            _deathEffect.SetActive(true);
        }
    }
}


