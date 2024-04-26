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
        basketRigid.useGravity = false;
        basketRigid.isKinematic = true;
        basket.transform.parent = gameObject.transform;
        basket.transform.localRotation = new Quaternion(0, 90, 0, 0);
        basket.transform.localPosition = new Vector3(0, 0, 0);
        basket.transform.localScale = new Vector3(1,1,1);
    }
    private void OnCollisionExit(Collision collision)
    {
        basket.transform.parent = null;
        basketRigid.useGravity = true;
        basketRigid.isKinematic = false;
    }
}
