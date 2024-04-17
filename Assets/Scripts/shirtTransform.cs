using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shirtTransform : MonoBehaviour
{
    [SerializeField] public GameObject plaidFold;
    [SerializeField] public GameObject solidFold;
    GameObject shirtFold;

    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        if (obj.layer == 7)
        {
            shirtFold = Instantiate(plaidFold, obj.transform.position, obj.transform.rotation);
            Destroy(obj);
            Destroy(obj.transform.parent.gameObject);
        }
        if (obj.layer == 8)
        {
            shirtFold = Instantiate(solidFold, obj.transform.position, obj.transform.rotation);
            Destroy(obj);
            Destroy(obj.transform.parent.gameObject);
        }
    }
}
