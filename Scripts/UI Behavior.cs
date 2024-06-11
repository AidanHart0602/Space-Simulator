using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class UIBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _instructionsText;

    [SerializeField]
    private GameObject _buttons;

    [SerializeField]
    private GameObject _jupiterIntroText;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IntroductionSequence());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _instructionsText.SetActive(false);
        }   
    }

    public void ExitButton()
    {
        Application.Quit();
    }
    IEnumerator IntroductionSequence() 
    {
        _buttons.SetActive(false);
        _instructionsText.SetActive(false);
        yield return new WaitForSeconds(2);

        _jupiterIntroText.SetActive(false);
        yield return new WaitForSeconds(4.5f);

        _jupiterIntroText.SetActive(false);
        _buttons.SetActive(true);
        _instructionsText.SetActive(true);
    }

    public void DisableUI()
    {
        _buttons.SetActive(false);
        _instructionsText.SetActive(false);
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }    
}
