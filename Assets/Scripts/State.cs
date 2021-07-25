using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class State
{
    public enum STATE
    {
        PLAY, GAMEOVER
    }

    public enum EVENT
    {
        EXIT, UPDATE, ENTER
    }

    public STATE name;
    protected EVENT stage;
    protected State nextState;

    public State()
    {
        
    }

    public virtual void Enter()
    {
        stage = EVENT.UPDATE;
    }
    public virtual void Update()
    {
        stage = EVENT.UPDATE;
    }
    public virtual void Exit()
    {
        stage = EVENT.EXIT;
    }

    public State process()
    {
        if (stage == EVENT.ENTER) Enter();
        if (stage == EVENT.UPDATE) Update();
        if (stage == EVENT.EXIT)
        {
            Exit();
            return nextState;
        }
        return this;
    }

}
