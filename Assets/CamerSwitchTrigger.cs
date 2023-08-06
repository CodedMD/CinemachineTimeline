using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerSwitchTrigger : MonoBehaviour
{
    private Cut_Scene_Vcam_Control _cutSceneControl;
    [SerializeField] private int _whichCamera;
    // Start is called before the first frame update
    void Start()
    {
        _cutSceneControl = GameObject.Find("CameraManager").GetComponent<Cut_Scene_Vcam_Control>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cutSceneControl.ResetAllCams();
            _cutSceneControl.SetmasterCam(_whichCamera);
        }
    }


}
