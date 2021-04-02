//=================================================================================
//
//           Copyright (C) 2007-2008 鸡丁(ChicktikStudio)工作室   
//           All rights reserved
//
//           class : LastOne.Player

//           description : 任何人不得重新反编译或用于任何商业程序或网站。
//                         飞鸿本人将保留一切权利予以追究！
//           2021/3/31 13:46:34
//
//           created by 飞鸿 at  2021/3/31 13:46:34
//
//           http://www.ChicktikStudio.com
//
//
//==================================================================================


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LastOne
{
    public delegate void PlayerEvent(object sender, GameEventArgs e);
    /// <summary>
    /// Player
    /// </summary>
    public class Player
    {
        #region Variables

        // variables here
        private string _name = string.Empty;
        private PlayerStatus _status = PlayerStatus.Normal;
        private int[] _countForTakes = { };
        private List<Tuple<int, int>> _result = new List<Tuple<int, int>>() { };

        public event PlayerEvent SubmitEnd;
        #endregion

        #region Constructors

        public Player(string name) : this(name, PlayerStatus.Normal) { }

        public Player(string name, PlayerStatus status)
        {
            this.Name = name;
            this.Status = status;
        }

        #endregion

        #region Property

        // properties here
        public string Name { get { return _name; } private set { _name = value; } }

        public PlayerStatus Status { get { return _status; } private set { _status = value; } }

        public int[] CountForTakes { get { return _countForTakes; } set { _countForTakes = value; } }

        #endregion

        #region Functions

        // private members here

        #endregion

        #region Methods

        // public members here

        public void pickup(string result)
        {
            var info = System.Text.RegularExpressions.Regex.Replace(result, @"[^_\d]", string.Empty).Split('_').Select(x => int.Parse(x)).ToArray();

            if (_result.Exists(x => x.Item1.Equals(info.First()) && x.Item2.Equals(info.Skip(1).First())))
            {
                _result.RemoveAt(_result.FindIndex(x => x.Item1.Equals(info.First()) && x.Item2.Equals(info.Skip(1).First())));
                return;
            }

            _result.Add(new Tuple<int, int>(info.First(), info.Skip(1).First()));
        }

        public void submit() 
        {
            if (_result.Count < 1) 
            {
                System.Windows.Forms.MessageBox.Show(new ArgumentNullException("please select one item at least").Message);
                return;
            }

            if (CountForTakes.Length > 0 && ! CountForTakes.Contains(_result.Count))
            {
                System.Windows.Forms.MessageBox.Show(new IndexOutOfRangeException("the count of selection is out of range").Message);
                return;

            }

            if (SubmitEnd != null)
                SubmitEnd(this, new GameEventArgs(new object[] { _result.First().Item1, _result.Count }));

            _result.Clear();

            keepWaiting();
        }

        public void keepNormal()
        {
            _result.Clear();
            Status = PlayerStatus.Normal;
        }

        public void keepSubmit() 
        {
            Status = PlayerStatus.Submit;
        }

        public void keepWaiting()
        {
            Status = PlayerStatus.Waiting;
        }

        public void keepWin()
        {
            _result.Clear();
            Status = PlayerStatus.Win;
        }

        public void keepLose()
        {
            _result.Clear();
            Status = PlayerStatus.Lose;
        }

        #endregion

    }

    public enum PlayerStatus 
    { 
        Normal,
        Submit,
        Waiting,
        Win,
        Lose
    }
}
