using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{

    [SerializeField] private GameObject[] _vCams;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _vCams[0].SetActive(false);
            _vCams[1].SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _vCams[0].SetActive(true);
            _vCams[1].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            _vCams[2].SetActive(false);
            _vCams[3].SetActive(false);
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            _vCams[2].SetActive(true);
            _vCams[3].SetActive(true);
        }
    }
}
