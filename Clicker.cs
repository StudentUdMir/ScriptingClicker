using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public TextMeshProUGUI counterText;
    public Animator animator;

    public int counter = 0;

    void OnMouseDown()
    {
        counter++;
        counterText.text = counter.ToString();
        animator.Play("Click");
    }
  }
