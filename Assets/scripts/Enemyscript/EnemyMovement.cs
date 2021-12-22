using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private characteranimation enemyAnime;

    private Rigidbody myBody;
    public float speed = 5f;

    private Transform playerTarget;

    public float attack_Distance = 1f;
    public float chase_Player_After_Attack = 1f;

    private float current_Attack_Time;
    private float default_Attack_Time = 2f;

    private bool followPlayer, attackPlayer;

    void Awake()
    {
        enemyAnime = GetComponentInChildren<characteranimation>();
        myBody = GetComponent<Rigidbody>();

        playerTarget = GameObject.FindWithTag(Tags.PLAYER_TAG).transform;
    } 

    // Start is called before the first frame update
    void Start()
    {
        followPlayer = true;
        current_Attack_Time = default_Attack_Time;
        
    }

    // Update is called once per frame
    void Update()
    {
        FollowTarget();
        Attack();
    }

    void FixedUpdate()
    {
        FollowTarget();
        
    }

    void FollowTarget()
    {
        if (!followPlayer)
        {
            return;
        }

        if (Vector3.Distance(transform.position, playerTarget.position) > attack_Distance)
        {
            transform.LookAt(playerTarget);
            myBody.velocity = transform.forward * speed;

            if(myBody.velocity.sqrMagnitude != 0)
            {
                enemyAnime.Walk(true);
            }
        }

        else if (Vector3.Distance(transform.position,playerTarget.position)<= attack_Distance)
        {
            myBody.velocity = Vector3.zero;
            enemyAnime.Walk(false);

            followPlayer = false;
            attackPlayer = true; 
        }

    }// follow target 


    void Attack()
    {
        //if we should not attack the player 
        if (!attackPlayer)
            return;

        current_Attack_Time += Time.deltaTime;

        if (current_Attack_Time > default_Attack_Time)
        {
            enemyAnime.EnemyAttack(Random.Range(0, 3));

            current_Attack_Time = 0f;
        }

        if(Vector3.Distance(transform.position,playerTarget.position)>attack_Distance + chase_Player_After_Attack)
        {
            attackPlayer = false;
            followPlayer = true;
        }

        
    }//Attack 



}//class
