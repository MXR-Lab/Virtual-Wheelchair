using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trayAttach : MonoBehaviour
{
    [SerializeField] public GameObject basket;
    public Rigidbody basketRigid;
    private void OnTriggerEnter(Collider other)
    {
        basketRigid = basket.GetComponent<Rigidbody>();
        basket.transform.parent = gameObject.transform;
        basketRigid.useGravity = false;
        basketRigid.isKinematic = true;
    }
    private void OnTriggerExit(Collider other)
    {
        basket.transform.parent = null;
        basketRigid.useGravity = true;
        basketRigid.isKinematic = false;
    }
}
