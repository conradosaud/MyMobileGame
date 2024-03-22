using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public enum Direcional
    {
        Cima, Direita, Baixo, Esquerda
    }

    public Direcional direcional = Direcional.Cima;

    float velocity = 5f;

    float inputHorizontal = 0;
    float inputVertical = 0;

    Transform player;

    private void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    void Update()
    {
        player.Translate(inputHorizontal * velocity * Time.deltaTime, 0, inputVertical * velocity * Time.deltaTime);
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if (direcional == Direcional.Direita)
        {
            inputHorizontal = 1;
        }
        else if (direcional == Direcional.Esquerda)
        {
            inputHorizontal = -1;
        }
        else if (direcional == Direcional.Cima)
        {
            inputVertical = 1;
        }
        else if (direcional == Direcional.Baixo)
        {
            inputVertical = -1;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        inputHorizontal = 0;
        inputVertical = 0;
    }
}
