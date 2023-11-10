using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Treasurechest_trigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _director;
    [SerializeField] private GameObject _item;
    [SerializeField] private GameObject _spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            _director.Play();
            Invoke("InstantiateItem", 1f);
        }
    }
    private void InstantiateItem()
    {
        Instantiate(_item, _spawnPoint.transform.position, Quaternion.identity);
    }
}
