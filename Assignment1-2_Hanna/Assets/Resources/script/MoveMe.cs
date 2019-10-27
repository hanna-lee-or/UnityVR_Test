using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveMe : MonoBehaviour
{

    public Transform cam;
    public float rotationSpeed = 5f;
    public float playerSpeed = 1f;
    public int boundary = 225;

    public Text status;
    public int count;

    private void Start()
    {
        count = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
#if UNITY_EDITOR
        
        if (Input.GetMouseButton(0))
        {
            Vector3 pos = transform.position;
            pos += cam.forward * playerSpeed * Time.deltaTime;
            // x 경계값 설정
            if (pos.x >= boundary) pos.x = boundary;
            else if (pos.x <= -boundary) pos.x = -boundary;
            // z 경계값 설정
            if (pos.z >= boundary) pos.z = boundary;
            else if (pos.z <= -boundary) pos.z = -boundary;
            // 앞으로 이동
            transform.position = pos;
        }

#elif UNITY_ANDROID
        
        if (Input.GetButton("Fire1")) {
            Vector3 pos = transform.position;
            pos += cam.forward * playerSpeed * Time.deltaTime;
            // x 경계값 설정
            if (pos.x >= boundary) pos.x = boundary;
            else if (pos.x <= -boundary) pos.x = -boundary;
            // z 경계값 설정
            if (pos.z >= boundary) pos.z = boundary;
            else if (pos.z <= -boundary) pos.z = -boundary;
            // 앞으로 이동
            transform.position = pos;
          }

#endif

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            count--;
            if (count == 0)
            {
                status.text = "Hurray! :D";
            }
            else
            {
                status.text = count + " more to go!";
            }
        }
    }


}
