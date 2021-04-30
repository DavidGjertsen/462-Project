using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnToStartingPoint : MonoBehaviour
{
    public int timeToReset = 5;
    public float maxDistanceFromStart = .5f;
    public float maxDistanceFromPlayer = 3f;
    public GameObject player;
    private Vector3 startingPoint;
    private Quaternion startingRotation;
    private Rigidbody rb;
    private bool isCounting = false;

    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody>();
        startingPoint = transform.position;
        startingRotation = transform.rotation;
    }

    IEnumerator Reset() {
        isCounting = true;
        yield return new WaitForSeconds(timeToReset);
        if(ShouldReset()) {
            transform.position = startingPoint;
            transform.rotation = startingRotation;
            rb.velocity = new Vector3(0, 0, 0);
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
        isCounting = false;
    }

    // Update is called once per frame
    void Update() {
        if(ShouldReset() && !isCounting) {
            StartCoroutine(Reset());
        }
    }

    private bool ShouldReset() {
        float distanceFromPlayer = Vector3.Distance(transform.position, player.gameObject.transform.position);
        float distanceFromStart = Vector3.Distance(transform.position, startingPoint);

        if(distanceFromPlayer > maxDistanceFromPlayer && distanceFromStart > maxDistanceFromStart) {
            return true;
        }
        return false;
    }
}
