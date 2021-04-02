//=================================================================================
//
//           Copyright (C) 2007-2008 鸡丁(ChicktikStudio)工作室   
//           All rights reserved
//
//           class : LastOne.Game

//           description : 任何人不得重新反编译或用于任何商业程序或网站。
//                         飞鸿本人将保留一切权利予以追究！
//           2021/3/31 13:46:42
//
//           created by 飞鸿 at  2021/3/31 13:46:42
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
    public delegate void GameEvent(object sender, GameEventArgs e);

    public class GameEventArgs : EventArgs
    {
        public GameEventArgs(object[] param) { this.Result = param; }

        private object[] _result = { };
        public object[] Result { get { return _result; } set { this._result = value; } }
    }

    /// <summary>
    /// Game
    /// </summary>
    public class Game
    {
        #region Variables

        // variables here

        // round,player,row,count
        //private List<Tuple<int, Player, int, int>> _stepResults = new List<Tuple<int, Player, int, int>>();

        private List<Player> _players = new List<Player>();

        private int[] _matrix = { };

        public event GameEvent GameStatusChanged;

        #endregion

        #region Constructors

        public Game(int[] matrix)
        {
            if (matrix != null && matrix.Length > 0)
                _matrix = matrix;
        }

        #endregion

        #region Property

        // properties here

        public Player CurrentPlayer  {  get  {  return _players.First(x => x.Status == PlayerStatus.Submit);  } }

        #endregion

        #region Functions

        // private members here

        public void addPlayer(Player player, bool isFirst = false)
        {
            player.SubmitEnd += new PlayerEvent(OnSubmitEnd);
            _players.Add(player);

            if (isFirst)
                player.keepSubmit();
        }

        public void start() 
        {
            if (_matrix.Length < 1)
            {
                System.Windows.Forms.MessageBox.Show(new ArgumentNullException("count for row", "Count for row can not be null").Message);
                return;
            }

            if (_players.Count < 2)
            {
                System.Windows.Forms.MessageBox.Show(new ArgumentNullException("players", "needs two players at least").Message);
                return;
            }

            if (GameStatusChanged != null) 
            {
                GameStatusChanged(this, new GameEventArgs(new object[] { _matrix, _players }));
            }
        }

        public void reset() 
        {
            _players.ForEach((p) => { p.keepNormal(); });

            start();
        }

        private void OnSubmitEnd(object sender, GameEventArgs e)
        {
            Player player = _players.Find(x => x.Equals(sender as Player));
            Player nextPlayer = _players.Find(x => x.Status == PlayerStatus.Waiting && !x.Equals(sender as Player));
            int[] res = e.Result.Select(x => int.Parse(x.ToString())).ToArray();

            player.keepWaiting();
            nextPlayer.keepSubmit();

            _matrix[res.First()] -= res.Last();

            if (_matrix[res.First()] < 0)
                _matrix[res.First()] = 0;

            if (_matrix.Sum() == 0)
            {
                _players.ForEach((p) => { p.keepLose(); });
                nextPlayer.keepWin();
            }
            else if (_matrix.Sum() == 1) 
            {
                _players.ForEach((p) => { p.keepLose(); });
                player.keepWin();
            }

            if (GameStatusChanged != null)
            {
                GameStatusChanged(this, new GameEventArgs(new object[] { _matrix, _players }));
            }
        }

        #endregion

        #region Methods

        // public members here

        #endregion

    }
}
