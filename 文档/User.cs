using System;

namespace cyq.web.Entity.Cyqdata
{
    public class UserBean 
    {
        private int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
            set
            {
                _ID = value;
            }
        }
        private string _Name;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
        private int _Age;
        public int Age
        {
            get
            {
                return _Age;
            }
            set
            {
                _Age = value;
            }
        }
        private DateTime _Addtime;
        public DateTime Addtime
        {
            get
            {
                return _Addtime;
            }
            set
            {
                _Addtime = value;
            }
        }
    }
}
