﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    [SerializeField] private bool playingAnimation = true;
    [SerializeField] private int index;

    [SerializeField] private float secondPerSprite;

    [SerializeField] private List<Sprite> walkingAnimation;
    [SerializeField] private List<Sprite> idleAnimation;
    [SerializeField] private List<Sprite> attackAnimation;
    [SerializeField] private List<Sprite> dieAnimation;

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        CallAnimation("attack");
    }


    public void CallAnimation(string animationType)
    {
        List<Sprite> animationLoop = new List<Sprite>();
        bool looping = true;
        bool backToIdle = true;

        switch (animationType)
        {
            case "idle":
                animationLoop = idleAnimation;
                break;
            case "attack":
                animationLoop = attackAnimation;
                looping = false;
                break;
            case "walking":
                animationLoop = walkingAnimation;
                break;
            case "die":
                animationLoop = dieAnimation;
                looping = false;
                backToIdle = false;
                break;
        }

        StopAllCoroutines();
        StartCoroutine(LoopAnimation(animationLoop, looping, backToIdle));
    }


    private IEnumerator LoopAnimation(List<Sprite> animationLoop, bool looping, bool backToIdle)
    {
        index = 0;

        while(playingAnimation)
        {
            if (index >= animationLoop.Count - 1)
            {
                if (!looping)
                {
                    if (backToIdle)
                    {
                        CallAnimation("idle");
                    }
                    break;
                }

                index = 0;
            }

            index++;

            spriteRenderer.sprite = animationLoop[index];

            yield return new WaitForSeconds(secondPerSprite);
        }
    }


}