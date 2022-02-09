using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    private Camera mainCamera;
    [SerializeField] private float speed;

    public char forward;
    public char back;
    public char left;
    public char right;

    public char rotateLeft;
    public char rotateRight;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetKey(GetKeyCode(forward)))
        {
            mainCamera.transform.position += transform.forward * Time.deltaTime * speed;
        }
        else if (Input.GetKey(GetKeyCode(back)))
        {
            mainCamera.transform.position += -transform.forward * Time.deltaTime * speed * 0.5f;
        }
        else if (Input.GetKey(GetKeyCode(left)))
        {
            mainCamera.transform.position += -transform.right * Time.deltaTime * speed;
        }
        else if (Input.GetKey(GetKeyCode(right)))
        {
            mainCamera.transform.position += transform.right * Time.deltaTime * speed;
        }
        
        if (Input.GetKey(GetKeyCode(rotateLeft)))
        {
            mainCamera.transform.rotation = Quaternion.Euler(mainCamera.transform.eulerAngles.x, 
                mainCamera.transform.eulerAngles.y + Time.deltaTime * -speed * 5, mainCamera.transform.eulerAngles.z);
        }
        else if (Input.GetKey(GetKeyCode(rotateRight)))
        {
            mainCamera.transform.rotation = Quaternion.Euler(mainCamera.transform.eulerAngles.x,
                mainCamera.transform.eulerAngles.y + Time.deltaTime * speed * 5, mainCamera.transform.eulerAngles.z);
        }
    }

    private KeyCode GetKeyCode(char letter)
    {
        switch (letter)
        {
            case 'W':
                return KeyCode.W;
            case 'A':
                return KeyCode.A;
            case 'S':
                return KeyCode.S;
            case 'D':
                return KeyCode.D;
            case 'Q':
                return KeyCode.Q;
            case 'E':
                return KeyCode.E;
            case 'Z':
                return KeyCode.Z;
            case 'X':
                return KeyCode.X;
            case 'C':
                return KeyCode.C;
            case 'R':
                return KeyCode.R;
            case 'F':
                return KeyCode.F;
            case 'V':
                return KeyCode.V;
            case 'B':
                return KeyCode.B;
            case 'T':
                return KeyCode.T;
            case 'G':
                return KeyCode.G;
            case 'Y':
                return KeyCode.Y;
            case 'H':
                return KeyCode.H;
            case 'N':
                return KeyCode.N;
            case 'U':
                return KeyCode.U;
            case 'J':
                return KeyCode.J;
            case 'M':
                return KeyCode.M;
            case 'I':
                return KeyCode.I;
            case 'K':
                return KeyCode.K;
            case 'O':
                return KeyCode.O;
            case 'L':
                return KeyCode.L;
            case 'P':
                return KeyCode.P;
            case '0':
                return KeyCode.Alpha0;
            case '1':
                return KeyCode.Alpha1;
            case '2':
                return KeyCode.Alpha2;
            case '3':
                return KeyCode.Alpha3;
            case '4':
                return KeyCode.Alpha4;
            case '5':
                return KeyCode.Alpha5;
            case '6':
                return KeyCode.Alpha6;
            case '7':
                return KeyCode.Alpha7;
            case '8':
                return KeyCode.Alpha8;
            case '9':
                return KeyCode.Alpha9;
            case '-':
                return KeyCode.Minus;
            case '=':
                return KeyCode.Equals;
            case '[':
                return KeyCode.LeftBracket;
            case ']':
                return KeyCode.RightBracket;
            case ';':
                return KeyCode.Semicolon;
            case '\'':
                return KeyCode.Quote;
            case ',':
                return KeyCode.Comma;
            case '.':
                return KeyCode.Period;
            default:
                break;
        }

        return KeyCode.None;
    }
}
