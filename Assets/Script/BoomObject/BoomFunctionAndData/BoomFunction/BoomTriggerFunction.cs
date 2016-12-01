using UnityEngine;
using System.Collections;

public class BoomTriggerFunction : BoomFunction {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomTriggerFunction", new BoomTriggerFunction());

    public override BoomClassUID GetRTTI()
    {
        return BoomTriggerFunction.RTTI;
    }

    public BoomTriggerFunction()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomTriggerFunction();
    }

    public override void Init(BoomFunctionEntity owner)
    {
        base.Init(owner);
    }

    public override void Discard()
    {
        
    }

    public override void ExecuteFunction()
    {
        
    }

    public virtual void ExecuteTriggerFunction(Collider self,Collider target)
    {

    }
}
