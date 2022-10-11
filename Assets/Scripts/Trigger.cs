using UnityEngine;

public class Trigger : MonoBehaviour
{   
    [SerializeField] private GameObject _box; 
    [SerializeField] private BoxCollider _trigger;
    [SerializeField] private GameObject _textButtonE; 
    [SerializeField] private GameObject _boomEffect;

     private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ShowBox"))
        {
            _box.SetActive(true);
            _textButtonE.SetActive(true);
           
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("E pressed");
                _textButtonE.SetActive(false);
                _trigger.GetComponent<BoxCollider>().enabled = false;
                _box.SetActive(false);
                _boomEffect.SetActive(true);
            }
    }
}
