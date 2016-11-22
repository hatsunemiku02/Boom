using UnityEngine;
using System.Collections;

public class BoomTest : MonoBehaviour {
    public Vector3 dudePos;
    BoomDude dude;
	// Use this for initialization
	void Start () {
        dude = BoomDude.RTTI.CreateInstance() as BoomDude;
        dude.Init("your dude");
    }
	
	// Update is called once per frame
	void Update () {
        BoomMove dudemove = dude.GetFunction(BoomMove.RTTI) as BoomMove;
        dudemove.SetPosition(dudePos);

    }
}
