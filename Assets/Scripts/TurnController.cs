using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour
{
    public Animator anim;
    public void ToggleTurn()
{
    bool state = anim.GetBool("Myturn");
    anim.SetBool("Myturn", !state);
}
}
