using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actions : MonoBehaviour
{
    public delegate void StartDelegate();
    public delegate void UpdateDelegate();
    public delegate void FinishedDelegate();

    private StartDelegate StartDelegateFunction;
    private UpdateDelegate UpdateDelegateFunction;
    private FinishedDelegate FinishedDelegateFunction;

    //Start
    public void tweenStart()
    {
        StartDelegateFunction = StartTweenDelegateFunction;

        StartDelegateFunction();
    }

    private void StartTweenDelegateFunction()
    {
        print("De tween is gestart!");
    }

    //Update
    public void tweenUpdate()
    {
        UpdateDelegateFunction = UpdateTweenDelegateFunction;

        UpdateDelegateFunction();
    }

    private void UpdateTweenDelegateFunction()
    {
        print("De tween wordt geupdate!");
    }

    //Finished
    public void tweenFinished()
    {
        FinishedDelegateFunction = FinishTweenDelegateFunction;

        FinishedDelegateFunction();
    }

    private void FinishTweenDelegateFunction()
    {
        print("De tween is klaar!");
    }
}
