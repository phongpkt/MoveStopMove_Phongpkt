using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : IState
{
    public void OnEnter (Character character)
    {
        character.ChangeAnim(Constants.ANIM_IDLE);
    }
    public void OnExecute (Character character) 
    {
        
    }
    public void OnExit (Character character)
    {

    }
}
