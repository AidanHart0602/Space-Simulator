using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class CameraBehavior : MonoBehaviour
{
    private int _camNum = 0;
    [SerializeField]
    private CinemachineVirtualCamera _cockpitCam;
    [SerializeField]
    private CinemachineVirtualCamera _thirdPersonCam;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            CameraSwap();
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
}
