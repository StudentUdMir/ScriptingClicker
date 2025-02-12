using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusClicker : MonoBehaviour
{
    public Clicker clicker;
    private Vector2 targetPosition;
    private float moveStep = 3f;
    void Start()
    {
        targetPosition = GetRandomPoint();
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position,
            targetPosition, moveStep * Time.deltaTime);


        if ((Vector2)transform.position == targetPosition)
        {
            targetPosition = GetRandomPoint();
        }
    }

    Vector2 GetRandomPoint()
    {
        Vector2 randomVector = new Vector2();

        randomVector.x = Random.Range(-2f, 2f);
        randomVector.y = Random.Range(-0.9f, 1.1f);

        return randomVector;
    }


    void OnMouseDown()
    {
        clicker.counter += 10;
        clicker.counterText.text = clicker.counter.ToString();
    }
}
