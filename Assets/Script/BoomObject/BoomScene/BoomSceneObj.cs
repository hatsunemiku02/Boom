using UnityEngine;
using System.Collections;

public class BoomSceneObj : BoomObject {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomSceneObj", new BoomSceneObj());

    public override BoomClassUID GetRTTI()
    {
        return BoomSceneObj.RTTI;
    }

    public BoomSceneObj()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomSceneObj();
    }

}
