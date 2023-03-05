using UnityEngine;

public class Player : MonoBehaviour {

  [SerializeField] private float moveSpeed = 7;

  private void Update() {
    Vector2 input = new();
    //if (Input.GetKey(KeyCode.W)) input.y += 1;
    //if (Input.GetKey(KeyCode.S)) input.y -= 1;
    //if (Input.GetKey(KeyCode.A)) input.x -= 1;
    //if (Input.GetKey(KeyCode.D)) input.x += 1;
    if (Input.GetKey(KeyCode.E)) input.y += 1;
    if (Input.GetKey(KeyCode.D)) input.y -= 1;
    if (Input.GetKey(KeyCode.S)) input.x -= 1;
    if (Input.GetKey(KeyCode.F)) input.x += 1;
    input.Normalize();

    Vector3 moveDir = new(input.x, 0, input.y);
    transform.position += Time.deltaTime * moveSpeed * moveDir;

    if (input.magnitude > 0)
      transform.forward = Vector3.Slerp(transform.forward, moveDir, Time.deltaTime * 10);
  }  
}
