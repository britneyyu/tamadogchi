using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feed : MonoBehaviour
{
  void Start()
   {
      Vector3 newPosition = transform.position;
      transform.position = new Vector2(1, 1);
      // Moving object on a single axis
      newPosition.y = 100; // We set a axis, in this case the y axis
      
   }
  
  private void Update()
   {
      // We add +1 to the x axis every frame.
      // Time.deltaTime is the time it took to complete the last frame
      // The result of this is that the object moves one unit on the x axis every second
      transform.position += new Vector3(0, 1 * Time.deltaTime, 0);
   }
}
