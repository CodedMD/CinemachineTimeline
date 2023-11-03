using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTrigger : MonoBehaviour
{

    [SerializeField] private CameraManager _camManager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _camManager.SetLowCamPriorities();
            _camManager._currentCam = 1;
            _camManager.SetCurrentCamera();
            _camManager._canSwitchCam = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            _camManager.SetLowCamPriorities();
            _camManager._currentCam = 0;
            _camManager.SetCurrentCamera();

            _camManager._canSwitchCam = false;

        }
    }


}
