using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{

    [SerializeField] GameObject ball;
    //[SerializeField] int cameraLocation = 0;

    private int cameraLocation = 0;
    public int CameraLocation
    {
        get { return cameraLocation; }
        set { cameraLocation = value; }
    }

    void Start() { CameraPosition_0(); }

    void LateUpdate() { SelectFollowCamera(); }


    public void SelectFollowCamera()
    {
        switch (CameraLocation)
        {
            case 3:                 // LookAt from Center of platforms
                CameraPosition_3();
                break;
            case 4:                 // Follow hover above and look down
                CameraPosition_4();
                break;
            case 5:                 // Centered on ball looking forward
                CameraPosition_5();
                break;
            case 6:                 // Just in front looking back at ball
                CameraPosition_6();
                break;
            default:
                break;
        }
    }

    public void SelectStaticCamera()
    {
        switch (CameraLocation)
        {
            case 0:                 // Above platforms looking down
                CameraPosition_0();
                break;
            case 1:                 // Left side looking torwards platforms
                CameraPosition_1();
                break;
            case 2:                 // Behind platforms looking torwards platforms
                CameraPosition_2();
                break;
            default:
                break;
        }
    }

    private void CameraPosition_0()
    {
        Vector3 cameraPosition = new Vector3(3.272102f, 19.56934f, 3.381581f);
        Vector3 cameraRotation = new Vector3(88.034f, 0f, 0f);
        //Vector3 cameraRotation = Vector3.left * 180; //+ new Vector3(90f, 0f, 0f);
        CameraLocation          = 0;
        transform.position      = cameraPosition;
        transform.eulerAngles   = cameraRotation;
    }

    private void CameraPosition_1()
    {
        Vector3 cameraPosition = new Vector3(15.24212f, 12.94874f, 4.373586f);
        Vector3 cameraRotation = new Vector3(17.56f, -84.741f, 0f);
        CameraLocation          = 1;
        transform.position      = cameraPosition;
        transform.eulerAngles   = cameraRotation;
    }

    private void CameraPosition_2()
    {
        Vector3 cameraPosition = new Vector3(-0.4761798f, 8.152985f, 20.58699f);
        Vector3 cameraRotation = new Vector3(0.2f, -177.216f, 0f);
        CameraLocation          = 2;
        transform.position      = cameraPosition;
        transform.eulerAngles   = cameraRotation;
    }

    private void CameraPosition_3()
    {
        CameraLocation      = 3;
        transform.position  = new Vector3(0, 8, 4);
        transform.LookAt(ball.transform);
    }

    private void CameraPosition_4()
    {
        CameraLocation      = 4;
        //        mainCamera.transform.position = ball.transform.position + cameraRotations[4];  // move this Roation to position or create an offset
        transform.position  = ball.transform.position + new Vector3(0f, 1.5f, 0f);
        transform.LookAt(ball.transform);
    }

    private void CameraPosition_5()
    {
        CameraLocation      = 5;
        transform.position  = ball.transform.position + new Vector3(0, 0, 0);
        //mainCamera.transform.position = ball.transform.position + new Vector3(0, 1, 1);  // camera a little behind and above
        transform.LookAt(ball.transform);
    }

    private void CameraPosition_6()
    {
        CameraLocation      = 6;
        transform.position  = ball.transform.position + new Vector3(0, 0, -1);
        transform.LookAt(ball.transform);
    }

    //mainCamera.transform.eulerAngles = new Vector3(0, 90, 0);

    // Follow, center and look ahead.  (ToDo: currently facing backwards)
    //mainCamera.transform.position = ball.transform.position + cameraOffset;
    //mainCamera.transform.position = ball.transform.position + cameraRotations[5];
    //mainCamera.transform.eulerAngles = new Vector3( 0, 0, 0); // Looking back
    //mainCamera.transform.eulerAngles = new Vector3(90, 0, 0); // Looking down, just in front?
    //mainCamera.transform.eulerAngles = new Vector3(-90, 0, 0); // Looking up?
    //mainCamera.transform.eulerAngles = new Vector3(180, 0, 0); // Looking upside down/forwar?
    //mainCamera.transform.eulerAngles = Vector3.back; // Looking ?
    //mainCamera.transform.eulerAngles = new Vector3(0, 0, 90); // Looking sideways backwards?
    //ball.transform.LookAt(mainCamera.transform);
    //mainCamera.transform.LookAt(ball.transform);
    //ball.transform.LookAt(mainCamera.transform);  // for look from below...?
    // Follow hover above and look down
    // mainCamera.transform.position    = ball.transform.position + cameraOffset;
    // mainCamera.transform.LookAt(ball.transform);

    // Follow, center and look ahead.
    //            mainCamera.transform.position = ball.transform.position + cameraOffset;
    //            ball.transform.LookAt(mainCamera.transform);

    //mainCamera.transform.eulerAngles = cameraRotations[0];

    // LookAt from Center
    //mainCamera.transform.position = new Vector3(0, 8, 4);
    //mainCamera.transform.LookAt(ball.transform);



}
