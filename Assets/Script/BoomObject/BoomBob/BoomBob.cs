using UnityEngine;
using System.Collections;

public class BoomBob : BoomFunctionEntity {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomBob",new BoomBob());

    public override BoomClassUID GetRTTI()
    {
        return BoomBob.RTTI;
    }

    public BoomBob()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomBob();
    }
}
