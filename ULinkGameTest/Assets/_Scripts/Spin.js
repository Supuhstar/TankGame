#pragma strict

function Start () {

}

public var speedX : float;
public var speedY : float;
public var speedZ : float;

function Update ()
{
	transform.Rotate(new Vector3(speedX, speedY, speedZ));
}