﻿using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MiniShop.Frontend.Client.Dtos
{
    public class BaseDto : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 实现通知更新
        /// </summary>
        /// <param name="propertyName"></param>
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
