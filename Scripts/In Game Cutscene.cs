using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameCutscene : MonoBehaviour
{
    [SerializeField]
    private GameObject _particle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnableParticle());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator EnableParticle()
    {
        _particle.SetActive(false);
        yield return new WaitForSeconds(3.0f);
        _particle.SetActive(true);
    }
}
