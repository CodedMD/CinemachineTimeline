using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class FOV_Switch : MonoBehaviour
{

    [SerializeField] private GameObject[] _objectOfFocus;
    [SerializeField] private GameObject _SwitchVCam;
    private bool _firstTarget;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget();

        }
       if (Input.GetKeyDown(KeyCode.Z))
        {
            TargetZoom();
        }

    }


    private void SwitchTarget()
    {
        
        if (_firstTarget == true)
        {
            _SwitchVCam.GetComponent<CinemachineVirtualCamera>().LookAt = _objectOfFocus[0].transform;
            _firstTarget = false;
        }
        else if (_firstTarget == false)
        {
            _SwitchVCam.GetComponent<CinemachineVirtualCamera>().LookAt = _objectOfFocus[1].transform;
            _firstTarget = true;

        }
    }

    private void TargetZoom()
    {
        float FOV = _SwitchVCam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;
        if (FOV < 10)
        {
            _SwitchVCam.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
        }
    }
   



}
