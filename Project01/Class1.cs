using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class GameManager : MonoBehaviour
    {
        public GameObject movableObject; // Drag the object you want to move in the inspector
        public MoveObject moveScript;

        void Start()
        {
            moveScript = movableObject.GetComponent<MoveObject>();
        }

        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                moveScript.speed = 5.0f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                moveScript.speed = -5.0f;
            }
        }
    }
