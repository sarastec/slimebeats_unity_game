using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private SpriteRenderer theSR;
    public Sprite defaultImage;
    public Sprite attackImage;
    public Sprite jumpImage;

    public KeyCode keyToAttack;
    public KeyCode keyToJump;

    // Start is called before the first frame update
    void Start()
    {
        theSR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(keyToAttack))
        {
            theSR.sprite = attackImage;
        }
        
        if(Input.GetKeyDown(keyToAttack))
        {
            theSR.sprite = defaultImage;
        }

        if(Input.GetKeyDown(keyToJump))
        {
            theSR.sprite = jumpImage;
        }
        
        if(Input.GetKeyDown(keyToJump))
        {
            theSR.sprite = jumpImage;
        }
    }
}
