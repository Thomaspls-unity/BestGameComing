using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemType : MonoBehaviour
{
    [SerializeField] private ItemType itemType;
    [SerializeField] private float itemSpawnSpeed = 2.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * itemSpawnSpeed * Time.deltaTime);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if(other.CompareTag<"Player">)
    //}
}
