using UnityEngine;
using System.Collections;

public class BoomTrigger : BoomEntity {

    public static new BoomClassUID RTTI = new BoomClassUID("BoomTrigger", new BoomTrigger());

    public override BoomClassUID GetRTTI()
    {
        return BoomTrigger.RTTI;
    }

    public BoomTrigger()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomTrigger();
    }
}
