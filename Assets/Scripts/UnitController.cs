using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public Animator anim;
    public void ToggleTaunt()
{
    int state = anim.GetInteger("State");
    anim.SetInteger("State", state==0 ? 1 : 0);
}
}
