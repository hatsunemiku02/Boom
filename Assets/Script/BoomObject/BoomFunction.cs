using UnityEngine;
using System.Collections;



public class BoomFunction : BoomRefObject {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomFunction",new BoomFunction());

    public override BoomClassUID GetRTTI()
    {
        return BoomFunction.RTTI;
    }

    public BoomFunction()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomFunction();
    }

    public BoomFunctionEntity Owner
    {
        get
        {
            return m_Owner;
        }
    }

    private BoomFunctionEntity m_Owner;
    public virtual void Init(BoomFunctionEntity owner)
    {
        m_Owner = owner;
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
