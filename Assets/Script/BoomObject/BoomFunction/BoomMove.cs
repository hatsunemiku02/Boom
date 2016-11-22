using UnityEngine;
using System.Collections;

public class BoomMove : BoomFunction
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomMove" , new BoomMove());

    public override BoomClassUID GetRTTI()
    {
        return BoomMove.RTTI;
    }

    public BoomMove()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomMove();
    }

    private BoomTransFormData m_Data;


    public override void Init(BoomFunctionEntity owner)
    {
        base.Init(owner);
        m_Data = Owner.AddData(BoomTransFormData.RTTI) as BoomTransFormData;
    }

    public void SetPosition(Vector3 pos)
    {
        m_Data.Position = pos;
    }

    public void SetRotation(Quaternion qua)
    {
        m_Data.Rotation = qua;
    }

    public void SetScale(Vector3 scale)
    {
        //
    }


    public override void  ExecuteFunction()
    {
       // Owner.
    }

    public override void Discard()
    {
        Owner.RemoveData(BoomTransFormData.RTTI);
        m_Data = null;
    }

}
