using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseCardController : MonoBehaviour
{
    public Animator anim;
    public void ToggleUsable()
{
    bool state = anim.GetBool("CanUse");
    anim.SetBool("CanUse", !state);
}
}
