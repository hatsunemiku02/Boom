using UnityEngine;
using System.Collections;

public class BoomDude : BoomFunctionEntity {
    public static new BoomClassUID RTTI = new BoomClassUID("BoomDude" , new BoomDude());

    public override BoomClassUID GetRTTI()
    {
        return BoomDude.RTTI;
    }

    public BoomDude()
    {

    }

    public override BoomObject CreateInstance()
    {
        return new BoomDude();
    }

    public override void Init(string name)
    {
        base.Init(name);
        AddFunction(BoomMove.RTTI);
    }
}
