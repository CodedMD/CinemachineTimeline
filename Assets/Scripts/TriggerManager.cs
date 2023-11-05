using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    [SerializeField] private CameraSwitchTriggerPlane _triggerManager;

    // Start is called before the first frame update
    private void Start()
    {

        _triggerManager.GetComponent<CameraSwitchTriggerPlane>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Plane")
        {
           
            _triggerManager.SetLowCamPriorities();
            _triggerManager._currentCam = 1;
            _triggerManager.SetCurrentCamera();
           

        }


    }
   // private void OnTriggerExit(Collider other)
   // {
       // if (other.tag == "Plane")
       // {
       //     _triggerManager.SetLowCamPriorities();
      //      _triggerManager._currentCam = 0;
        //    _triggerManager.SetCurrentCamera();

       //     _triggerManager._canSwitchCam = false;

      //  }
    //}
}
