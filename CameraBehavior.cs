using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _instructionText;
    
    [SerializeField]
    private GameObject _startUpDirector;
    
    [SerializeField]
    private GameObject _cutSceneDirector;

    private int _counter = 5;

    [SerializeField]
    private float _timer;

    private bool _cutsceneActive = false;

    [SerializeField]
    private CinemachineVirtualCamera _cockpitCam;
    
    [SerializeField]
    private CinemachineVirtualCamera _thirdPersonCam;

    private int _camNum = 0;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CameraSwap();
            _instructionText.SetActive(false);
        }

        if (Input.anyKeyDown)
        {
            _timer = 0;
            EndCutscene();
        }

        if (!Input.anyKeyDown)
        {
            _timer += Time.deltaTime;
            if (_counter < _timer && _cutsceneActive == false)
            {
                Debug.Log("Starting Scene");
                StartCutscene();
                _cutsceneActive = true;
            }
        }
    }

    void CameraSwap()
    {
        if(_camNum == 0)
        {
            _cockpitCam.Priority = 11;
            _thirdPersonCam.Priority = 10;
            _camNum++;
            return;
        }

        if(_camNum == 1)
        {
            _cockpitCam.Priority = 10;
            _thirdPersonCam.Priority = 11;
            _camNum = 2;
            return;
        }

        if(_camNum == 2)
        {
            _camNum = 0;
            return;
        }
    }
    
    private void StartCutscene()
    {
        _startUpDirector.SetActive(true);
    }

    public void TransitionToCinematic()
    {
        _startUpDirector.SetActive(false);
        _cutSceneDirector.SetActive(true);
    }

    private void EndCutscene() 
    {
        _startUpDirector.SetActive(false);
        _cutSceneDirector.SetActive(false);
        _timer = 0;
        _cutsceneActive = false;
    }
}
