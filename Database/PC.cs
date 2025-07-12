using System;
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
        [JsonIgnore]
        public bool IsTopUpRequestSent { get; set; }

        public DateTime? TimeEndedTimestamp { get; set; }

        private string _name;
        public string Name
        {
            get => _name;
            set { if (_name != value) { _name = value; OnPropertyChanged(); } }
        }

        private string _detailInfo;
        public string DetailInfo
        {
            get => _detailInfo;
            set { if (_detailInfo != value) { _detailInfo = value; OnPropertyChanged(); } }
        }

        private PCStatus _status;
        public PCStatus Status
        {
            get => _status;
            set { if (_status != value) { _status = value; OnPropertyChanged(); } }
        }

        private string _currentUser;
        public string CurrentUser
        {
            get => _currentUser;
            set { if (_currentUser != value) { _currentUser = value; OnPropertyChanged(); } }
        }

        private DateTime? _startTime;
        public DateTime? StartTime
        {
            get => _startTime;
            set { if (_startTime != value) { _startTime = value; OnPropertyChanged(nameof(TimeUsed)); } }
        }

        private TimeSpan? _timeRemaining;
        public TimeSpan? TimeRemaining
        {
            get => _timeRemaining;
            set { if (_timeRemaining != value) { _timeRemaining = value; OnPropertyChanged(); } }
        }

        private int _budget;
        public int Budget
        {
            get => _budget;
            set { if (_budget != value) { _budget = value; OnPropertyChanged(); } }
        }

        public TimeSpan TimeUsed => (Status == PCStatus.InUse && StartTime.HasValue) ? DateTime.Now - StartTime.Value : TimeSpan.Zero;

        private string _order;
        public string Order
        {
            get => _order;
            set { if (_order != value) { _order = value; OnPropertyChanged(); } }
        }

        /// <summary>
        /// *** THAY ĐỔI QUAN TRỌNG ***
        /// Phương thức này giờ đây nhận đơn giá và thời gian làm tham số
        /// để tính toán linh hoạt thay vì dùng giá trị cố định.
        /// </summary>
        public static TimeSpan CalculateTotalTimeFromBudget(int budget, int pricePerUnit, int minutesPerUnit)
        {
            if (budget <= 0 || pricePerUnit <= 0 || minutesPerUnit <= 0)
            {
                return TimeSpan.Zero;
            }
            // Tính số lượng "đơn vị" mua được và nhân với thời gian của mỗi đơn vị
            double unitsPurchased = (double)budget / pricePerUnit;
            double totalMinutes = unitsPurchased * minutesPerUnit;
            return TimeSpan.FromMinutes(totalMinutes);
        }

        public void DecrementTimeRemaining(TimeSpan duration)
        {
            if (TimeRemaining.HasValue)
            {
                TimeSpan newTimeRemaining = TimeRemaining.Value.Subtract(duration);
                TimeRemaining = (newTimeRemaining > TimeSpan.Zero) ? newTimeRemaining : TimeSpan.Zero;
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
        }
    }
}