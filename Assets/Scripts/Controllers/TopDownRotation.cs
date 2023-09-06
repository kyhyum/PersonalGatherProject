using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownRotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer characterRenderer;
    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnLookAt;
    }

    public void OnLookAt(Vector2 newAimDirection)
    {
        RotateCharacter(newAimDirection);
    }

    private void RotateCharacter(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}