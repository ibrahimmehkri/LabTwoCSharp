using System; 
using System.Collections.Generic;

namespace LabOne
{
    class SortedPosList
    {
        private List<Position> posList = new List<Position>();

        public int Count 
        {
            get
            {
                return posList.Count; 
            }
        }
        public Position this[int index]
        {
            get
            {
             return posList[index];
            }
        }
        public void Add(Position p)
        {
            posList.Add(p); 
            for(int i = 0; i < posList.Count; i++)
            {
                for(int j = i + 1; j < posList.Count; j++)
                {
                    if(posList[i] > posList[j])
                    {
                        Position temp = posList[i];
                        posList[i] = posList[j]; 
                        posList[j] = temp; 
                    }
                }
            }
        }
        public void Remove(Position p)
        {
            posList.Remove(p);
        }
        public SortedPosList Clone()
        {
            SortedPosList s = new SortedPosList(); 
            foreach(var item in posList)
            {
                s.Add(item.Clone());
            }
            return s; 
        }
        public SortedPosList circleContent(Position centerPos, double radius)
        {
            SortedPosList s = this.Clone(); 
            for(int i = 0; i < s.Count; i++)
            {
                if(!(s[i] % centerPos < radius))
                {
                    s.Remove(s[i]);
                }
            }
            return s; 
        }

        public override string ToString()
        {
            return string.Join(", ", posList);
        }

        public static SortedPosList operator +(SortedPosList s1, SortedPosList s2)
        {
            for(int i = 0; i < s2.Count; i++)
            {
                s1.Add(s2[i]);
            }
            return s1.Clone();
        }
    }
}