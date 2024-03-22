using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveTouch : MonoBehaviour
{

    public enum Direcional
    {
        Cima, Direita, Baixo, Esquerda
    }

    public Direcional direcional = Direcional.Cima;

    float velocity = 5f;

    float inputHorizontal;
    float inputVertical;

    void Update()
    {
        if (Input.touchCount > 0)
        {

            Debug.Log(Input.GetTouch(0).fingerId);

            float positionX = Input.GetTouch(0).position.x;
            float positionY = Input.GetTouch(0).position.y;
            if (Screen.width / 2 < positionX)
            {
                inputHorizontal = 1;
            }
            else
            {
                inputHorizontal = -1;
            }
            if (Screen.height / 2 < positionY)
            {
                inputVertical = 1;
            }
            else
            {
                inputVertical = -1;
            }
        }
        else
        {
            inputHorizontal = 0;
            inputVertical = 0;
        }

        transform.Translate(inputHorizontal * velocity * Time.deltaTime, 0, inputVertical * velocity * Time.deltaTime);

    }

}
