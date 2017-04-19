using UnityEngine;
using System.Collections;

public class RoombaMovement : MonoBehaviour
{
    [SerializeField] float movementSpeed = 10;
    [SerializeField] float rotationSpeed = 10;
    [SerializeField] string roombaMovement = "RoombaMovement_P1";
    [SerializeField] string roombaRotation = "RoombaRotation_P1";

    private Rigidbody2D roombaRigidBody;

	// Use this for initialization
	void Start ()
    {
        roombaRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
	}

    void FixedUpdate()
    {
        DoRoombaMovement();
    }

    void DoRoombaMovement()
    {
        float movementVertical = Input.GetAxis(roombaMovement);
        float movementRotation = Input.GetAxis(roombaRotation);
    }
}
