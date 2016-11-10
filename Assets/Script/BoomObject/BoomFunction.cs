using UnityEngine;
using System.Collections;



public class BoomFunction : BoomObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomFunction");

    public override BoomClassUID GetRTTI()
    {
        return BoomFunction.RTTI;
    }

    public BoomFunctionEntity Owner
    {
        get;
        set; 
    }
    public virtual void Init()
    {
        Debug.LogError(" executing base boom Init function! ");
    }

    public virtual void Discard()
    {
        Debug.LogError(" executing base boom Discard function! ");
    }

    public virtual void ExecuteFunction()
    {
        Debug.LogError(" executing base boom Execute function! ");
    }
}
