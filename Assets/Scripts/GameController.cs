using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class GameController : MonoBehaviour
{
    public SpawnAndAttachToHand attach;
    public Hand hand;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(AwaitStart());
    }

    IEnumerator AwaitStart() {
        yield return new WaitForSeconds(1);
        attach = GetComponent<SpawnAndAttachToHand>();
        attach.SpawnAndAttach(hand);
    }
}
