using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{

    [SerializeField]
    private GameObject _inGameCutsceneDirector;

    private void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player")) 
        {
            _inGameCutsceneDirector.SetActive(true);
        }
    }
}
