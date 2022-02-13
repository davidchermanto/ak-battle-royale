using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    [SerializeField] private SpriteAnimator spriteAnimator;
    [SerializeField] private CharacterPositionController positionController;

    private float speed = 2;

    private bool inBattle = false;

    private void Start()
    {
        StartCoroutine(D());
    }

    private IEnumerator D()
    {
        yield return new WaitForSeconds(0.1f);
        MoveTo(new Vector3(15, 0.7f, 0));
    }

    public void Setup()
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
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

            yield return new WaitForEndOfFrame();
        }

        spriteAnimator.CallAnimation("idle");

        if (!inBattle)
        {

        }
    }
}
