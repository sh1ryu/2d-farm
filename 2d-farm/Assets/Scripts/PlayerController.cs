using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Sprite forwardSprite;
    public Sprite backwardSprite;
    public Sprite rightSprite;
    public Sprite leftSprite;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Установили компонент, который выполнится хоть раз
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // объявили кнопки для нажатий
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // установили взаимодействие, сразу через 3 вектор.
        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (horizontalInput > 0)
        {
            spriteRenderer.sprite = rightSprite;
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.sprite = leftSprite;
        }
        else if (verticalInput > 0)
        {
            spriteRenderer.sprite = forwardSprite;
        }
        else if (verticalInput < 0)
        {
            spriteRenderer.sprite = backwardSprite;
        }
    }
}
