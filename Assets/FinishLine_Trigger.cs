using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine_Trigger : MonoBehaviour
{
    [SerializeField] private GameObject _finishLine;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CrossedFinishLine()
    {
        _finishLine.SetActive(false);
    }
}
