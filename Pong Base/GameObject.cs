using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;

namespace Ping_Pong
{
    class GameObject
    {
        protected float m_X;
        public float X
        {
            get { return m_X; }
            set { m_X = value; }
        }

        protected float m_Y;
        public float Y
        {
            get { return m_Y; }
            set { m_Y = value; }
        }

        protected float m_Width;
        public float Width
        {
            get { return m_Width; }
            set { m_Width = value; }
        }

        protected float m_Height;
        public float Height
        {
            get { return m_Height; }
            set { m_Height = value; }
        }

        public Rectangle Rect
        {
            get { return new Rectangle((int)X, (int)Y, (int)Width, (int)Height); }
        }

        protected object m_Visual = null;
        public object Visual
        {
            get { return m_Visual; }
            set { m_Visual = value; }
        }
    }
}
