using UnityEngine;
using System.Collections;

public class BoomExplode : BoomFunction
{
    public static new BoomClassUID RTTI = new BoomClassUID("BoomExplode");

    public override BoomClassUID GetRTTI()
    {
        return BoomExplode.RTTI;
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
