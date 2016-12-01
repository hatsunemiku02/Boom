using UnityEngine;
using System.Collections;

public class BoomCreateEntity : BoomFunction {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomCreateEntity",new BoomCreateEntity());

    public override BoomClassUID GetRTTI()
    {
        return BoomCreateEntity.RTTI;
    }
   
    public BoomCreateEntity()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomCreateEntity();
    }

    private BoomUserAttributeData m_Data;


    public override void Init(BoomFunctionEntity owner)
    {
        base.Init(owner);
        m_Data = Owner.AddData(BoomUserAttributeData.RTTI) as BoomUserAttributeData;
    }

    public override void ExecuteFunction()
    {
        // Owner.
    }

    public override void Discard()
    {
        Owner.RemoveData(BoomUserAttributeData.RTTI);
        m_Data = null;
    }
}
