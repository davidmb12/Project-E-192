using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    Animator animator;
    PlayerController playerController;
    private void Awake()
    {
        animator = GetComponentInChildren<Animator>();
    }
    private void Start()
    {
        playerController = GetComponentInParent<PlayerController>();
    }
    private void Update()
    {
    }
    private void LateUpdate()
    {

    }

    
    public void SetAnimatorFloat(string paramName,float value,float damp)
    {
        animator.SetFloat(paramName,value,damp,Time.deltaTime);
    }

    public void SetAnimatorBool(string paramName, bool value)
    {
        animator.SetBool(paramName, value);
    }

    public void PlayCrossFade(string animName)
    {
        animator.CrossFade(animName, 0.2f);
    }
}
