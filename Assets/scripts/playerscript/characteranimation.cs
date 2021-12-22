using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characteranimation : MonoBehaviour
{

    private Animator anime;

    void Awake()
    {
        anime = GetComponent<Animator>();
    }

    public void Walk(bool move)
    {
        anime.SetBool(AnimationTags.MOVEMENT, move);
    }

    public void Punch_1()
    {
        anime.SetTrigger(AnimationTags.PUNCH_1_TRIGGER);
    }

    public void Punch_2()
    {
        anime.SetTrigger(AnimationTags.PUNCH_2_TRIGGER);
    }

    public void Punch_3()
    {
        anime.SetTrigger(AnimationTags.PUNCH_3_TRIGGER);
    }

    public void Kick_1()
    {
        anime.SetTrigger(AnimationTags.KICK_1_TRIGGER);
    }

    public void Kick_2()
    {
        anime.SetTrigger(AnimationTags.KICK_2_TRIGGER);
    }


    //ENEMY ANIMATIONS 

    public void EnemyAttack(int attack)
    {
        if (attack == 0)
        {
            anime.SetTrigger(AnimationTags.ATTACK_1_TRIGGER);
        }
        if (attack == 1)
        {
            anime.SetTrigger(AnimationTags.ATTACK_2_TRIGGER);
        }
        if (attack == 2)
        {
            anime.SetTrigger(AnimationTags.ATTACK_3_TRIGGER);
        }
    } //enemy attack 

    public void Play_IdleAnimation()
    {
        anime.Play(AnimationTags.IDLE_ANIMATION);
    }

    public void KnockDown()
    {
        anime.SetTrigger(AnimationTags.KNOCK_DOWN_TRIGGER);
    }

    public void StandUp()
    {
        anime.SetTrigger(AnimationTags.STAND_UP_TRIGGER);
    }
    public void Hit()
    {
        anime.SetTrigger(AnimationTags.HIT_TRIGGER);
    }
    public void Death()
    {
        anime.SetTrigger(AnimationTags.DEATH_TRIGGER);
    }

}//class
