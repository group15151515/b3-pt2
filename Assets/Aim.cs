using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public Transform Target;
    public Vector3 Offset;

    Animator anim;
    Transform chest;
    void Start()
    {
        anim = GetComponent<Animator>();
        chest = anim.GetBoneTransform(HumanBodyBones.Chest);
    }

    void LateUpdate()
    {
        chest.LookAt(Target.position);
        chest.rotation = chest.rotation * Quaternion.Euler(Offset);
    }
}
