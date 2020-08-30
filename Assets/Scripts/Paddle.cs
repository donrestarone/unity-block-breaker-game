using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
  // configuration parameters
  [SerializeField] float minX = 1f;
  [SerializeField] float maxX = 15f;
  [SerializeField] float screenWidthInUnits = 16f;

  // state
  Vector2 paddlePosition;
  void Start()
  {
      
  }

  // Update is called once per frame
  void Update()
  {
    float mousePositionInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
    paddlePosition = new Vector2(mousePositionInUnits, transform.position.y);
    paddlePosition.x = Mathf.Clamp(mousePositionInUnits, minX, maxX);
    transform.position = paddlePosition;
  }
}
