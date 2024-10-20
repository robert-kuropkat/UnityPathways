using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funnel : MonoBehaviour
{
    [SerializeField] GameObject leftFunnel;
    [SerializeField] GameObject rightFunnel;
    [SerializeField] GameObject snowBall;

    void Start()
    {
        leftFunnel.GetComponent<Renderer>().material.color  = Color.red;
        rightFunnel.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerEnter()
    {
        StartCoroutine(DisableFunnel());
        StartCoroutine(EnableFunnel());
    }

    IEnumerator DisableFunnel()
    {
        yield return new WaitForSeconds(2);
        leftFunnel.GetComponent<Renderer>().material.color  = Color.green;
        rightFunnel.GetComponent<Renderer>().material.color = Color.green;
        leftFunnel.GetComponent<Collider>().enabled  = false;
        rightFunnel.GetComponent<Collider>().enabled = false;
        snowBall.GetComponent<Snowball>().CycleTracker();
    }

    IEnumerator EnableFunnel()
    {
        yield return new WaitForSeconds(8);
        leftFunnel.GetComponent<Collider>().enabled  = true;
        rightFunnel.GetComponent<Collider>().enabled = true;
        leftFunnel.GetComponent<Renderer>().material.color  = Color.red;
        rightFunnel.GetComponent<Renderer>().material.color = Color.red;
    }
}
