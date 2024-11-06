using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    public Animator anim;
    public void ToggleTaunt()
{
    bool state = anim.GetBool("isTaunt");
    anim.SetBool("isTaunt", !state);
}
}
