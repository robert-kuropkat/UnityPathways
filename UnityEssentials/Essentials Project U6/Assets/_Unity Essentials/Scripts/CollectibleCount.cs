using UnityEngine;
using System;
using System.Collections;

public class CollectibleCount : MonoBehaviour
{

    public ParticleSystem correctEffect;   // Reference to the GameObject to activate
    public AudioSource correctSound;    // Reference to the Audio Source
    private bool gameOver = false;


    // Update is called once per frame
    void Update()
    {
        UpdateCollectibleCount();
    }

    private void UpdateCollectibleCount()
    {
        int totalCollectibles = 0;

        // Check and count objects of type Collectible
        Type collectibleType = Type.GetType("Collectible");
        if (collectibleType != null)
        {
            totalCollectibles += UnityEngine.Object.FindObjectsByType(collectibleType, FindObjectsSortMode.None).Length;
        }
        if (totalCollectibles == 0 && gameOver == false)
        {
            gameOver = true;
            WinGame();

        }

    }

    private void WinGame()
    {
        Vector3 playerPos = transform.position;
        Vector3 playerDirection = transform.forward;
        Quaternion playerRotation = transform.rotation;
        float spawnDistance = 1f;
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;

        correctEffect.transform.position = spawnPos;
        correctEffect.Play();
        correctSound.Play();
    }

}
