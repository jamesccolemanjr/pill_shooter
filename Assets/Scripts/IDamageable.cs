using UnityEngine;


//This is an interface, which is an efficient way for projectiles to communicate with the objects they hit
//Every object that implements the IDamageable interface must have a TakeHit function, for example.

public interface IDamageable
{
    void TakeHit(float damage, RaycastHit hit);

}
