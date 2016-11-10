using UnityEngine;
using System.Collections;

public class BoomMove : BoomFunction
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomMove");

    public override BoomClassUID GetRTTI()
    {
        return BoomMove.RTTI;
    }
    public override void Init()
    {
       
        if (Owner.HaveData(BoomTransFormData.RTTI))
        {

        }
    }


    public override void  ExecuteFunction()
    {
       // Owner.
    }

    public override void Discard()
    {
        
    }

}
