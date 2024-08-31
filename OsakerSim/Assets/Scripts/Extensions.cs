using UnityEngine;

public static class Extensions {
    
    public static void PlayOneShot (this AudioSource audioSource) {

        audioSource.PlayOneShot(audioSource.clip);
    }
}