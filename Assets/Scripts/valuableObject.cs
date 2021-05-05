using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valuableObject : MonoBehaviour
{
    public int pointValue = 10;
    private bool hasBeenCounted = false;
    public scoreAndTimer gc;

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "bag" && hasBeenCounted == false) {
            hasBeenCounted = true;
            gc.score += pointValue;
            Debug.Log(gc.score);
        }
    }
}
