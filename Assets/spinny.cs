using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinny : MonoBehaviour
{
    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion rotation = gameObject.transform.rotation;
        rotation.y += 10;
        gameObject.transform.rotation = rotation;
    }
}
