using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    private characteranimation player_Anime;
    private Rigidbody myBody;

    public float walk_Speed = 2f;
    public float z_speed = 1.5f;

    private float rotation_Y = -90f;
    private float rotation_Speed = 15f;

    // Start is called before the first frame update
    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
        player_Anime = GetComponentInChildren<characteranimation>();

    }

    // Update is called once per frame
    void Update()
    {
        RotatePlayer();
        AnimatePlayerWalk();
    }
    void FixedUpdate()
    {
        DetectMovement();
    }

    void DetectMovement()
    {
        myBody.velocity = new Vector3(
            Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) * (-walk_Speed),
            myBody.velocity.y,
            Input.GetAxisRaw(Axis.VERTICAL_AXIS) * (-z_speed));
    } //movement 

    void RotatePlayer()
    {
        if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) > 0)
        {
            transform.rotation = Quaternion.Euler(0f, rotation_Y, 0f);
        }
        else if (Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) < 0)
        {
            transform.rotation = Quaternion.Euler(0f, Mathf.Abs(rotation_Y), 0f);
        }
    }//rotation

    void AnimatePlayerWalk()
    {
        if(Input.GetAxisRaw(Axis.HORIZONTAL_AXIS) !=0 ||
            Input.GetAxisRaw(Axis.VERTICAL_AXIS) != 0)
        {
            player_Anime.Walk(true);
        }
        else
        {
            player_Anime.Walk(false);
        }

    }//Animate player walk 
}






