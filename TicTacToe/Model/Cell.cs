﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Model
{
    class Cell : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Player player;

        public Cell(int id)
        {
            Player = null;
            Id = id;
        }

        public Player Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
                OnPropertyChanged("Player");
            }
        }

        public int Id
        {
            get; private set;
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
