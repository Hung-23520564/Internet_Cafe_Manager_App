using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internet_Cafe_Manager_App.Database;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Internet_Cafe_Manager_App.Database
{
    public enum PCStatus
    {
        Available,
        InUse,
        TimeRemainingLow,
        Offline,
        Error,
        TimeEnded
    }


    public class PC : INotifyPropertyChanged
    {
        
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _detailInfo;
        public string DetailInfo
        {
            get { return _detailInfo; }
            set
            {
                if (_detailInfo != value)
                {
                    _detailInfo = value;
                    OnPropertyChanged();
                }
            }
        }

        private PCStatus _status;
        public PCStatus Status
        {
            get { return _status; }
            set
            {
                if (_status != value)
                {
                    _status = value;
                    OnPropertyChanged();
                }
            }
        }

        private string _currentUser;
        public string CurrentUser
        {
            get { return _currentUser; }
            set
            {
                if (_currentUser != value)
                {
                    _currentUser = value;
                    OnPropertyChanged();
                }
            }
        }

        private DateTime? _startTime;
        public DateTime? StartTime
        {
            get { return _startTime; }
            set
            {
                if (_startTime != value)
                {
                    _startTime = value;
                    OnPropertyChanged();
                    OnPropertyChanged(nameof(TimeUsed));
                }
            }
        }

        private TimeSpan? _timeRemaining;
        public TimeSpan? TimeRemaining
        {
            get { return _timeRemaining; }
            set
            {
                if (_timeRemaining != value)
                {
                    _timeRemaining = value;
                    OnPropertyChanged();
                }
            }
        }

        private const int PricePer30Minutes = 10000;
        private static readonly TimeSpan TimePerPriceUnit = TimeSpan.FromMinutes(30);

        public static TimeSpan CalculateTotalTimeFromBudget(int budget)
        {
            if (budget <= 0)
            {
                return TimeSpan.Zero;
            }
            int priceUnits = budget / PricePer30Minutes;
            return TimeSpan.FromMinutes(priceUnits * 30);
        }

        public void DecrementTimeRemaining(TimeSpan duration)
        {
            if (TimeRemaining.HasValue)
            {
                TimeSpan newTimeRemaining = TimeRemaining.Value.Subtract(duration);
                TimeRemaining = (newTimeRemaining > TimeSpan.Zero) ? newTimeRemaining : TimeSpan.Zero;
                // Logic thay đổi trạng thái đã được chuyển sang FormDashboard.cs
            }
        }

        private int _budget;
        public int Budget
        {
            get { return _budget; }
            set
            {
                if (_budget != value)
                {
                    _budget = value;
                    OnPropertyChanged();
                }
            }
        }

        public TimeSpan TimeUsed
        {
            get
            {
                if (Status == PCStatus.InUse && StartTime.HasValue)
                {
                    return DateTime.Now - StartTime.Value;
                }
                return TimeSpan.Zero;
            }
        }

        private string _order;
        public string Order
        {
            get { return _order; }
            set
            {
                if (_order != value)
                {
                    _order = value;
                    OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void NotifyTimeUsedChanged()
        {
            OnPropertyChanged(nameof(TimeUsed));
        }

        public PC(string name)
        {
            Name = name;
            Status = PCStatus.Available;
            CurrentUser = null;
            StartTime = null;
            TimeRemaining = null;
            Order = null;
            Budget = 0;
        }
    }
}