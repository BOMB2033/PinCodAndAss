using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator animator;
    public float speedMove = 10;
    public float speedRotate = 10;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animator.Play("Run");
            transform.Translate(Vector3.back * speedMove * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            animator.Play("Run");
            transform.Translate(Vector3.forward * speedMove * Time.deltaTime);
        }
        transform.Rotate(new Vector3( 0, Input.GetAxis("Mouse X") * speedRotate * Time.deltaTime, 0));
    }
}
