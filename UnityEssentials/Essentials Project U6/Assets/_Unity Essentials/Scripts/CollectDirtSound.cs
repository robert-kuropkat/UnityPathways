using UnityEngine;

public class CollectDirtSound : MonoBehaviour
{
    [SerializeField] private AudioSource collectDirtSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Dirt"))
        {
            collectDirtSound.Play();
        }
    }
}
