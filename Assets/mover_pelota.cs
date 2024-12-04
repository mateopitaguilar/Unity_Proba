using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverflechas : MonoBehaviour
{

Vector3 movyup = new Vector3(0, 1, 0);
Vector3 movydown = new Vector3(0, -1, 0);
Vector3 movxup = new Vector3(1, 0, 0);
Vector3 movxdown = new Vector3(-1, 0, 0);
Vector3 movzup = new Vector3(0, 0, 1);
Vector3 movzdown = new Vector3(0, 0, -1);
int velocidad = 10;

// Start is called before the first frame update
void Start()
{

}

// Update is called once per frame
void Update()
{

if (Input.GetKey(KeyCode.UpArrow)) transform.Translate(movyup * Time.deltaTime * velocidad);
if (Input.GetKey(KeyCode.DownArrow)) transform.Translate(movydown * Time.deltaTime * velocidad);
if (Input.GetKey(KeyCode.RightArrow)) transform.Translate(movxup * Time.deltaTime * velocidad);
if (Input.GetKey(KeyCode.LeftArrow)) transform.Translate(movxdown * Time.deltaTime * velocidad);
if (Input.GetKey(KeyCode.A)) transform.Translate(movzup * Time.deltaTime * velocidad);
if (Input.GetKey(KeyCode.Z)) transform.Translate(movzdown * Time.deltaTime * velocidad);

}
}