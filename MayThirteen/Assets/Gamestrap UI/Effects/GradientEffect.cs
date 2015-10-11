using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

namespace Gamestrap
{
    [AddComponentMenu("UI/Gamestrap UI/Gradient")]
    public class GradientEffect : BaseMeshEffect
    {
        public Color top = Color.white;
        public Color bottom = Color.white;

        public override void ModifyMesh(Mesh mesh)
        {
            if (!this.IsActive())
                return;

            List<UIVertex> list = new List<UIVertex>();
            using (VertexHelper vertexHelper = new VertexHelper(mesh))
            {
                vertexHelper.GetUIVertexStream(list);
            }

            ModifyVertices(list);  // calls the old ModifyVertices which was used on pre 5.2

            using (VertexHelper vertexHelper2 = new VertexHelper())
            {
                vertexHelper2.AddUIVertexTriangleStream(list);
                vertexHelper2.FillMesh(mesh);
            }
        }

        public void ModifyVertices(List<UIVertex> vertexList)
        {
            if (!IsActive() || vertexList.Count < 4)
            {
                return;
            }
            if (vertexList.Count == 4)
            {
                SetVertexColor(vertexList, 0, bottom);
                SetVertexColor(vertexList, 1, top);
                SetVertexColor(vertexList, 2, top);
                SetVertexColor(vertexList, 3, bottom);
            }
            else
            {
                float bottomPos = vertexList[vertexList.Count - 1].position.y;
                float topPos =vertexList[0].position.y;

                float height = topPos - bottomPos;

                for (int i = 0; i < vertexList.Count; i++)
                {
                    UIVertex v = vertexList[i];
                    v.color *= Color.Lerp(top, bottom, ((v.position.y) - bottomPos) / height);
                    vertexList[i] = v;
                }
            }
        }

        private void SetVertexColor(List<UIVertex> vertexList, int index, Color color)
        {
            UIVertex v = vertexList[index];
            v.color = color;
            vertexList[index] = v;
        }

    }
}
