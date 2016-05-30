﻿using System;

namespace GSharp.Extension.Optionals
{
    [Serializable]
    public class GOptional
    {
        #region 속성
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        private string _Name;

        public string FullName
        {
            get
            {
                return _FullName;
            }
        }
        private string _FullName;

        public string FriendlyName
        {
            get
            {
                return _FriendlyName;
            }
        }
        private string _FriendlyName;
        #endregion

        #region 생성자
        public GOptional(string name, string fullName, string friendlyName)
        {
            _Name = name;
            _FullName = fullName;
            _FriendlyName = friendlyName;
        }
        #endregion
    }
}
