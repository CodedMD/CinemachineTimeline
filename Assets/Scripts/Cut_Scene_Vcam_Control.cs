using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Cut_Scene_Vcam_Control : MonoBehaviour
{

    [SerializeField] private GameObject[] _cutSceneVcam;

    private CapsuleCollider _cP;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAllCams()
    {
         foreach(var c in _cutSceneVcam)
        {
            c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }

    }

    public void SetmasterCam(int cam)
    {
        _cutSceneVcam[cam].GetComponent<CinemachineVirtualCamera>().Priority = 15;
    }



 
}
