using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGrab : MonoBehaviour
{
    public float handPower = 10;
    public Transform cam;
    public GameObject ball;
    public GameObject myHand;
    bool inHands = false;
    Collider ballCol;
    Rigidbody ballRb;

    private void Start()
    {
        ballCol = ball.GetComponent<SphereCollider>();
        ballRb = ball.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            if (!inHands)
            {
                ballCol.isTrigger = true;
                ballRb.useGravity = false;
                ball.transform.SetParent(myHand.transform);
                ball.transform.localPosition = new Vector3(0, 0.25f, 1.5f);
                ballRb.velocity = Vector3.zero;
            }
            else
            {
                ball.transform.SetParent(null);
                ballCol.isTrigger = false;
                ballRb.useGravity = true;
                ballRb.velocity = cam.transform.rotation * Vector3.forward * handPower;
                GetComponent<PlayerGrab>().enabled = false;
            }
            inHands = !inHands;
        }

    }
}
