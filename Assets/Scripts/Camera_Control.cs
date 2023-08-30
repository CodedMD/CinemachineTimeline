using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Control : MonoBehaviour
{

    [SerializeField] private GameObject[] _vCams;


    // Start is called before the first frame update
    void Start()
    {
        _vCams[0].SetActive(true);
        _vCams[1].SetActive(false);
        _vCams[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            _vCams[0].SetActive(false);
            _vCams[1].SetActive(true);

        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            _vCams[1].SetActive(false);
            _vCams[0].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _vCams[0].SetActive(false);
            _vCams[2].SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            _vCams[0].SetActive(true);
            _vCams[2].SetActive(false);
        }

    }
}
