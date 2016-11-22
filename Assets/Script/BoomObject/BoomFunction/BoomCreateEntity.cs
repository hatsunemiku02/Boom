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
}
