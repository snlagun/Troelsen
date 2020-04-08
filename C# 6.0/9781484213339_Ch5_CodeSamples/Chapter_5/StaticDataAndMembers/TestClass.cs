using System;
using System.Configuration;

namespace StaticDataAndMembers
{
    public class TestClass
    {
        public int mProp1 = 3;


        public int SetProp1
        {
            get { return mProp1; }
            set
            {
                mProp1 = value == 0 ? 0 : 1;
            }
        }
    }
}