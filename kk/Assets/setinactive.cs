using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setinactive : MonoBehaviour
{
    [SerializeField] public GameObject targetObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            targetObject.SetActive(false); // Activate the targetObject
        }
    }
}

