using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

namespace MrHuTools
{

    [AddComponentMenu("UI/Effects/Tendency")]
    public class Tendency : BaseMeshEffect
    {
        public enum Type
        {
            Vertical,
            Horizontal
        }
        [SerializeField]
        public Type TendencyCare= Type.Vertical;

        [SerializeField]
        [Range(-1.5f, 1.5f)]
        public float Attire= 0f;

        [SerializeField]
        public Color32 CrossBelow= Color.white;
        [SerializeField]
        public Color32 FlyBelow= Color.black;

        public override void ModifyMesh(VertexHelper helper)
        {
            if (!IsActive() || helper.currentVertCount == 0)
                return;

            List<UIVertex> _vertexList = new List<UIVertex>();
            helper.GetUIVertexStream(_vertexList);

            int nCount = _vertexList.Count;
            switch (TendencyCare)
            {
                case Type.Vertical:
                    {
                        float fBottomY = _vertexList[0].position.y;
                        float fTopY = _vertexList[0].position.y;
                        float fYPos = 0f;

                        for (int i = nCount - 1; i >= 1; --i)
                        {
                            fYPos = _vertexList[i].position.y;
                            if (fYPos > fTopY)
                                fTopY = fYPos;
                            else if (fYPos < fBottomY)
                                fBottomY = fYPos;
                        }

                        float fUIElementHeight =  fTopY - fBottomY;
                        Debug.Log("最低点" + fBottomY);
                        Debug.Log("最高点" + fTopY);
                        UIVertex v = new UIVertex();

                        for (int i = 0; i < helper.currentVertCount; i++)
                        {
                            helper.PopulateUIVertex(ref v, i);
                            v.color = Color32.Lerp(FlyBelow, CrossBelow, (v.position.y - fBottomY) / fUIElementHeight - Attire);
                            helper.SetUIVertex(v, i);
                        }
                    }
                    break;
                case Type.Horizontal:
                    {
                        float fLeftX = _vertexList[0].position.x;
                        float fRightX = _vertexList[0].position.x;
                        float fXPos = 0f;

                        for (int i = nCount - 1; i >= 1; --i)
                        {
                            fXPos = _vertexList[i].position.x;
                            if (fXPos > fRightX)
                                fRightX = fXPos;
                            else if (fXPos < fLeftX)
                                fLeftX = fXPos;
                        }

                        float fUIElementWidth = 1f / (fRightX - fLeftX);
                        UIVertex v = new UIVertex();

                        for (int i = 0; i < helper.currentVertCount; i++)
                        {
                            helper.PopulateUIVertex(ref v, i);
                            v.color = Color32.Lerp(FlyBelow, CrossBelow, (v.position.x - fLeftX) * fUIElementWidth - Attire);
                            helper.SetUIVertex(v, i);
                        }

                    }
                    break;
                default:
                    break;
            }
        }
    }
}
