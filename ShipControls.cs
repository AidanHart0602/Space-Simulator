using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{
    [SerializeField] private float _rotSpeed;
    [SerializeField] private float _moveSpeed = 10;
    [SerializeField] private float _currentSpeed;
    private float _roll;
    private float _yaw;
    private float _pitch;

    // Start is called before the first frame update
    void Start()
    {
        _currentSpeed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ShipMovement();
    }

    private void ShipMovement()
    {
        //Ship Speed

        if (Input.GetKeyDown(KeyCode.T))
        {
            _currentSpeed++;
            if (_currentSpeed > _moveSpeed)
            {
                _currentSpeed = _moveSpeed;
            }
        }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            _currentSpeed--;
            if (_currentSpeed < 1)
            {
                _currentSpeed = 1;
            }
        }

        transform.position += transform.forward * _currentSpeed * Time.deltaTime;

        //Ship Rotation

        _roll = Input.GetAxis("Vertical");
        _pitch = Input.GetAxis("Horizontal");
        _yaw = Input.GetAxis("Yaw");

        transform.Rotate(_roll * _rotSpeed * Time.deltaTime,
                        _pitch * _rotSpeed * Time.deltaTime,
                        _yaw * _rotSpeed * Time.deltaTime);

    }
}
