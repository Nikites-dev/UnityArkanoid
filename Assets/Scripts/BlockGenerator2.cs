using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    public class BlockGenerator2: MonoBehaviour
    {
        [SerializeField] private GameObject _blockPrefab;
        [SerializeField] private List<Transform> _blocksPosition;

        private void Start()
        {
            foreach (var item in _blocksPosition)
            {
                var block = Instantiate(_blockPrefab, item.position, Quaternion.identity);
                block.GetComponent<SpriteRenderer>().color = Color.red;
            }
        }
    }
}