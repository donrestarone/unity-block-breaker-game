using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  // config params
  [SerializeField] Paddle paddle1;
  [SerializeField] float xPush = 2f;
  [SerializeField] float yPush = 15f;
  
  // state
  Vector2 paddleToBallVector;
  bool hasStarted = false;
  void Start()
  {
    // the transform here references the transform for the ball (check in unity inspector for ball)
    paddleToBallVector = transform.position - paddle1.transform.position;
  }

  // Update is called once per frame
  void Update()
  {
    if (!hasStarted) {
      LockBallToPaddle();
      LaunchBallOnMouseClick();
    }
  }

  private void LockBallToPaddle()
  {
    Vector2 paddlePosition = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
    transform.position = paddlePosition + paddleToBallVector;
  }

  private void LaunchBallOnMouseClick()
  {
    // if left mouse button is clicked
    if (Input.GetMouseButtonDown(0))
    {
      GetComponent<Rigidbody2D>().velocity = new Vector2(xPush, yPush);
      hasStarted = true;
    }
  }
}
