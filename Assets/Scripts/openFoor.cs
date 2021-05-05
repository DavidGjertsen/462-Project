using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openFoor : MonoBehaviour
{
    public Animator door;
    public MeshRenderer model;
    public Material green;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnCollisionEnter(Collision other) {
            door.SetBool("open", true);
            model.material = green;
    }
}
