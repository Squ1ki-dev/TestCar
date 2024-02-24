using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour, IMovement
{
    [SerializeField] private Transform car;
    [SerializeField] private float _movementSpeed, _limitX;
    private float horizontalAcceleration = 0;
    private float _speedMultiplier = 2f;

    private void Update() => UpdatePosition();

    private void UpdatePosition()
    {
        var xPos = car.transform.localPosition.x;
        xPos += horizontalAcceleration * Time.deltaTime * _movementSpeed;
        xPos = Mathf.Clamp(xPos, -_limitX, _limitX);

        car.transform.localPosition = new Vector3 (xPos, 0f, 0);
    }

    public void HorizontalMovement(bool isLeftHold) => horizontalAcceleration = isLeftHold ? -_speedMultiplier : _speedMultiplier;
    public void Stop() => horizontalAcceleration = 0f;
}
