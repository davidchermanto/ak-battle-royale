using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string name;
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

    //
    private void Start()
    {
        StartCoroutine(D());
    }

    private IEnumerator D()
    {
        yield return new WaitForSeconds(0.1f);
        MoveTo(new Vector3(15, 0.7f, 0));
    }
    //

    public void Setup(Character character)
    {
        this.character = character;

        // setup sprites
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
}
