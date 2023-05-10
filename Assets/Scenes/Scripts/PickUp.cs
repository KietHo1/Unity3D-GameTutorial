using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Transform target;
	public GameObject item;
    public GameObject tempParent;
    private void Start()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
    }
    private void Update()
    {

    }
    private void OnMouseDown()
    {
        item.GetComponent<Rigidbody>().useGravity = false;
        item.GetComponent<Rigidbody>().isKinematic = true;
        item.transform.position = target.transform.position;
        item.transform.parent = tempParent.transform;
    }
    private void OnMouseUp()
    {
        item.GetComponent<Rigidbody>().useGravity = true;
        item.GetComponent<Rigidbody>().isKinematic = false;
        item.transform.parent = null;
        item.transform.position = target.transform.position;
    }
}
