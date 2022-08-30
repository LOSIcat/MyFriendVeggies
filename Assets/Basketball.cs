using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basketball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    bool isMoved;
    Vector3 firstTouch;



    // Update is called once per frame
    void Update()
    {
        // 화면을 누르고있으면 공을 따라다니게 하고싶다.
        if (isMoved)
        {
            // 문지르는중
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //ball.transform.position = ray.origin +ray.direction * 3.9f;
        }
        if (Input.GetMouseButtonDown(0))
        {
            // 눌렀다
            isMoved = true;
            firstTouch = Input.mousePosition;

        }
        if (Input.GetMouseButtonDown(0))
        {
            // 뗏삳
            isMoved = false;
            Vector3 dir = Input.mousePosition - firstTouch;
            float y = Mathf.Abs(Input.mousePosition.y - firstTouch.y);
            dir = new Vector3.forward;
            dir = Camera.main.transform.TransformDirection(dir);

           // Rigidbody rb = ball.GetComponent<Rigidbody>();
           // rb.isKinematic = false;
            //rb.velocity = dir * 10;

        }


    }
}
