using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    Vector3 ballInitPosition;
    [SerializeField]
    Vector3 forceToAdd;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(AddForceAfterDelay());
    }

    public void AddForceToBall(Vector3 force)
    {
        rb.AddForce(force);
    }

    private IEnumerator AddForceAfterDelay()
    {
        yield return new WaitForSeconds(5);
        AddForceToBall(forceToAdd);
    }
}
