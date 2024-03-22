using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveJoystick : MonoBehaviour
{

    /*
        Importar o pacote Simple Touch Controller
        https://assetstore.unity.com/packages/tools/input-management/simple-touch-controller-74107

        - Criar um canvas
        - Adicionar o prefab Joystick e aumentar o tamanho

    */

    // - leftController é o prefab adicionado no Canvas
    public SimpleTouchController leftController;

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
        inputHorizontal = leftController.GetTouchPosition.x;
        inputVertical = leftController.GetTouchPosition.y;
        player.Translate(inputHorizontal * velocity * Time.deltaTime, 0, inputVertical * velocity * Time.deltaTime);
    }
}
