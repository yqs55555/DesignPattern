using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern_CSharp.ProxyPattern.Example2
{
    public class PersonImpl : IPerson
    {
        private string m_name;
        private string m_gender;
        private string m_interests;
        private int m_rating;
        private int m_ratingCount = default(int);

        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public string Gender
        {
            get => m_gender;
            set => m_gender = value;
        }

        public string Interests
        {
            get => m_interests;
            set => m_interests = value;
        }

        public int HotOrNotRating
        {
            get => m_ratingCount == 0 ? 0 : (m_rating / m_ratingCount);
            set
            {
                this.m_rating += value;
                this.m_ratingCount++;
            }
        }
    }
}
