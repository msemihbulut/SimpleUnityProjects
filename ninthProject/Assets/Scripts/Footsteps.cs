using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioClip[] footstepsClips;
    public AudioSource audioSource;

    public CharacterController characterController;
    public float footstepThreshold;
    public float footstepRate;
    private float lastFootstepTime;

    private void FixedUpdate()
    {
        if(characterController.velocity.magnitude > footstepThreshold) 
        {
            if(Time.time - lastFootstepTime > footstepRate)
            {
                lastFootstepTime = Time.time;
                audioSource.PlayOneShot(footstepsClips[Random.Range(0, footstepsClips.Length)]);
            }
        }
    }
}
