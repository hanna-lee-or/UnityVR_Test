using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObj : MonoBehaviour
{

    public Material material_1;
    public Material material_2;
    private bool flag = false;
    private Vector3 pos;

    public void Start()
    {
        pos = transform.position;
    }

    public void Update()
    {
        transform.Rotate(new Vector3(5, 5, 0));
        transform.position = new Vector3(Mathf.PingPong(Time.time, 3) - 0.5f, pos.y, pos.z);
    }

    public void gazeAtObj()
    {
        if (!flag)
        {
            flag = true;
            GetComponent<Renderer>().material = material_2;
        }
        else
        {
            flag = false;
            GetComponent<Renderer>().material = material_1;
        }
    }

}
