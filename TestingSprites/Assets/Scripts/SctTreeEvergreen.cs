using System.Collections.Generic;
using UnityEngine;

namespace nsTreeEvergreen
{
    public class SctTreeEvergreen : MonoBehaviour
    {
        [SerializeField] private List<SpriteRenderer> m_trunks;
        [SerializeField] private List<SpriteRenderer> m_level1;
        [SerializeField] private List<SpriteRenderer> m_level2;
        [SerializeField] private List<SpriteRenderer> m_level3;
        [SerializeField] private List<SpriteRenderer> m_level4;
        [SerializeField] private List<Color> m_trunkColors;
        [SerializeField] private List<Color> m_leavesColors;

        private void Start()
        {
            SpawnTreePart(m_trunks, m_trunkColors, 1);
            SpawnTreePart(m_level1, m_leavesColors, 2);
            SpawnTreePart(m_level2, m_leavesColors, 3);
            SpawnTreePart(m_level3, m_leavesColors, 4);
            SpawnTreePart(m_level4, m_leavesColors, 5);
        }

        private void SpawnTreePart(List<SpriteRenderer> parts, List<Color> colors, int n)
        {
            int i = Random.Range(0, parts.Count);
            SpriteRenderer newPart = Instantiate(parts[i], transform);
            newPart.transform.Translate(0.1f * n * Vector3.back);
            i = Random.Range(0, colors.Count);
            newPart.color = colors[i];
        }
    }
}
