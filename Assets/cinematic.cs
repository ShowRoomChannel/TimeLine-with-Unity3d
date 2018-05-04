using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class cinematic : MonoBehaviour {

    public PlayableDirector evetl;
    private bool hasplayed = false;
	

    private void OnTriggerEnter(Collider other)
    {
        if (hasplayed)
        {
            evetl.Play();
        }
    }
}
