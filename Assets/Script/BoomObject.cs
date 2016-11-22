using UnityEngine;
using System.Collections;


public class BoomObject
{
    public static BoomClassUID RTTI = new BoomClassUID("BoomObject",new BoomObject());
   
    public virtual BoomClassUID GetRTTI()
    {
        return BoomObject.RTTI;
    }

    public BoomObject()
    {

    }

    public virtual BoomObject CreateInstance()
    {
        return new BoomObject();
    }
}
