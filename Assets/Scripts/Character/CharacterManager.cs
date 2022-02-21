using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string name;
    public string characterName;
    public int i;

    public int commentCount;
    public int commentLikes;

    public float healthMax;
    public float health;
    public float healthRegen;
    public float attack;
}


public class CharacterManager : MonoBehaviour
{
    [SerializeField] private SpriteAnimator spriteAnimator;
    [SerializeField] private Character character;

    private float speed = 2;

    private bool inBattle = false;

    public void Setup(Character character)
    {
        this.character = character;
        spriteAnimator.Setup(character.characterName);


    }

    public void Wander()
    {

    }

    public void MoveTo(Vector3 targetPos)
    {
        spriteAnimator.CallAnimation("walking");

        StartCoroutine(MoveCoroutine(targetPos, speed));
    }

    private IEnumerator MoveCoroutine(Vector3 targetPos, float speed)
    {
        while (Vector3.Distance(transform.position, targetPos) > 0.05f)
        {
            if (inBattle)
            {
                break;
            }

            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            yield return new WaitForEndOfFrame();
        }

        if (!inBattle)
        {
            spriteAnimator.CallAnimation("idle");
        }
    }

    public Character GetCharacter()
    {
        return character;
    }
}
