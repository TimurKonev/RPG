﻿using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace a_player
{
    public class with_positive_vertical_input
    {
        [UnityTest]
        public IEnumerator moves_forward()
        {
            var floor = GameObject.CreatePrimitive(PrimitiveType.Cube);
            floor.transform.localScale = new Vector3(50, 0.1f, 50);
            floor.transform.position = Vector3.zero;

            var playerObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            playerObject.AddComponent<CharacterController>();
            playerObject.AddComponent<Player>();
            playerObject.transform.position = new Vector3(0, 1.5f, 0);

            Player player = playerObject.AddComponent<Player>();
            player.PlayerInput.Vertical = 1f;

            float startingZPosition = player.transform.position.z;
            yield return new WaitForSeconds(5f);
            float endingZPosition = player.transform.position.z;
            Assert.Greater(endingZPosition, startingZPosition);

        }
    }
}