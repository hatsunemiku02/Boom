using UnityEngine;
using System.Collections;

public class BoomDamageRevieverFunction : BoomTriggerFunction
{

    public static new BoomClassUID RTTI = new BoomClassUID("BoomDamageRevieverFunction", new BoomDamageRevieverFunction());

    public override BoomClassUID GetRTTI()
    {
        return BoomDamageRevieverFunction.RTTI;
    }

    public BoomDamageRevieverFunction()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomDamageRevieverFunction();
    }

    private BoomUserAttributeData m_Data;
    public override void Init(BoomFunctionEntity owner)
    {
        base.Init(owner);
        m_Data = Owner.AddData(BoomUserAttributeData.RTTI) as BoomUserAttributeData;
    }

    public override void Discard()
    {

    }

    public override void ExecuteFunction()
    {

    }

    public override void ExecuteTriggerFunction(Collider self, Collider target)
    {
        Debug.LogError(self.name + " enter " + target.name);
    }
}