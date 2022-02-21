using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct AnimationSprites
{
    public string name;

    public List<Sprite> walkingAnimation;
    public List<Sprite> idleAnimation;
    public List<Sprite> attackAnimation;
    public List<Sprite> dieAnimation;

    public AnimationSprites(string name, List<Sprite> walkingAnimation, List<Sprite> idleAnimation, List<Sprite> attackAnimation, List<Sprite> dieAnimation)
    {
        this.name = name;

        this.walkingAnimation = walkingAnimation;
        this.idleAnimation = idleAnimation;
        this.attackAnimation = attackAnimation;
        this.dieAnimation = dieAnimation;
    }
}

public class SpriteDatabase : MonoBehaviour
{
    public static SpriteDatabase Instance;

    [SerializeField] public List<AnimationSprites> animationSprites;

    private void Awake()
    {
        Instance = this;
    }

    public AnimationSprites GetSpritesByName(string name)
    {
        foreach(AnimationSprites animationSprites in animationSprites)
        {
            if (animationSprites.name.Equals(name))
            {
                return animationSprites;
            }
        }

        return new AnimationSprites();
    }
}
