using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class valuableObject : MonoBehaviour
{
    public int pointValue = 10;
    private bool hasBeenCounted = false;
    public scoreAndTimer gc;
    public GameObject bagParticles;

    void Start() {
        bagParticles = GameObject.Find("BagParticles");
    }

    public void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "bag" && hasBeenCounted == false && gc.gameOver == false) {
            hasBeenCounted = true;
            bagParticles.GetComponent<ParticleSystem>().Play();
            gc.score += pointValue;
        }
    }
}
