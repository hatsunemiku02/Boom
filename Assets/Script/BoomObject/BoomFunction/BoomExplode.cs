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
}
