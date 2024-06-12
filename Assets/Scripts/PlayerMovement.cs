using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 positionUp;
    public Vector3 positionDown;
    public KeyCode jumpKey;
    public KeyCode attackKey;
    private Animator animator;
    public float delay = 0.3f;
    private bool attackBlocked;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 position = transform.position;

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("space key was pressed");
        //    if(position == positionUp)
        //    {
        //        Debug.Log("player is up");
        //        position = positionDown;
        //        transform.position = position;
        //    }
        //    else if(position == positionDown)
        //    {
        //        Debug.Log("player is down");
        //        position = positionUp;
        //        transform.position = position;
        //    }
        //}

        if (Input.GetKeyDown(attackKey))
        {
            Attack();
        }
    }

    public void Attack()
    {
        if(attackBlocked) return;

        animator.SetTrigger("Attack");
        //attackBlocked = true;
        //StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        yield return new WaitForSeconds(delay);
        attackBlocked = false;
    }
}
