using System;
using UnityEngine;
using UnityEngine.AI;

public class AnimatorController : MonoBehaviour
{
    private static readonly int Speed = Animator.StringToHash("speed");
    private Animator _animator;
    private NavMeshAgent _navMeshAgent;
    private Outline _outline;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _navMeshAgent = GetComponent<NavMeshAgent>();
        _outline = GetComponent<Outline>();
    }

    private void Update()
    {
        _animator.SetFloat(Speed, _navMeshAgent.velocity.magnitude);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name=="Potion")
        {
            Destroy(other.gameObject);
            _outline.OutlineWidth = 2;
        }
    }
}