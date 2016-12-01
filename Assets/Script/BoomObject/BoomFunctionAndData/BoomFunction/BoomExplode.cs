using UnityEngine;
using System.Collections;

public class BoomExplode : BoomFunction
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomExplode",new BoomExplode());

    public override BoomClassUID GetRTTI()
    {
        return BoomExplode.RTTI;
    }
    
    public BoomExplode()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomExplode();
    }

    private BoomUserAttributeData  m_Data;

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
