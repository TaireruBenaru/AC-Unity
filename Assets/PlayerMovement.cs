using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Camera camera;
    public CharacterController controller;
    //public GameObject camObj;
    //public Transform model;
    public float Speed;
    public float TurnSpeed;
    public bool CanMove = true;

    public Vector3 Dir;

    //private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Dir = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Dir.Normalize();

        if(Dir != Vector3.zero)
        {
            UpdatePlayerPosition();
            UpdateAngleToFace();
        }
    }


    void UpdatePlayerPosition()
    {
        float CurrentSpeed = Speed;

        controller.Move(Dir * Time.deltaTime * Speed);
    }

    void UpdateAngleToFace()
    {
        if(Dir != Vector3.zero)
        {
            //Quaternion rotation = Quaternion.LookRotation(0, Mathf.Atan2(Dir.z, Dir.y), 0);
            //gameObject.transform.rotation = Quaternion.Lerp(transform.rotation, rotation, TurnSpeed);
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, Dir, TurnSpeed * Time.deltaTime, 0.5f);
            transform.rotation = Quaternion.LookRotation(newDirection);
            //gameObject.transform.forward = Dir;
        }
    }
}
