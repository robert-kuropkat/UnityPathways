using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private AudioSource bounceSound;
    private int bounceCounter = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (bounceCounter > 2) { return; }
        bounceCounter++;
        bounceSound.Play();
    }
}
