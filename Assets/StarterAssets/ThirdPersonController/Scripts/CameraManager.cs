using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{

    [SerializeField]private GameObject[] _vCam;
    public int _currentCam;
    public bool _canSwitchCam;
    // Start is called before the first frame update
    void Start()
    {
        _currentCam = 0;
        
    }

    // Update is called once per frame
    void Update()
    {

        if(_canSwitchCam == true)
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                _currentCam++;
                if (_currentCam >= _vCam.Length)
                {
                    _currentCam = 1;
                }
                SetLowCamPriorities();
                SetCurrentCamera();
            }


        }





    }

    public void SetLowCamPriorities()
    {
        foreach(var c in _vCam)
        {
            if (c.GetComponent<CinemachineVirtualCamera>())
            {
                c.GetComponent<CinemachineVirtualCamera>().Priority = 10;

            }
         
            if (c.GetComponent<CinemachineBlendListCamera>())
            {
                c.GetComponent<CinemachineBlendListCamera>().Priority = 10;

            }


        }
    }

    public void SetCurrentCamera()
    {

        if (_vCam[_currentCam].GetComponent<CinemachineBlendListCamera>())
        {
            _vCam[_currentCam].GetComponent<CinemachineBlendListCamera>().Priority = 15;

        }

        if (_vCam[_currentCam].GetComponent<CinemachineVirtualCamera>())
        {
            _vCam[_currentCam].GetComponent <CinemachineVirtualCamera> ().Priority = 15;
        }


    }


}
