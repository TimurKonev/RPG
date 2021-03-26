using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class a_rotating_cube
    {
       

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        // `yield return null;` to skip a frame.
        [UnityTest]
        public IEnumerator rotating_changes_amount()
        {
            //ARRANGE

            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.rotation = Quaternion.identity;
            
            //ACT
            for (int i = 0; i < 10; i++)
            {
                cube.transform.Rotate(0, 15f, 0);
                yield return null;
            }
            
            //ASSERT
            Assert.AreEqual(150f, cube.transform.localEulerAngles.y);
            
        }
    }
}
