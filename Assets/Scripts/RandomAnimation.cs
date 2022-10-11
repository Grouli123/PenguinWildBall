using UnityEngine;

[RequireComponent(typeof(Animator))]

public class RandomAnimation : MonoBehaviour
{
    [SerializeField] private int _animationCount;
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void NextAnimation()
    {
        var randomNumber = Random.Range(0, _animationCount);
        _animator.SetInteger("State", randomNumber);
    }
}
