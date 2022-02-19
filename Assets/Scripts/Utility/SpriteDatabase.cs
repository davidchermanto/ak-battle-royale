using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct AnimationSprites
{
    public List<Sprite> walkingAnimation;
    public List<Sprite> idleAnimation;
    public List<Sprite> attackAnimation;
    public List<Sprite> dieAnimation;

    public AnimationSprites(List<Sprite> walkingAnimation, List<Sprite> idleAnimation, List<Sprite> attackAnimation, List<Sprite> dieAnimation)
    {
        this.walkingAnimation = walkingAnimation;
        this.idleAnimation = idleAnimation;
        this.attackAnimation = attackAnimation;
        this.dieAnimation = dieAnimation;
    }
}

public class SpriteDatabase : MonoBehaviour
{
    
}
