using UnityEngine;

public class BlocksFall : MonoBehaviour
{
    [SerializeField] private AudioSource blockSound;
    private bool firstCollision = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.realtimeSinceStartup > 2) { firstCollision = false; }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (firstCollision) { return; }
        blockSound.Play();
    }
}
