using System;
using UnityEngine;

public class FireController : MonoBehaviour
{
    [SerializeField] private GameObject[] _torches;
    private const string PLAYER_TAG = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PLAYER_TAG))
        {
            for (var i = 0; i < _torches.Length; i++)
            {
                _torches[i].SetActive(true);
            }
        }
    }
}