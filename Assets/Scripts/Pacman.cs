using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman: MonoBehaviour
{
    [SerializeField] private Animator pacman;
    private Vector3 endPos;
    private Tweener tweener;
    private int move;
    // Start is called before the first frame update
    void Start()
    {
        move = 0;
        endPos = pacman.transform.position;
        tweener = GetComponent<Tweener>();
        //tweener.AddTween(pacman.transform, pacman.transform.position, pacman.transform.position, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (pacman.transform.position == endPos && move == 0)
        {
            endPos = new Vector3(-2.8f, 14f, 0f);
            tweener.AddTween(pacman.transform, pacman.transform.position, endPos, 1.5f);
            //pacman.transform.Rotate (new Vector3(0f, 0f, -90f));
            move = 1;

        }
        else if (pacman.transform.position == endPos && move ==1)
        {
            endPos = new Vector3(-2.8f, 10f, 0f);
            tweener.AddTween(pacman.transform, pacman.transform.position, endPos, 1.5f);
            //pacman.transform.Rotate(new Vector3(0f, 0f, 90f));
            move = 2;
        }
        else if (pacman.transform.position == endPos && move ==2)
        {
            endPos = new Vector3(-14f, 10f, 0f);
            tweener.AddTween(pacman.transform, pacman.transform.position, endPos, 1.5f);
            //pacman.transform.Rotate (new Vector3(0f, 0f, 180f));
            move = 3;
        }
        else if (pacman.transform.position == endPos && move ==3)
        {
            endPos = new Vector3(-14f, 14f, 0f);
            tweener.AddTween(pacman.transform, pacman.transform.position, endPos, 1.5f);
            //pacman.transform.Rotate (new Vector3(0f, 0f, 90f));
            move = 0;
        }
    }
}
