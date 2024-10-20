using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{

    [SerializeField] GameObject mainCamera;
    [SerializeField] int        cycleCount = 0;

    public int CycleCount
    {
        get { return cycleCount; }
        set { cycleCount = value; }
    }

    public void CycleTracker()
    {
        if (  CycleCount     != 0
           && CycleCount % 3 == 0)  { mainCamera.GetComponent<MainCamera>().CameraLocation++; }
        if (mainCamera.GetComponent<MainCamera>().CameraLocation == 7) 
                                    { mainCamera.GetComponent<MainCamera>().CameraLocation = 0; }
        CycleCount++;

        mainCamera.GetComponent<MainCamera>().SelectStaticCamera();
    }

}
