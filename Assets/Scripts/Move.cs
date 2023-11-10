using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _director;
    // Start is called before the first frame update
    void Start()
    {
        _director.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * _speed * Time.deltaTime);

        Explode();
    }


    private void Explode()
    {
       StartCoroutine(WaitExplosion());
        
    }

    IEnumerator WaitExplosion()
    {
        yield return new WaitForSeconds(2);
        _director.SetActive(true);
        yield return null;
    }

}
