using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Low_02 : MonoBehaviour
{
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoLow02()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 15);

    }
}
