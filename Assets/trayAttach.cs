using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trayAttach : MonoBehaviour
{
    [SerializeField] public GameObject basket;
    private void OnCollisionEnter(Collision collision)
    {
        basket.transform.parent = gameObject.transform;
    }
    private void OnCollisionExit(Collision collision)
    {
        basket.transform.parent = null;
    }
}
