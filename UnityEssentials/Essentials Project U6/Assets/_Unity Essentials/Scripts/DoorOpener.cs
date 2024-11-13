using System.Collections;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    private Animator doorAnimator;
    [SerializeField] private GameObject kidsRoomBall;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        doorAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (doorAnimator != null)
            {
                doorAnimator.SetTrigger("Door_Open");
            }
        }

        if (tag == "Kids Room Door")
        {
            StartCoroutine(ActivateBall());
        }
    }

    private IEnumerator ActivateBall()
    {
        yield return new WaitForSeconds(0.75f);
        kidsRoomBall.SetActive(true);
    }
}
